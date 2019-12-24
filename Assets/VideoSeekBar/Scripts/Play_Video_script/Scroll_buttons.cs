using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll_buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public Scrollbar bar;

public void scroll_up()
    {

        //bar = gameObject.GetComponent<Scrollbar>();
        //bar.value =bar.value + 1;
        bar.value += 0.1f;
    }

    public void scroll_down()
    {
        //bar = gameObject.GetComponent<Scrollbar>();
        //bar.value = bar.value - 1;
        bar.value -= 0.1f;
    }


}
