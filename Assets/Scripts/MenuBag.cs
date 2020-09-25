using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBag : MonoBehaviour
{

    public List<Text> texts;

    public InventoryState inventoryState;

    private void Update() 
    {
        int i = 0;
        foreach (var objs in inventoryState.text)
        {
            texts[i].text = objs;
            i++;
        }
    } 
}
