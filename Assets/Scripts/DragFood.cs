using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class DragFood : MonoBehaviour
{
    // private ARRaycastManager aRRaycastManager;
    // private ARPlaneManager aRPlaneManager;
    // private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private Vector3 touchPosition;
    // private bool onTouchHold = false;
    private Transform toDrag;

    void Awake()
    {
        // aRRaycastManager = GetComponent<ARRaycastManager>();
        // aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    private Vector3 GetTouchPos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchPosition = Input.mousePosition - GetTouchPos();
            }

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - touchPosition);
            }

            // if (touch.phase == TouchPhase.Ended)
            // {
            //     onTouchHold = false;
            // }
        }
    }


}
