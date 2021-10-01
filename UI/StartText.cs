using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartText : MonoBehaviour
{
    public TextMeshProUGUI txtmesh;

    [SerializeField] private float changeVal = 5f;

    [SerializeField]
    private int upperLimit;
    [SerializeField]
    private int lowerLimit;
    bool goUP = true;

    private void Update()
    {
        ChangeValueBetweenNumbers(upperLimit, lowerLimit, txtmesh.fontSize );
        if (goUP)
        {
            txtmesh.fontSize += changeVal * Time.deltaTime;
        }
        else
        {
            txtmesh.fontSize -= changeVal * Time.deltaTime;
        }
    }
    public void ChangeValueBetweenNumbers(int minPoint, int maxPoint, float value)
    {
        if (value > maxPoint)
        {
            goUP = false;
        }
        else if (value < minPoint)
        {
            goUP = true;
        }

    }
}
