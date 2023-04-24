using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class BoxOpen : MonoBehaviour
{
    private Vector3 touchPosition;
    [SerializeField] GameObject acceptUI;

    [SerializeField] GameObject nextCanvas;

    DialogueTrigger trigger;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            // Debug.DrawRay(ray.origin, ray.direction * 10000, Color.red, 100f);
            RaycastHit hit;
            // Debug.Log(ray.ToString());
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name.Contains("Caja"))
                    {

                        nextCanvas.SetActive(true);
                        acceptUI.SetActive(true);
                        trigger = this.GetComponent<DialogueTrigger>();
                        trigger.TriggerDialogue();
                    }
                }

            }


        }
    }
}
