using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotState : MonoBehaviour
{
    public Text objtsInSlot;
    public Image objtsImage;

    public int state;

    void Update()
    {
        if (state != 0)
        {
            objtsInSlot.text = state.ToString();
            objtsImage.enabled = true;
        }
        else 
        {
            objtsInSlot.text = state.ToString();
            objtsImage.enabled = false;
        }
    }
}
