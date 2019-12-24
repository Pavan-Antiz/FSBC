using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using VideoConstruc1;
using UnityEngine.UI;
using System;

public class slideON_Off : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject obj;
  //  public Style1VideoPlay vid;
    public Slider seekBar;
    public void OnPointerDown(PointerEventData eventData)
    {



       
            print("update");
            float frame = (float)seekBar.value * (float)Style1VideoPlay.videoPlayer.frameCount;
            Style1VideoPlay.videoPlayer.frame = (long)frame;
            //  slde = true;

            obj.SetActive(false);
            

    }
   

    private void OnPointerDown()
    {
        print("up");
        throw new NotImplementedException();
    }

    private void OnPointerDown(PointerEventData pointerEventData, object eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StartCoroutine(assssaa());

 
    }
    IEnumerator assssaa()
    {
        yield return new WaitForSeconds(.34f);

        obj.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
