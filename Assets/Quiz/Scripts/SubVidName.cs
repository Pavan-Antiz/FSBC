using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SubVidName : MonoBehaviour
{
    public new static string name;
  
    public void OnClicked(string i)
    {
        name = i;
    }
}

