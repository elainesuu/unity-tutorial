using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{

    public int xPos;
    public int zPos;
    public GameObject car;

    void Start()
    {
        
    }

    void Update()
    {
        xPos = Random.Range(-1, 0);
        zPos = Random.Range(-3, 3);
        car.transform.position = new Vector3(xPos, 0, zPos);
    }
}

