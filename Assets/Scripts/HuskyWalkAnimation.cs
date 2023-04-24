using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuskyWalkAnimation : MonoBehaviour
{
    private Animator huskyAnimator;
    // Start is called before the first frame update
    void Start()
    {
        huskyAnimator = GetComponent<Animator>();
        huskyAnimator.SetBool("IsWalking", true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
