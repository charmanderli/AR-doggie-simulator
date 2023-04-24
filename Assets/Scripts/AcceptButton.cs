using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class AcceptButton : MonoBehaviour
{
    private Button acceptButton;

    [SerializeField] string nextScene;
    DialogueTrigger trigger;
    void Start()
    {
        UIDocument m_UIDocument = GetComponent<UIDocument>();
        var rootElement = m_UIDocument.rootVisualElement;

        acceptButton = rootElement.Q<Button>("Accept");

        acceptButton.clickable.clicked += OnButtonClicked;
    }

    private void OnButtonClicked()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(nextScene);
    }
}
