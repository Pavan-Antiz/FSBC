using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoTransition : MonoBehaviour {

	public GUITexture display;
	public GUITexture displaybg;
	public GUITexture far;
	public GUITexture bac;
	public GUITexture clo;
	public GameObject videoObject;

	public string[] movieName;
	int videoNumber;

	private VideoPlayer videoPlayer;
	private VideoSource videoSource;

	private AudioSource audioSource;
	public GameObject videoMenu;

	public static int m = 2;
	public void PlayVideo()
	{
		videoNumber = -1;
		Application.runInBackground = true;
		display.enabled = true;
		displaybg.enabled = true;
		far.enabled = false;
		bac.enabled = false;
		clo.enabled = true;
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

		//videoPlayer.source = VideoSource.VideoClip;

		// Vide clip from Url
		videoPlayer.source = VideoSource.Url;
		videoPlayer.url = Application.streamingAssetsPath + "/" + movieName[videoNumber]+".mp4";


		//Set Audio Output to AudioSource
		videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

		//Assign the Audio from Video to AudioSource to be played
		videoPlayer.EnableAudioTrack(0, true);
		videoPlayer.SetTargetAudioSource(0, audioSource);
		videoPlayer.controlledAudioTrackCount = 1;
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

		if ((videoNumber >= 0 && videoNumber < 3)) {
			CallVideo ();
			Debug.Log ("1");
		} 
	}

	public void CloseVideo () 
	{
		
		audioSource.Pause ();
		videoPlayer.Pause ();
		audioSource.Stop();
		videoPlayer.Stop();

		Destroy (videoPlayer);
		Destroy (audioSource);
		StopCoroutine (playVideo ());
		videoObject.SetActive (false);
		videoMenu.SetActive (false);
		m = 2;
	}
}
