using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onhover_color : MonoBehaviour,IPointerExitHandler,IPointerEnterHandler
{
  //  public Button hover;
    public Scrollbar scrol;
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("a");
      var  _This = this.GetComponent<Image>();
        _This.color = new Color(251, 184, 51);
       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("b");
        var _This = this.GetComponent<Image>();
        _This.color = new Color(251, 255, 255);
    }

    public void OnButtonClicked1()
    {
        //if (scrol.value >= 0)
        //{
            scrol.value -= 0.1f;
            // slider. += 0.1f; 
        //}
    }
    public void OnButtonClicked() {

        scrol.value += 0.1f;
      // slider. += 0.1f; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
