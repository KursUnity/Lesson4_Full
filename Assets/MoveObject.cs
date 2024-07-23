using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }
    }

    void MoveUp()
    {
        transform.Translate(Vector3.up);
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down);
    }
}
