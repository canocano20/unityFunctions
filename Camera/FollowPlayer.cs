using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private float _smoothSpeed;

    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        PlayerFollow(offset, _smoothSpeed);
    }

    private void PlayerFollow(Vector3 offset, float smoothSpeed)
    {
        Vector3 desiredPosition = _player.transform.position + offset;
        Vector3 smoothMovement = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothMovement;
    }
}
