using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFromSlot : MonoBehaviour
{
    public InventoryState inventoryState;
    public List<ObjParams> objParams;
    public void MouseDown()
    {

        foreach (var objParam in objParams)
        {
            if (gameObject.name.Contains(objParam.tagName)) 
            {
                objParam.number = objParam.number - 1;
                inventoryState.SetObjInBag(objParam.number, objParam.tagName);
            }
        }        
    }
}
