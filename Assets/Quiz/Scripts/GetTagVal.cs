using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTagVal : MonoBehaviour
{

    public Button[] selection;
    public static string name;
    //public GameObject[] gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClicked(int i)
    {
        name = selection[i].name;
        print(selection[i].name);
    }
}
