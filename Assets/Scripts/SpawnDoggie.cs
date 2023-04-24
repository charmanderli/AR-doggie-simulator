using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class SpawnDoggie : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    private GameObject spawnObj;
    private ARRaycastManager aRRaycastManager;
    private ARPlaneManager aRPlaneManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    [SerializeField] Vector3 offset;
    private void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
        aRPlaneManager.planesChanged += PlaneChanged;
    }

    private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if (args.added != null && spawnObj == null)
        {
            ARPlane arPlane = args.added[0];
            spawnObj = Instantiate(prefab, arPlane.transform.position + offset, Quaternion.Euler(0, 180, 0));
        }
    }
}
