using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTriggerConvo : MonoBehaviour
{
    private DialogueTrigger trigger;
    void Start()
    {
        trigger = this.GetComponent<DialogueTrigger>();
        trigger.TriggerDialogue();
    }

}
