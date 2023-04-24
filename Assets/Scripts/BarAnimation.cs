using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
public class BarAnimation : MonoBehaviour
{
    public GameObject bar;
    public int time;
    void OnEnable()
    {
        AnimateBar();
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }
}
