using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System;
using System.IO;


/// <summary>
/// Unity VideoPlayer Script for Unity 5.6 (currently in beta 0b11 as of March 15, 2017)
/// Blog URL: http://justcode.me/unity2d/how-to-play-videos-on-unity-using-new-videoplayer/
/// YouTube Video Link: https://www.youtube.com/watch?v=nGA3jMBDjHk
/// StackOverflow Disscussion: http://stackoverflow.com/questions/41144054/using-new-unity-videoplayer-and-videoclip-api-to-play-video/
/// Code Contiburation: StackOverflow - Programmer
/// </summary>

public class TransitionVideo : MonoBehaviour
{
    public RawImage display;
    public string[] movieName;
    int videoNumber;

    public VideoClip[] vid;

	//public GameObject starterPanel;
	//public VideoClip videoToPlay;

	private VideoPlayer videoPlayer;
	private VideoSource videoSource;

	private AudioSource audioSource;

	public GameObject InitialBG;
    int i;
    // bg for introduction video
	//public LoadingFullScreen loadFS;

	// Use this for initialization
	void Start () {
		
		//StartCoroutine(playVideo());
		PlayVideo();
	}
		
	public void PlayVideo()
	{
		videoNumber = -1;
		Application.runInBackground = true;
		StartCoroutine(playVideo());
	}

	void CallVideo () 
	{
		Application.runInBackground = true;
		StartCoroutine(playVideo());
	}


	IEnumerator playVideo()
	{

		videoNumber++;
		//Add VideoPlayer to the GameObject
		videoPlayer = gameObject.AddComponent<VideoPlayer>();

		//Add AudioSource
		audioSource = gameObject.AddComponent<AudioSource>();

		//Disable Play on Awake for both Video and Audio
		videoPlayer.playOnAwake = false;
		audioSource.playOnAwake = false;
		audioSource.Pause();

		//We want to play from video clip not from url

		videoPlayer.source = VideoSource.VideoClip;

        //Video clip from Url
       videoPlayer.source = VideoSource.Url;
        videoPlayer.url = Application.streamingAssetsPath + "/" + movieName[videoNumber] + ".mp4";


        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

		//Assign the Audio from Video to AudioSource to be played
		videoPlayer.EnableAudioTrack(0, true);
		videoPlayer.SetTargetAudioSource(0, audioSource);
		videoPlayer.controlledAudioTrackCount = 1;
		//Set video To Play then prepare Audio to prevent Buffering
        //for(videoNumber = 0; videoNumber <= 7; videoNumber++)
        //{
            videoPlayer.clip = vid[videoNumber];
   //     }
	
		//loadFS.OnMouseEnter();
		videoPlayer.Prepare();

		//Wait until video is prepared
		while (!videoPlayer.isPrepared)
		{
			yield return null;
		}
		//loadFS.OnMouseExit();
		Debug.Log("Done Preparing Video");

		//Assign the Texture from Video to RawImage to be displayed
		display.texture = videoPlayer.texture;

		//Play Video
		videoPlayer.Play();

		//Play Sound
		audioSource.Play();
	

		Debug.Log("Playing Video");
		while (videoPlayer.isPlaying)
		{
			//Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
			yield return null;
		}

		Debug.Log("Done Playing Video");
       LoadBaseScene();

  //      if ((videoNumber > 0 && videoNumber < 1) || (videoNumber > 0 && videoNumber < 6)) {
		//	CallVideo ();
  //         // print(" hiii video playing");
		//	Debug.Log ("1");
		//} 
		//else if (videoNumber == 0) 
		//{
		//	Debug.Log ("2");
		//	//starterPanel.SetActive (true);
		//	InitialBG.SetActive (false);
		//	if (audioSource.isPlaying) {
		//		videoPlayer.Stop ();
		//		audioSource.Stop ();
		//	}
		//} 
		//else if (videoNumber == 6) {
		//	Debug.Log ("3");
		//	LoadBaseScene ();
		//} 
		//else {
		//	Debug.Log ("4");
		//}
	}


	void LoadBaseScene()
	{
        SceneManager.LoadScene("Menu");
    }

	public void Continue()
	{
		//starterPanel.SetActive (false);
		//CallVideo ();
	}
	public void Later()
	{
		LoadBaseScene ();
	}
}
