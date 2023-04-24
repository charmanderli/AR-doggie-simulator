using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    CountdownTimer timer;
    Counter touchCounter;
    public GameObject canvas;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        timer = canvas.GetComponent<CountdownTimer>();
        touchCounter = canvas.GetComponent<Counter>();
        speed = GameObject.Find("AR session Origin").GetComponent<Chase>().speed;

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Harmful")
        {
            speed *= 1.1f;
            return;
        }
        else if (other.gameObject.tag == "Supplies")
        {

            touchCounter.IncrementByNameAndUpdate(other.gameObject.name);

            Destroy(other.gameObject);
            // timer.start();


            // TODO: reset timer
            // TODO: update count of touches

            int randomIndex = Random.Range(0, spawnPrefabs.Length);
            ReSpawnCube(spawnPrefabs[randomIndex]);
        }


    }

    private void ReSpawnCube(GameObject cube)
    {
        Transform playerTransform = this.gameObject.transform;

        // This simply spawns the next cube -2 on the x,
        // TODO: make this random for x,y coordinates
        Vector3 newPosition = new Vector3(transform.position.x - 0.5f,
            transform.position.y - 1,
            transform.position.z - 0.5f);

        Instantiate(cube, newPosition, Quaternion.identity);


    }
}