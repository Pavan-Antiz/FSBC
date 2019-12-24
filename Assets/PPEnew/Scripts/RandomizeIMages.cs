using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomizeIMages : MonoBehaviour {
	public Image initialImage;
	public Sprite initialSprite,finialImage;
	public GameObject EntireGO,finalText,avatarPPE;
	public Image[] ppeImages;
	public Sprite[] ppeSprites;
	public Sprite[] ppeCorrectWrongSprites;
	public Image[] avatarPPEs;
	public Image[] infoPPEs;
	public Image[] centreImages;
	public string[] toolTips;
	public Text TT; //tooltip
	public string[] correctAnswer; //add in inspector for more correct answer
	public string sName;
	public int valueflag;
    
	public void Start(){
       // EntireGO.SetActive(true);
        if (valueflag == 0) {   //value 0 at ppe scene
			StartCoroutine (initalDo ());
		}
		if (valueflag == 1) {  //value 1 at tools and work wear scene
			initialImage.enabled = false;
			EntireGO.SetActive (true);
		}
		for (int i = ppeSprites.Length - 1; i > 0; i--) {
			var r = Random.Range (0, i);
			Sprite temp = ppeSprites [i];
			ppeSprites [i] = ppeSprites [r];
			ppeSprites [r] = temp;

			Sprite m = ppeCorrectWrongSprites [i];
			ppeCorrectWrongSprites [i] = ppeCorrectWrongSprites [r];
			ppeCorrectWrongSprites [r] = m;

			string ju = toolTips [i];
			toolTips [i] = toolTips [r];
			toolTips [r] = ju;
		}
		for (int i = 0; i < ppeSprites.Length; i++){	
			ppeImages [i].sprite = ppeSprites[i];
		}
	}

	IEnumerator initalDo(){
		yield return new WaitForSeconds (0f);
		//initialImage.sprite = initialSprite;
		yield return new WaitForSeconds (0f);
		initialImage.enabled = false;
		EntireGO.SetActive (true);
	}
}