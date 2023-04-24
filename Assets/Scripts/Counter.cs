using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject[] myPrefabs;
    Dictionary<string, int> itemInfo;
    [SerializeField] Text itemText;
    [SerializeField] Text valueText;
    // Start is called before the first frame update
    public void Start()
    {
        itemInfo = new Dictionary<string, int>();

        // Debug.Log(myPrefabs.Length);

        for (int i = 0; i < myPrefabs.Length; i++)
        {
            itemInfo.Add(myPrefabs[i].gameObject.name, 0);
        }
        itemText.text = this.ItemsToString();
        valueText.text = this.ValuesToString();
        itemText.color = Color.white;
        valueText.color = Color.white;
    }

    public string ItemsToString()
    {
        string items = "";
        foreach (KeyValuePair<string, int> element in itemInfo)
        {
            items += element.Key + "\n";
        }
        return items;
    }

    public string ValuesToString()
    {
        string values = "";
        foreach (KeyValuePair<string, int> element in itemInfo)
        {
            values += element.Value + "\n";
        }
        return values;
    }


    public void IncrementByNameAndUpdate(string name)
    {

        string standardizedName = name.Split('(')[0];
        Debug.Log(standardizedName);

        if (!itemInfo.ContainsKey(standardizedName))
        {
            Debug.Log("false");
            return;
        }


        itemInfo[standardizedName] += 1;
        valueText.text = this.ValuesToString();
    }


}
