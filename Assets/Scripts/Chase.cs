using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] GameObject wayPoint;
    private Vector3 wayPointPosition;
    public float speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the items will follow the waypoint.
        this.gameObject.transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, speed * Time.deltaTime);

    }
}