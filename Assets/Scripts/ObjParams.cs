using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjParams : MonoBehaviour
{
    public string tagName { get; set; }
    public int number { get; set; }

    void Start () 
    {
        tagName = gameObject.tag;
    }
}
