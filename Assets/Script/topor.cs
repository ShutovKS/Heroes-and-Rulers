using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topor : MonoBehaviour
{
    int z = 0;
    bool tf = true;
    void FixedUpdate()
    {
        if (tf)
        {
            z -= Random.Range(7,9);
            transform.Rotate(0, 0, -Random.Range(7, 9));
            if (z <= -75)
                tf = false;
        }
        else
        {
            z += Random.Range(7, 9);
            transform.Rotate(0, 0, Random.Range(7, 9));
            if (z >= 0)
                tf = true;

        }
    }
}