
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace VideoConstruc1
{
    public class Style1VideoPlay : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        public int totalNoVideos;
        //public GenericVP[] genericVP;
        public RawImage bgconvertor;
        public Texture[] bgtexs;
        public GameObject scrollGO;
        public string  videoName1, videoName2, videoName3, videoName4, videoName5, videoName6, videoName7,dosdon;
        public RawImage[] vidioDisplay;
        public static VideoPlayer videoPlayer;
        //   private VideoPlayer videoPlayer;
        private VideoSource videoSource;
        private AudioSource audioSource;
        public Button exit;
        public Text headdingText;
        public Button[] stepsButtons;

        public float[] stepTimings;
        public float[] vid1Timings;
        public float[] vid2Timings;
        public float[] vid3Timings;
        public float[] vid4Timings;
        public float[] vid5Timings;
        public float[] vid6Timings;
        public float[] vid7Timings;

        public String[] Vid1buttonText = {"Introduction", "Threaded fasteners", "Non threaded Fasteners", "Washers and their function", "Standard procedure for circlip assembly", "Effect of overtightening of bolts", "Standard procedure for bolt tightening"};
        public String[] Vid2buttonText = {"Introduction", "Bearings and their Functions", "Bearing Based on Load", "Bearing Based on Nature of Contact", "Bearing Number Description", "Deep Groove Ball Bearing", "Angular Contact Ball Bearing", "Taper Roll Bearing", "Do's And Dont's", "SKF Bearing Maintenance Tips" };
        public String[] Vid3buttonText;
        public String[] Vid4buttonText;
        public String[] Vid5buttonText;
        public String[] Vid6buttonText;
        public String[] Vid7buttonText;


        public string[] buttonDesc;
	public Text[] buttonText;
	public Button pauseButton,MMButton;
	public Sprite[] pauseButtonImages;
	int i = 0,timer,e;
        public GameObject[] fulscrn_helpr;
        public Button fulscren;
        public Sprite[] fulscrn_images;

        public Slider seekBar;
        bool slde = false;

        public GameObject img;

        public void OnEnable()
        {
           // LanguageSelect.langugeIs ="TAMIL";
            PlayVideo();
        }
        //void Start()
        //{
        //    PlayVideo();
        //}

        public void Update()
        {
           // OnPointerDown();

            if (!slde && videoPlayer.isPlaying)
            {
                //  print("s v3 :" + seek.value);
                seekBar.value = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
            }
        }

        private void OnPointerDown()
        {
            throw new NotImplementedException();
        }

        void Start () 
        {
		PlayVideo();

            //genericVP = new GenericVP;

            //int no = 1;
            //switch(no)
            //{
            //    case 0:
            //        videoname = genericVP[0].genericVideoName;
            //        stepTimings= genericVP[0].genericVideoStepTimings;

            //        break;
            //    case 1:
            //        videoname = genericVP[1].genericVideoName;
            //        stepTimings = genericVP[1].genericVideoStepTimings;
            //        break;
            //}
	}

	public void PlayVideo()
	{
		Application.runInBackground = true;
		StartCoroutine(playVideo());
	}


    void videodeceider(string headText,string[] bList,string currVname,float[] currTimings)
        {
            headdingText.text = headText;
            for (int inr = 0; inr < bList.Length; inr++)
            {
                stepsButtons[inr].gameObject.SetActive(true);
                stepsButtons[inr].gameObject.GetComponentInChildren<Text>().text = bList[inr];
            }

            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = Application.streamingAssetsPath + "/" + currVname + ".mp4";
            stepTimings = new float[currTimings.Length];
            currTimings.CopyTo(stepTimings, 0);
            print("djd + here");
            foreach (float f in stepTimings)
            {
                print(f);
            }
        }
        void dosdontsvideo(string headText,string currVname)
        {
            headdingText.text = headText;
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = Application.streamingAssetsPath + "/" + currVname + ".mp4";
        }
        void strcmp(Button tagName)
        {
            if (tagName.gameObject.CompareTag("A"))
            {
                print("Tagfound" + tagName);
            }
        }
	IEnumerator playVideo()
	{
		Destroy (videoPlayer);
		Destroy (audioSource);

		//Add VideoPlayer to the GameObject
		videoPlayer = gameObject.AddComponent<VideoPlayer> ();

		//Add AudioSource
		audioSource = gameObject.AddComponent<AudioSource> ();
		//Disable Play on Awake for both Video and Audio
		videoPlayer.playOnAwake = false;
		audioSource.playOnAwake = false;
		//audioSource.Pause ();
		videoPlayer.Stop ();
		audioSource.Stop ();
            //We want to play from video clip not from url

            //videoPlayer.source = VideoSource.VideoClip;

            // Vide clip from Url
            //videoPlayer.source = VideoSource.Url;
            //  videoPlayer.url = Application.streamingAssetsPath + "/" + videoname + ".mp4";
            //if (GetTagVal.name == "A")
            //if (LanguageSelect.langugeIs == "ENGLISH" && GetTagVal.name == "B")

            //if (GetTagVal.name == "B" && Change_scene.tagName.gameObject.CompareTag("A"))

            if (GetTagVal.name == "B")
            {

                videodeceider("Coolant check & fill module", Vid2buttonText,videoName2, vid2Timings);

                //headdingText.text= "Bearing Assembly & Disassembly";
                //for (int i = 0; i < Vid2buttonText.Length; i++)
                //{
                //    stepsButtons[i].gameObject.SetActive(true);
                //    stepsButtons[i].gameObject.GetComponentInChildren<Text>().text = Vid2buttonText[i];
                //}

                //videoPlayer.source = VideoSource.Url;
                //videoPlayer.url = Application.streamingAssetsPath + "/" + videoname + ".mp4";
                //stepTimings = new float[englishTimings.Length];
                //englishTimings.CopyTo(stepTimings, 0);
                //print("djd + here");
                //foreach(float f in stepTimings)
                //{
                //    print(f);
                //}
            }
            if (SubVidName.name == "B1")
            {
                videodeceider("Coolant check & fill module", Vid2buttonText, videoName2, vid2Timings);
            }

            if ( GetTagVal.name == "A")
            {
                videodeceider("Lubrication oil check & fill module", Vid1buttonText, videoName1, vid1Timings);
                //headdingText.text = "Bolt Tightening";
                //for (int i=0; i< Vid1buttonText.Length;i++)
                //{
                //    stepsButtons[i].gameObject.SetActive(true);
                //    stepsButtons[i].gameObject.GetComponentInChildren<Text>().text = Vid1buttonText[i];
                //}

                //videoPlayer.source = VideoSource.Url;
                //videoPlayer.url = Application.streamingAssetsPath + "/" + videoName1 + ".mp4";
                //stepTimings = new float[vid1Timings.Length];
                //vid1Timings.CopyTo(stepTimings, 0);
                ////stepTimings = vid1Timings;
                //foreach (float f in stepTimings)
                //{
                //    print("Vid1 "+f);
                //}
            }
            if(SubVidName.name=="A1")
            {
                videodeceider("Bolt Tightening", Vid1buttonText, videoName1, vid1Timings);
            }

            if (GetTagVal.name == "C")
            {
                videodeceider("Setting changeover", Vid3buttonText, videoName3, vid3Timings);
            }
            if (GetTagVal.name == "D")
            {
                videodeceider("Loading & unloading module", Vid4buttonText, videoName4, vid4Timings);
            }
            if (GetTagVal.name == "E")
            {
                videodeceider("Tool change module", Vid5buttonText, videoName5, vid5Timings);
            }
            if (GetTagVal.name == "F")
            {
                videodeceider("Insert change module", Vid6buttonText, videoName6, vid6Timings);
            }
            if (GetTagVal.name == "G")
            {
                videodeceider("Deburring module", Vid7buttonText, videoName7, vid7Timings);
            }
            //else
            //{
            //    fulscrn_helpr[0].SetActive(true);
            //    dosdontsvideo("DO'S AND DONT'S", dosdon);
            //    exit.GetComponentInChildren<Text>().text="Next";
            //    MMButton.gameObject.SetActive(false);
            //    if(dosdon.Length.Equals(20))
            //    {
            //        print("dosdon ended");
            //    }
            //}

            //Set Audio Output to AudioSource
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

		//Assign the Audio from Video to AudioSource to be played
		videoPlayer.EnableAudioTrack (0, true);
		videoPlayer.SetTargetAudioSource (0, audioSource);
		videoPlayer.controlledAudioTrackCount = 1;
		//Set video To Play then prepare Audio to prevent Buffering
		//videoPlayer.clip = videoToPlay;
		videoPlayer.Prepare ();

		//Wait until video is prepared
		while (!videoPlayer.isPrepared) {
			yield return null;
		}

		Debug.Log ("Done Preparing Video");

		//Assign the Texture from Video to RawImage to be displayed
		vidioDisplay[0].texture = videoPlayer.texture;
            vidioDisplay[1].texture = videoPlayer.texture;

            //Play Video
            videoPlayer.Play ();

		//Play Sound
		audioSource.Play ();

		while (videoPlayer.isPlaying) {

              // SEEKFunctionality(Mathf.FloorToInt((float)(videoPlayer.frameCount / videoPlayer.frameRate)));
                //timer = Mathf.FloorToInt((float)videoPlayer.time);
              //  SeekVideo((float)videoPlayer.time);
                timer = Mathf.FloorToInt ((float)videoPlayer.time);
			Debug.LogWarning ("Video Time: " + Mathf.FloorToInt ((float)videoPlayer.time));

			for (int i = 0; i < stepTimings.Length-1; i++) {
				if (timer >= stepTimings [i] && timer < stepTimings [i + 1]) 
                {
					stepsButtons [i].image.color = Color.green;
					buttonText[0].text = buttonDesc [i];
                        buttonText[1].text = buttonDesc[i];
                    }
                    else
                    {
                        //if (stepsButtons[16] || stepsButtons[22] || stepsButtons[31] )//|| stepsButtons[34])//|| stepsButtons[19] || stepsButtons[28] || stepsButtons[36])
                        {
                            //float g = 186f / 255f;
                            //stepsButtons[i].image.color = new Color(1f, g, 0f, 1f);
                            //stepsButtons[16].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[22].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[7].image.color = new Color(.584f, .8867f, .6308f);
                            //stepsButtons[31].image.color = new Color(.8f, .8f, .8f);
                            // stepsButtons[34].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[19].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[28].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[36].image.color = new Color(.8f, .8f, .8f);
                        }
                        stepsButtons[i].image.color = Color.white;
                    }



                }
                yield return null;

		}
		timer = 0;
		Debug.Log ("Done Playing Video");
	
	}

        public void fulscreen()
        {
            e++;
            if(e%2==1)
            {
                //  fulscren.image.sprite = fulscrn_images[0];
                MMButton.gameObject.GetComponentInChildren<Text>().text = "Minimize";
                //bgconvertor.texture = bgtexs[0];
                scrollGO.SetActive(false);
                for (int v = 0;v< fulscrn_helpr.Length;v++)
                {

                    fulscrn_helpr[v].SetActive(true);
                }
            }
            else
            {
                // fulscren.image.sprite = fulscrn_images[1];
                MMButton.gameObject.GetComponentInChildren<Text>().text = "Maximize";
                //bgconvertor.texture = bgtexs[1];
                scrollGO.SetActive(true);
                for (int v = 0; v < fulscrn_helpr.Length; v++)
                {
                    fulscrn_helpr[v].SetActive(false);
                }
            }



        }


        public void JumptoVideoPosition(int stepNumber)
	{
		videoPlayer.time = stepTimings[stepNumber];
            buttonText[0].text = buttonDesc[stepNumber];
            buttonText[1].text = buttonDesc[stepNumber];
            //Play Video
            videoPlayer.Play ();

		//Play Sound
		audioSource.Play ();

		StartCoroutine (ResumeVideo());
		if ((i % 2) == 1) {
			PlayPause ();
		}
	}
		

	public void PlayPause()
	{
		i++;
		if((i%2) == 1)
		{
			PauseVideo ();
		}
		else
		{
			ContinueVideo ();
		}

	}

	public void PauseVideo()
	{
            //pauseButton.image.sprite = pauseButtonImages [1];
            pauseButton.gameObject.GetComponentInChildren<Text>().text = "Play";
            videoPlayer.Pause();
		audioSource.Pause();

	}

	
	public void ContinueVideo()
	{
            //pauseButton.image.sprite = pauseButtonImages [0];
            pauseButton.gameObject.GetComponentInChildren<Text>().text = "Pause";
		videoPlayer.Play();
		audioSource.Play();
		StartCoroutine (ResumeVideo());

	}
	IEnumerator ResumeVideo()
	{
		Debug.LogWarning ("Resume");

		while (videoPlayer.isPlaying) {

             //   SEEKFunctionality(Mathf.FloorToInt((float)(videoPlayer.frameCount / videoPlayer.frameRate)));
               // timer = Mathf.FloorToInt((float)videoPlayer.time);
             //  SeekVideo((float)videoPlayer.time);
                timer = Mathf.FloorToInt ((float)videoPlayer.time);
			Debug.LogWarning ("Video Time: " + Mathf.FloorToInt ((float)videoPlayer.time));

			for (int i = 0; i < stepTimings.Length-1; i++) {
				if (timer >= stepTimings [i] && timer < stepTimings [i + 1]) {
					stepsButtons [i].image.color = Color.green;
					buttonText[0].text = buttonDesc [i];
                        buttonText[1].text = buttonDesc[i];
                    }
                    else
                    {
                        //if (stepsButtons[16] || stepsButtons[22] || stepsButtons[31])//|| stepsButtons[34])//|| stepsButtons[19] || stepsButtons[28] || stepsButtons[36])
                        {
                            //float g = 186f / 255f;
                            //stepsButtons[i].image.color = new Color(1f, g, 0f, 1f);
                            //stepsButtons[16].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[22].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[7].image.color = new Color(.584f, .8867f, .6308f);
                            //stepsButtons[31].image.color = new Color(.8f, .8f, .8f);
                            // stepsButtons[34].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[19].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[28].image.color = new Color(.8f, .8f, .8f);
                            //stepsButtons[36].image.color = new Color(.8f, .8f, .8f);
                        }
                        stepsButtons[i].image.color = Color.white;
                    }



                }
                yield return null;
		}
	}

        public void SEEKFunctionality(int max)
        {

            seekBar.maxValue = max;
            // seekBar[1].maxValue = max;

        }
        public void SeekVideo(float elpsed)

        {
            seekBar.value = elpsed;
            // seekBar[1].value = elpsed;

        }

        public void Seek(float nTime)
        {
            //if (!videoPlayer.canSetTime) return;
            //if (!videoPlayer.isPrepared) return;
            nTime = Mathf.Clamp(nTime, 0, 1116);
            // print("x:" + nTime);
            videoPlayer.time = nTime * Mathf.FloorToInt((float)(videoPlayer.frameCount / videoPlayer.frameRate));
            // print("y:" + nTime);
            print("aaaa:" + videoPlayer.time);
           
        }
      

        public void StopVideo()
	{
		videoPlayer.Stop ();
		audioSource.Stop ();
	}

	public void PauseVideoPlayer()
	{
		videoPlayer.Pause();
		audioSource.Pause();
	}

	public void PlayVideoPlayer()
	{
		videoPlayer.Play();
		audioSource.Play();
	}
        //public VideoPlayer video;
        //public Slider seek;
        //bool slde = false;


        //public void OnPointerDown(PointerEventData eventData)
        //{

        //    hovering = true;
        //}
        //public void OnPointerUp(PointerEventData eventData)
        //{
        //    bar.value = pos;
        //    // bar[1].value = pos;
        //    pos = (float)Style1VideoPlay.videoPlayer.frame / (float)Style1VideoPlay.videoPlayer.frameCount;
        //    // pos = Input.mousePosition.x / Screen.width;
        //    video.Seek(pos);
        //    hovering = false;
        //}

        //    // Start is called before the first frame update
        //    void Start()
        //{
        //    // seek = GetComponent<Slider>();
        //}

        ////// Update is called once per frame
        //void Update()
        //{
        //    if (!hovering && Style1VideoPlay.videoPlayer.isPlaying)
        //    {
        //        bar.value = (float)Style1VideoPlay.videoPlayer.frame / (float)Style1VideoPlay.videoPlayer.frameCount;
        //    }
        //}

        public void CloseApp()
		{

            SceneManager.LoadScene("Menu");
            //if (GetTagVal.name == "A")
            //{
            //    SceneManager.LoadScene("Selection_Menu 1");
            //}
            //if (GetTagVal.name == "B")
            //{
            //    SceneManager.LoadScene("Selection_Menu 2");
            //}
            //Application.Quit (); 
		}
      
        public void OnPointerDown(PointerEventData eventData)
        {
            float frame = (float)seekBar.value * (float)videoPlayer.frameCount;
            videoPlayer.frame = (long)frame;
           slde = true;

           // img.SetActive(false);
            throw new System.NotImplementedException();
           
        }

        


        public void OnPointerUp(PointerEventData eventData)
        {
           // StartCoroutine(assssaa());

            //  print("s v2 :" + seek.value);
            float frame = (float)seekBar.value * (float)videoPlayer.frameCount;
            videoPlayer.frame = (long)frame;
            //  seek.value = a;
            //  a = (float)video.frame / (float)video.frameCount;
            slde = false;

           
            throw new System.NotImplementedException();
        }
        IEnumerator assssaa()
        {
            yield return new WaitForSeconds(.7f);

            img.SetActive(true);
        }

        public void OnDrag(PointerEventData eventData)
        {

            throw new NotImplementedException();
        }
    }
}
