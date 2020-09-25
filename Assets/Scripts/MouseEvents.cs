using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvents : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public GameObject menu;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerId == -2) 
        {
            menu.SetActive(true);
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.pointerId == -2)
        {
            menu.SetActive(false);
        }
    }
}

