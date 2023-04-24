
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInFrontOfCamera : MonoBehaviour
{
    public GameObject wayPoint;
    private Vector3 wayPointPosition;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, -4, 13);
        gameObject.transform.position = offset;
    }

    // Update is called once per frame
    void Update()
    {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);

        gameObject.transform.position = wayPointPosition;
    }
}
