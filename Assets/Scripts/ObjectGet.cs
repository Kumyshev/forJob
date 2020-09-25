using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGet : MonoBehaviour
{
    public InventoryState inventoryState;
    public ObjParams objParams;
    private void OnMouseDown()
    {
        if (objParams.tagName == gameObject.tag)
        {
            objParams.number = objParams.number + 1;
        }
        inventoryState.SetObjInBag(objParams.number, objParams.tagName);
        Destroy(gameObject);
    }

}
