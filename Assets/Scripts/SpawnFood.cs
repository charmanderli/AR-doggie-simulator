using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    [SerializeField] GameObject food;

    [SerializeField] GameObject wayPoint;
    private Vector3 wayPointPosition;
    // [SerializeField] Vector3 offset;
    private Vector3 offset;

    // Update is called once per frame
    public void Spawn()
    {
        // wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        Debug.Log(wayPointPosition);
        int val = Random.Range(0, 20);
        offset = new Vector3(val * 0.01f, -0.35f, val * 0.01f);
        Instantiate(food, offset, Quaternion.identity);
    }


}
