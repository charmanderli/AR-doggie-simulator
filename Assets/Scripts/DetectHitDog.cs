using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHitDog : MonoBehaviour
{
    private GameObject husky;
    [SerializeField] bool destroyThis;
    [SerializeField] bool triggerEat;
    [SerializeField] bool triggerJump;
    [SerializeField] GameObject nextCanvas;
    private Animator huskyAnimator;

    private bool OnTriggerEnter(Collider other)
    {
        husky = other.gameObject;
        huskyAnimator = husky.GetComponent<Animator>();

        if (destroyThis)
        {
            Destroy(this.gameObject, 1f);

        }

        if (triggerEat)
        {
            Debug.Log(husky.name);
            TriggerEatAnimation();
        }

        if (triggerJump)
        {
            TriggerJumpAnimation();
        }

        if (nextCanvas)
        {
            nextCanvas.SetActive(true);
        }
        return true;
    }


    private void TriggerJumpAnimation()
    {
        if (huskyAnimator)
        {
            huskyAnimator.SetTrigger("New Trigger");
        }
    }

    private void TriggerWalkAnimation()
    {
        if (huskyAnimator)
        {
            huskyAnimator.SetBool("IsWalking", true);
        }
    }

    private void TriggerEatAnimation()
    {
        if (huskyAnimator)
        {
            huskyAnimator.SetBool("IsEating", true);
        }
    }
}
