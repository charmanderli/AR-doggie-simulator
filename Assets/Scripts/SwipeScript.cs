using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    private Vector2 startPosition, endPosition, direction;
    private float touchTimeStart, touchTimeEnd, interval;
    [SerializeField] float throwForceInXandY = 1f;
    [SerializeField] float throwForceInZ = 50f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            // Debug.Log("touched");
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchTimeStart = Time.time;
                startPosition = Input.GetTouch(0).position;
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                touchTimeEnd = Time.time;
                interval = touchTimeEnd - touchTimeStart;
                endPosition = Input.GetTouch(0).position;

                direction = startPosition - endPosition;
                rb.isKinematic = false;
                rb.AddForce(-direction.x * throwForceInXandY, -direction.y * throwForceInXandY, throwForceInZ / interval);
                Destroy(gameObject, 5f);
            }
        }
    }
}
