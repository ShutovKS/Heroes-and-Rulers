using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        float oX;
        oX = GameObject.Find("camera").transform.position.x;
        float oY = GameObject.Find("camera").transform.position.y;
        float size = GetComponent<Camera>().orthographicSize;

        //перемещение камеры
        if (Input.GetKey(KeyCode.RightArrow))
        {
            oX += 0.0075f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            oX -= 0.0075f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            oY += 0.0075f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            oY -= 0.0075f;
        }


        //изменение масштаба
        if (Input.GetKey(KeyCode.Q))
        {
            if (size > 5f)
            {
                size -= size / 100;
            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (size < 75f)
            {
                size += size / 100;
            }
        }


        GetComponent<Transform>().position = new Vector3(oX, oY, -10f);
        GetComponent<Camera>().orthographicSize = size;
    }
}