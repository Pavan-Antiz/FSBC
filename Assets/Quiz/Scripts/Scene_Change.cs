using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {

	 GameObject gb;
	// Use this for initialization
	void Start () {
		
	}
	public void move(string ss)
	{
	SceneManager.LoadScene(ss);
	}

	public void move1(string sb)
	{
		
	gb= GameObject.FindWithTag("dis");
	print(" gameobject name "+gb.name+" tags id "+gb.tag);
	gb.SetActive(false);
	print("gameobject disabled");
	SceneManager.LoadScene(sb);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
