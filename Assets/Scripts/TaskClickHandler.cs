using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TaskClickHandler : MonoBehaviour
{
    private VisualElement elem;
    private VisualElement elem2;
    private Button closeButton;
    [SerializeField] GameObject Monday;
    [SerializeField] GameObject Tuesday;
    private void OnEnable()
    {
        UIDocument m_UIDocument = GetComponent<UIDocument>();
        var rootElement = m_UIDocument.rootVisualElement;

        elem = rootElement.Q<VisualElement>("Monday");
        elem2 = rootElement.Q<VisualElement>("Tuesday");
        closeButton = rootElement.Q<Button>("Close");

        elem.RegisterCallback<ClickEvent>(OnItemClicked);
        elem2.RegisterCallback<ClickEvent>(OnItemClicked2);
        closeButton.clickable.clicked += OnButtonClicked;
    }

    private void OnItemClicked(ClickEvent evt)
    {
        gameObject.SetActive(false);
        Monday.SetActive(true);
        Debug.Log(elem.name + " button clicked");
    }
    private void OnItemClicked2(ClickEvent evt)
    {
        gameObject.SetActive(false);
        Tuesday.SetActive(true);
        Debug.Log(elem.name + " button clicked");

    }

    private void OnButtonClicked()
    {
        gameObject.SetActive(false);
    }
}
