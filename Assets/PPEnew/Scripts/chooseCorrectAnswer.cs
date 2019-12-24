using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class chooseCorrectAnswer : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler{

    public GameObject Listrand;
	public RandomizeIMages randImg;
	string spriteName;
	string spriteGreen;
	string spriteRed;
	bool flag;
	public static int count=-1; // to enable centre images
	public static int Lives =-1; // this is to be only by tool and workware scene

    void Awake()
    {
        randImg = Listrand.GetComponent<ListRI>().randomizeIs[ListRI.currNo];
    }

	void Start()
	{
		count=-1;
		Lives =-1;
	}
	public void OnPointerClick(PointerEventData pointerEventData)
	{
		spriteName = gameObject.GetComponent<Image> ().sprite.name;
		spriteGreen = spriteName + "Green";
		spriteRed = spriteName + "Red";
		print("spriteGreen - "+ spriteGreen+ "     spriteRed  -" + spriteRed);
		// check for correctAnswer
		foreach (string j in randImg.correctAnswer) {
			print (j +flag);
			if (j == spriteGreen) {
				flag = true;
				//print ("correct");
				// change imageColor to green
				for (int q = 0; q < randImg.ppeCorrectWrongSprites.Length; q++) {
					if (randImg.ppeCorrectWrongSprites [q].name == j) {
						gameObject.GetComponent<Image> ().sprite = randImg.ppeCorrectWrongSprites [q];
						//call to implement score for tools and work wear scene 
						//if (randImg.valueflag == 1)//value 1 at tools and work wear scene
							//ToolScorer.score += 10;

					}
				}
			}
		}
		if(flag)
		{
			//show avatarPPe and info
			//print ("correct");
			foreach (Image ig in randImg.avatarPPEs) {
				if (ig.sprite.name == spriteName) {
					ig.enabled = true;
				} 
			}
			foreach (Image igf in randImg.infoPPEs) {
				if (igf.sprite.name == spriteName) {
					igf.enabled = true;
				} 
			}
			count++;
			//print ("count -" + count);
			randImg.centreImages [count].enabled = true;
			if (count == (randImg.correctAnswer.Length-1)) {
//				randImg.initialImage.enabled = true;
//				randImg.initialImage.sprite = randImg.finialImage;

				StartCoroutine (nextScene ());
			}
		}
		// check for wrongAnswer
			if (!flag) { 
			print("enterd");
			for (int q = 0; q < randImg.ppeCorrectWrongSprites.Length; q++) {
				if (randImg.ppeCorrectWrongSprites [q].name == spriteRed) {
					//change ImageColor to red
					print ("enterd123" + randImg.ppeCorrectWrongSprites [q].name + "   " + spriteRed);
					gameObject.GetComponent<Image> ().sprite = randImg.ppeCorrectWrongSprites [q];

					if (randImg.valueflag == 1) //value 1 at tools and work wear scene to decrease the lives
						Lives++;

				}
				else
				{
					print ("enterd     " + randImg.ppeCorrectWrongSprites [q].name + "   " + spriteRed);
				}
			}
		}
	}

	//Do this when the cursor enters the rect area of this selectable UI object.
	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log("The cursor entered the selectable UI element.");
		spriteName = gameObject.GetComponent<Image> ().sprite.name;
		for (int h = 0; h < randImg.ppeImages.Length; h++) {
			if (spriteName == randImg.ppeImages [h].sprite.name) {
				randImg.TT.text = randImg.toolTips [h];
			}
		}
	}
	//Do this when the cursor exits the rect area of this selectable UI object.
	public void OnPointerExit(PointerEventData eventData)
	{
		Debug.Log("The cursor exited the selectable UI element.");
		randImg.TT.text = "";
	}

	IEnumerator nextScene(){
//		randImg.EntireGO.SetActive (false);
		yield return new WaitForSeconds (3f);
		randImg.initialImage.enabled = true;
		randImg.initialImage.sprite = randImg.finialImage;
        randImg.finalText.SetActive(true);
        yield return new WaitForSeconds (3f);
		if(randImg.valueflag ==0)
			SceneManager.LoadScene(randImg.sName);	
	}
}