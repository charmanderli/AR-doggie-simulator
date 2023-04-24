using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class WalkDoggie : MonoBehaviour
{


    [SerializeField] GameObject doggie;
    [SerializeField] GameObject leash;
    [SerializeField] GameObject trash;
    [SerializeField] private GameObject line;
    private LineController lc;
    [SerializeField] GameObject wayPoint;
    private Vector3 wayPointPosition;
    private Vector3 offset;

    void Start()
    {
        offset = doggie.transform.position - wayPointPosition;
        lc = line.GetComponent<LineController>();

    }
    void Update()
    {
        // if (spawnObj)
        // {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);

        doggie.transform.position = wayPointPosition + offset;
        // }
    }

    public void SwitchLeash()
    {
        trash.SetActive(false);
        leash.SetActive(true);
        line.SetActive(true);
        Transform[] points = { leash.transform, doggie.transform };
        lc.SetUpLine(points);
    }

    public void SwitchTrash()
    {

        trash.SetActive(true);
        leash.SetActive(false);
        line.SetActive(false);
    }

}
