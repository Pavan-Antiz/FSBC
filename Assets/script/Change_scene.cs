using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Change_scene : MonoBehaviour, IPointerClickHandler
{
    public Text headding;
    string s1 = "Bolt Tightening";
    public string scenename;
    public Button BtnName;
    public static string btnme;
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(scenename);
    }

    // Start is called before the first frame update
    void Start()
    {
        //btnme = BtnName.name;
        //strcmp(tagno);
        //no = tagno.na
        //GetTagVal.name   
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void scenechanger()
    {
        if (GetTagVal.name == "A")
        {
            //headding.text = "Bolt Tightening";
            SceneManager.LoadScene("Selection_Menu 1");
        }
        if (GetTagVal.name == "B")
        {
            //headding.text = "Bearing Assembly & Disassembly";
            SceneManager.LoadScene("Selection_Menu 2");
        }
    }

    public void subscenechanger()
    {
        if (SubVidName.name == "A1" || SubVidName.name == "PPEA")
        {
            //headding.text = "Bolt Tightening";
            SceneManager.LoadScene("Selection_Menu 1");
        }
        if (SubVidName.name == "B1" || SubVidName.name == "PPEB")
        {
            //headding.text = "Bearing Assembly & Disassembly";
            SceneManager.LoadScene("Selection_Menu 2");
        }
    }
    public void nextscene()
    {
        SceneManager.LoadScene(scenename);
    }
    //public void strcmp(Button tagName)
    // {
    //     if (tagName.gameObject.CompareTag("A"))
    //     {
    //         print("Tag found in scene changer" + tagName.ToString());
    //     }
    // }
}