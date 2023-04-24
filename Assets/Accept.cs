using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Accept : MonoBehaviour
{

    private Label m_Label;
    private int m_ButtonClickCount = 0;
    private Toggle m_Toggle;
    private Button m_Button;
    [SerializeField] GameObject TaskList;

    public void Start()
    {
        UIDocument m_UIDocument = GetComponent<UIDocument>();
        var rootElement = m_UIDocument.rootVisualElement;

        // This searches for the VisualElement Button named “EventButton”
        // rootElement.Query<> and rootElement.Q<> can both be used
        m_Button = rootElement.Q<Button>("Accept");

        // Elements with no values like Buttons can register callBacks
        // with clickable.clicked
        m_Button.clickable.clicked += OnButtonClicked;

        // This searches for the VisualElement Toggle named “ColorToggle”
        m_Toggle = rootElement.Query<Toggle>("ColorToggle");

        // Elements with changing values: toggle, TextField, etc... 
        // implement the INotifyValueChanged interface,
        // meaning they use RegisterValueChangedCallback and 
        // UnRegisterValueChangedCallback
        m_Toggle.RegisterValueChangedCallback(OnToggleValueChanged);

        // Cache the reference to the Label since we will access it repeatedly.
        // This avoids the relatively costly VisualElement search each time we update
        // the label.
        // m_Label = rootElement.Q<Label>("IncrementLabel");
        // m_Label.text = m_ButtonClickCount.ToString();
    }

    // private void OnDestroy()
    // {
    //     m_Button.clickable.clicked -= OnClicked;
    //     m_Toggle.UnregisterValueChangedCallback(OnToggleValueChanged);
    // }

    private void OnButtonClicked()
    {
        // m_ButtonClickCount++;
        // m_Label.text = m_ButtonClickCount.ToString();
        Debug.Log("button clicked");
        // TaskList.SetActive(true);
        // SceneManager.LoadScene(sceneName);
    }

    private void OnToggleValueChanged(ChangeEvent<bool> evt)
    {
        Debug.Log("New toggle value is: " + evt.newValue);
    }
}