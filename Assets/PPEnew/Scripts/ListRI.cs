using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListRI : MonoBehaviour
{

    public static int currNo=0;
    int val = currNo;
    public RandomizeIMages[] randomizeIs;
    private void Start()
    {

        if (SubVidName.name.Equals("50")) //  total 5 types in menu scene (PPE) so add 5 from next
        {
            SwitchFun(0,true);
        }
        if (SubVidName.name.Equals("100"))//(TOOL)
        {
           
            SwitchFun(5,false);
        }
        randomizeIs[currNo].gameObject.SetActive(true);
    }

    void SwitchFun(int additive,bool b)
    {
        foreach (RandomizeIMages j in randomizeIs)
        {
            j.avatarPPE.SetActive(b);
        }
        switch (GetTagVal.name)
        {
            case "A": currNo = 0 + additive; break;
            case "B": currNo = 1 + additive; break;
            case "C": currNo = 2 + additive; break;
            case "D": currNo = 3 + additive; break;
            case "E": currNo = 4 + additive; break;
        }
    }

}
