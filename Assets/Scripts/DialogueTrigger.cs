using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        // Debug.Log("trigger");
        // Debug.Log(dialogue.sentences.ToString());
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
