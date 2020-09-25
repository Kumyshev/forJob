using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryState : MonoBehaviour
{

    public List<SlotState> slots;

    public List<string> text;

    private int numberOfObjts;
    private string nameOfObjts = string.Empty;
    public void SetObjInBag(int objsNumber,string objsName)
    {
        numberOfObjts = objsNumber;
        nameOfObjts = objsName;
        text.Add(objsName);
    }


    private void Update()
    {
        foreach (var slot in slots) 
        {
            if (slot.name.Contains(nameOfObjts)) 
            {
                slot.state = numberOfObjts;
            }
        }
    }
}
