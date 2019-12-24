using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using VideoConstruc1;
using System;

public class VideoJumpBar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Style1VideoPlay video;
    public Slider bar;

    bool hovering = false;
    float pos;

    //void Update()
    //{
    //    if (!hovering)
    //    {
    //        print("hover");
    //        return;
    //    }
    //    print("non hover");
    //    //pos = Input.mousePosition.x / Screen.width;
    //    // bar.value = pos;
    //}

        public void OnPointerDown(PointerEventData eventData)
    {
       
        flag = 1;
        hovering = true;
    }
    public void flag_slider()
    {
       
        print("update");

        //float frame = (float)bar.value * (float)Style1VideoPlay.videoPlayer.frameCount;
        //Style1VideoPlay.videoPlayer.frame = (long)frame;
        //flag = 0;
        bar.value = pos;
     //  hovering = true;
        pos = Input.mousePosition.x / Screen.width;
       video.Seek(pos);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
      
         flag = 0;
        bar.value = pos;
        // bar[1].value = pos;
       // pos =   (float)Style1VideoPlay.videoPlayer.frame / (float)Style1VideoPlay.videoPlayer.frameCount;
         pos = Input.mousePosition.x / Screen.width;
        video.Seek(pos);
        hovering = false;
    }


   
    int flag; 
    //// Update is called once per frame
    void Update()
    {
       OnPointerDown();


        if (hovering && Style1VideoPlay.videoPlayer.isPlaying && flag == 1)
        {
            print("sss");
           //bar.value = pos;
            flag_slider();



            //VideoPlay.videoPlayer.frameCount;
        }
        //if(flag == 1)
        //{
        //    print("flag");

        //}
    }

    private void OnPointerDown()
    {
    }

    //public void OnPointerEnter(PointerEventData ped)
    //{
    //    //hovering = true;
    //    //bar.value = pos;



    //}

    //public void OnPointerExit(PointerEventData ped)
    //{
    //   // bar.value = 0;
    //    hovering = false;
    //    //video.PlayVideo ();
    //}

    //public void OnPointerClick(PointerEventData ped)
    //{
    //    bar.value = pos;
    //    // bar[1].value = pos;

    //      pos = Input.mousePosition.x / Screen.width;
    //     video.Seek(pos) ;


    //    //if(pos >= 0.008 && pos <= 0.045)
    //    //{
    //    //    video.first_value();
    //    //}

    //    //if (pos >= 0.158 && pos <= 0.365)
    //    //{
    //    //    video.second_value();
    //    //}
    //    //if (pos >= 0.46 && pos <= 0.504)
    //    //{
    //    //    video.Third_value();
    //    //}
    //    //if (pos >= 0.57 && pos <= 0.584)
    //    //{
    //    //    video.fourth_value();
    //    //}
    //    //if (pos >= 0.666 && pos <= 0.703)
    //    //{
    //    //    video.fifth_value();
    //    //}
    //    //if (pos >= 0.77 && pos <= 0.81)
    //    //{
    //    //    video.sixth_value();
    //    //}
    //    //if (pos >= 0.916 && pos <= 0.97)
    //    //{
    //    //    video.seventh_value();
    //    //}

    //    print("position: : "+ pos);
    //    //    video.Seek(pos);


    //}


    //public void OnBeginDrag(PointerEventData eventData)
    //{
    //    bar.value = pos;
    //    // bar[1].value = pos;

    //    pos = Input.mousePosition.x / Screen.width;
    //    video.Seek(pos);
    //    //pos = Input.mousePosition.x / Screen.width;
    //    //bar.value = pos;

    //}



    //public void OnMouseDrag(PointerEventData eventData)
    //{
    //    bar.value = pos;
    //    // bar[1].value = pos;

    //    pos = Input.mousePosition.x / Screen.width;
    //    video.Seek(pos);
    //}
    //public void OnDrag(PointerEventData data)
    //{

    //    bar.value = pos;
    //    // bar[1].value = pos;
    //    pos = Input.mousePosition.x / Screen.width;
    //   // pos = Input.mousePosition.x / (Screen.width/.9f);
    //    video.Seek(pos);
    //    //if (pos >= 0.008 && pos <= 0.045)
    //    //{
    //    //    video.first_value();
    //    //}

    //    //if (pos >= 0.158 && pos <= 0.365)
    //    //{
    //    //    video.second_value();
    //    //}
    //    //if (pos >= 0.46 && pos <= 0.504)
    //    //{
    //    //    video.Third_value();
    //    //}
    //    //if (pos >= 0.57 && pos <= 0.584)
    //    //{
    //    //    video.fourth_value();
    //    //}
    //    //if (pos >= 0.666 && pos <= 0.703)
    //    //{
    //    //    video.fifth_value();
    //    //}
    //    //if (pos >= 0.77 && pos <= 0.81)
    //    //{
    //    //    video.sixth_value();
    //    //}
    //    //if (pos >= 0.916 && pos <= 0.97)
    //    //{
    //    //    video.seventh_value();
    //    //}
    //}
    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    bar.value = pos;
    //    // bar[1].value = pos;
    //    pos = Input.mousePosition.x / Screen.width;
    //    // pos = Input.mousePosition.x / (Screen.width/.9f);
    //    video.Seek(pos);
    //    //if (pos >= 0.008 && pos <= 0.045)
    //    //{
    //    //    video.first_value();
    //    //}

    //    //if (pos >= 0.158 && pos <= 0.365)
    //    //{
    //    //    video.second_value();
    //    //}
    //    //if (pos >= 0.46 && pos <= 0.504)
    //    //{
    //    //    video.Third_value();
    //    //}
    //    //if (pos >= 0.57 && pos <= 0.584)
    //    //{
    //    //    video.fourth_value();
    //    //}
    //    //if (pos >= 0.666 && pos <= 0.703)
    //    //{
    //    //    video.fifth_value();
    //    //}
    //    //if (pos >= 0.77 && pos <= 0.81)
    //    //{
    //    //    video.sixth_value();
    //    //}
    //    //if (pos >= 0.916 && pos <= 0.97)
    //    //{
    //    //    video.seventh_value();
    //    //}
    //}
}