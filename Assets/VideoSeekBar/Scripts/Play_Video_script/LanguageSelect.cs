using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LanguageSelect : MonoBehaviour {

	public static string langugeIs = "ENGLISH";
	public Image[] btnimags;
	public Sprite[] Tamilsprite;
	public Sprite[] engsprite;
	public void btnSelected()
	{
		print ("selected - " + gameObject.tag);
        langugeIs = gameObject.tag;

		if (gameObject.tag == "ENGLISH") 
		{
			btnimags [0].sprite = Tamilsprite [0];
			btnimags [1].sprite = engsprite [1];
		}
		if (gameObject.tag == "TAMIL") 
		{
			btnimags [0].sprite = Tamilsprite [1];
			btnimags [1].sprite = engsprite [0];
		}
	}
}
