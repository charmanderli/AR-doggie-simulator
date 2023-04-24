using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class DayListHandler : MonoBehaviour
{
    private Button closeButton;
    [SerializeField] GameObject weekTaskList;
    [SerializeField] string[] SceneNames;
    private VisualElement[] elements;
    private VisualElement elem1;
    private VisualElement elem2;
    private VisualElement elem3;

    private void OnEnable()
    {
        UIDocument m_UIDocument = GetComponent<UIDocument>();
        var rootElement = m_UIDocument.rootVisualElement;
        // This searches for the VisualElement Button named “EventButton”
        // rootElement.Query<> and rootElement.Q<> can both be used
        closeButton = rootElement.Q<Button>("Close");


        // for (int i = 0; i < SceneNames.Length; i++)
        // {
        //     elements[i] = rootElement.Q<VisualElement>(SceneNames[i]);
        //     Debug.Log(SceneNames[i]);
        //     // Debug.Log(elements[i]);

        // }
        elem1 = rootElement.Q<VisualElement>(SceneNames[0]);
        elem2 = rootElement.Q<VisualElement>(SceneNames[1]);
        elem3 = rootElement.Q<VisualElement>(SceneNames[2]);
        elem1.RegisterCallback<ClickEvent>(OnVetClicked);
        elem2.RegisterCallback<ClickEvent>(OnFeedClicked);
        elem3.RegisterCallback<ClickEvent>(OnWalkClicked);


        // elements[0].RegisterCallback<ClickEvent>(OnItemClicked);
        // Elements with no values like Buttons can register callBacks
        // with clickable.clicked
        closeButton.clickable.clicked += OnButtonClicked;

    }

    private void OnVetClicked(ClickEvent evt)
    {
        SceneManager.LoadScene(SceneNames[0]);


        Debug.Log(evt.ToString());

    }
    private void OnFeedClicked(ClickEvent evt)
    {
        SceneManager.LoadScene(SceneNames[1]);


        Debug.Log(evt.ToString());

    }
    private void OnWalkClicked(ClickEvent evt)
    {
        SceneManager.LoadScene(SceneNames[2]);


        Debug.Log(evt.ToString());

    }

    private void OnButtonClicked()
    {
        gameObject.SetActive(false);
        weekTaskList.SetActive(true);
    }
}
