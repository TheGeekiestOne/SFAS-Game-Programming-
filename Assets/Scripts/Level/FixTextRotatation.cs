using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Created by : Ayran Olckers
 * 01/2020
 */
public class FixTextRotatation : MonoBehaviour
{
    Quaternion rotation;

    void Awake()
    {
        rotation = transform.rotation;
    }
    void LateUpdate()  {
        transform.position = transform.parent.transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
        transform.rotation = rotation;
    }
}
