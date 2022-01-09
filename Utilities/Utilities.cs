using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static Vector3 GetWorldMousePosition3D(float speed)
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, speed);
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        return worldMousePosition;
    }

    public static Vector3 ClampXPosition(Transform transform, float lowerLimit, float upperLimit)
    {
        Vector3 newPosition = new Vector3(Mathf.Clamp(transform.position.x, lowerLimit, upperLimit), transform.position.y, transform.position.z );
        
        return newPosition;
    }

    public static Vector3 ClampYPosition(Transform transform, float lowerLimit, float upperLimit)
    {
        Vector3 newPosition = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, lowerLimit, upperLimit), transform.position.z );
        
        return newPosition;
    }

    public static Vector3 ClampZPosition(Transform transform, float lowerLimit, float upperLimit)
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, lowerLimit, upperLimit) );
        
        return newPosition;
    }
}
