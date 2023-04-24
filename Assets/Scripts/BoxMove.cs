using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    private float speed = 2f;
    private int counter = 20;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.7)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
        }

        counter -= 1;
    }

}
