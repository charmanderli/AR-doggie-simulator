using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GoToTaskListButton : MonoBehaviour
{
    private Button goToTaskButton;
    [SerializeField] string sceneName;
    DialogueTrigger trigger;

    void Start()
    {
        UIDocument m_UIDocument = GetComponent<UIDocument>();
        var rootElement = m_UIDocument.rootVisualElement;

        goToTaskButton = rootElement.Q<Button>("GoToTask");

        goToTaskButton.clickable.clicked += OnButtonClicked;
    }

    private void OnButtonClicked()
    {
        SceneManager.LoadScene(sceneName);
        // SceneManager.LoadScene("TaskListUI");
        // trigger = this.GetComponent<DialogueTrigger>();
        // trigger.TriggerDialogue();

    }
}
