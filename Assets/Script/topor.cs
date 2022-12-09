using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topor : MonoBehaviour
{
    float z = 0;
    bool tf=true;
    void Update()
    {
        if (z>=-90f)
        {
            z -= 0.003f;
            //if (z <= -90)
            //tf = false;
        }
        if (z <= -90f) 
        { 
            z = 0f;
        }
        //if (!tf)
        //{
        //    z += 0.003f;
        //    if (z >= 0)
        //        tf = true;
        //}
        transform.Rotate(0,0,z);
        
    }
    
}