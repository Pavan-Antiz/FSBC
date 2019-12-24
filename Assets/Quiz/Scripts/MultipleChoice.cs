using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using System;
using System.Net;
using UnityEngine.SceneManagement;


public class MultipleChoice : MonoBehaviour {
    //public PlayCampVideo playCampVideo;

	public Toggle[] choicesToggle;
	public GameObject AssessmentObject;
	public static string button;
	public static int strTag;
	public static int clickCount;


	public static int attempt;
	public Texture RedCube;
	public Texture GreenCube;

	//public RawImage SideImage;
	public Button questionText;

	//public RawImage[] cubes;
	public RawImage resultImage;

	public static int RedCount;
	public static int GreenCount;

	public static int qNo;

	public static bool disable = false;

	public GameObject trnsImage;

	public static int ScoreValue = 0;

	public static List<int> arr = new List<int>();

	public Text scoreText;
	public static float[] Y = {85.0f,25.0f,-45.0f,-105.0f};
	public static List<int> arrayOptions = new List<int>();

	public GameObject result;


	public Text TimerText;
	public float timer = 0.0f;
	public float timerMax = 00.0f;
	public static bool startQuiz;

	//string batchId = "";
    public Button submitButton;

    //public GameObject instruct;
    public GameObject quiz, qObject;
    public Image finish;
    //public Text dateText;
    //public Text timeText;
	//public Sprite spr;

	void OnEnable()
	{
        //instruct.SetActive(true);
        //quiz.SetActive(false);
        ///MADHU
        /// 
        Proceed();
        //
        //dateText.text = System.DateTime.Now.ToString("dd-MM-yyyy");
        //timeText.text = System.DateTime.Now.ToString("hh:mm");
        //StartCoroutine(CheckData());
       
		disableComponents();




        // code here for multiple questions
        //switch(GetTagVal.name) // uncomment this to change quiz for diff button
        switch (startQuiz.Equals(true))
        {
            //case "A":
            case true:
                assignMistubshiQuestionPad(MCQuestions.Question1, MCQuestions.Choices11, MCQuestions.Choices12, MCQuestions.Choices13, MCQuestions.Choices14, MCQuestions.Answers1);
                break;
        }

        for (int j = 0; j < MCQuestions.Answers.Length; j++)
        {
            arr.Add(j);
        }
        RandomizeArray(arr);

        //Initail Options and Questions Arrays
        for (int j = 0; j < Y.Length; j++)
        {
            arrayOptions.Add(j);
        }


    } 
    void assignMistubshiQuestionPad(string[] q, string[] c1, string[] c2, string[] c3, string[] c4, string[] ans)
    {
        MCQuestions.Question = new string[q.Length];
        MCQuestions.Choices1 = new string[c1.Length];
        MCQuestions.Choices2 = new string[c2.Length];
        MCQuestions.Choices3 = new string[c3.Length];
        MCQuestions.Choices4 = new string[c4.Length];
        MCQuestions.Answers = new string[ans.Length];

        MCQuestions.Question = q;
        MCQuestions.Choices1 = c1;
        MCQuestions.Choices2 = c2;
        MCQuestions.Choices3 = c3;
        MCQuestions.Choices4 = c4;
        MCQuestions.Answers = ans;
    }
	//IEnumerator CheckData()
	//{
		////string newpath = "http://www.antiz-digital.com/TitanSafety/getbatchid.php?" + "uId=" + LoginAunthenticate.uid;//antiz ip
		//string newpath = "http://172.25.6.119/TitanSafety/getbatchid.php?" + "uId=" + LoginAunthenticate.uid;

		// var http = (HttpWebRequest)WebRequest.Create(newpath);
  //      var response = http.GetResponse();

  //      var stream = response.GetResponseStream();
  //      var sr = new StreamReader(stream);
  //      var content = sr.ReadToEnd();
       
		// yield return content;
		//    Debug.Log(content);
		//if (content == null)
		//{
		//	batchId = content;
		//}

    //    Debug.Log(batchId);
      

    //}

	void RandomizeArray(List<int> arr)
	{
		for (int i = 0; i < MCQuestions.Answers.Length; i++) 
		{
			var r = UnityEngine.Random.Range(0,i);
			var tmp = arr[i];
			arr[i] = arr[r];
			arr[r] = tmp;
		}
		print("ndid"+arr);
		attempt = 3;

	}


	// Randomize the options positions
	void RandomizeOptionsArray(List<int> arrayOptions)
	{
		//Debug
		for (int i = 0; i < Y.Length; i++) 
		{
			int r = UnityEngine.Random.Range(0,i);
			int tmp = arrayOptions[i];
			arrayOptions[i] = arrayOptions[r];
			arrayOptions[r] = tmp;
		}
		ShufflingOptions();
	}

	void ShufflingOptions()
	{
		for(var m = 0; m<4;m++)
		{
			//choicesToggle[m].transform.localPosition = new Vector3(choicesToggle[m].transform.localPosition.x,Y[arrayOptions[m]],choicesToggle[m].transform.localPosition.z);
		}
	}


	void Update ()
	{
		if(attempt == 3){
			attempt = 0;
			assignQuestion();
		}
		if((attempt == 2))
		{
			print("click");
			attempt = 0;
			clickCount = int.Parse(button);
			ButtonClick ();
		}

		if(disable == true)
		{
			disable = false;
			disableComponents();
		}

		if(startQuiz == true)
		{

			if(timer<0)
			{
				print("timer Zero reached !");
				timer = timerMax;
				startQuiz = false;
				MultipleChoiceCompletion();
			}
			else
			{
				timer-=Time.deltaTime;
				TimerText.text = timer.ToString ("F0").ToString () + " secs";
			}
		}

        //if()
        //{
        //    result.SetActive(true);
        //}

	}

	public void ClickButton(string value)
	{
		button = value;
		clickCount = int.Parse(value);
		ButtonClick ();
	}

	void assignQuestion()
	{
        foreach (Toggle tog in choicesToggle)
        {
            tog.isOn = false;
            Debug.Log("3");
        }
        Debug.Log("Repeat");

        InitiaPos();
		RandomizeOptionsArray(arrayOptions);
		enableComponents();
        // for true false question disabling the 3 and 4 options
        try
        {
            if (MCQuestions.Choices3[arr[qNo]] == "" && MCQuestions.Choices4[arr[qNo]] == "")
            {
                choicesToggle[2].gameObject.SetActive(false);
                choicesToggle[3].gameObject.SetActive(false);
            }
            else
            {
                choicesToggle[2].gameObject.SetActive(true);
                choicesToggle[3].gameObject.SetActive(true);
            }
        }
        catch(IndexOutOfRangeException e)
        {
            print("c= "+e.ToString());
        }

        // for 3 optional MCQ disable the 4 toogle button
        try
        {
            if (MCQuestions.Choices4[arr[qNo]] == "")
            {
                choicesToggle[3].gameObject.SetActive(false);
            }
            else
            {
                choicesToggle[3].gameObject.SetActive(true);
            }
       

        choicesToggle[0].GetComponentInChildren<Text>().text = MCQuestions.Choices1[arr[qNo]];
		choicesToggle[1].GetComponentInChildren<Text>().text = MCQuestions.Choices2[arr[qNo]];
		choicesToggle[2].GetComponentInChildren<Text>().text = MCQuestions.Choices3[arr[qNo]];
		choicesToggle[3].GetComponentInChildren<Text>().text = MCQuestions.Choices4[arr[qNo]];
		questionText.GetComponentInChildren<Text> ().text = MCQuestions.Question [arr [qNo]];

		scoreText.text = "Score : " + ScoreValue.ToString();
            //print(ScoreValue);
        }
        catch (IndexOutOfRangeException a)
        {
            print("a= "+a.ToString());
        }
    }


	IEnumerator RedColor()
	{
		yield return new WaitForSeconds(1.0f);
		trnsImage.SetActive(false);
		InitiaPos();
        Submitnext();
        print("Qnumber "+ qNo);

        // ++qNo;
        // if(qNo==24)//changing sprite image from next to submit in quiz
        // {
        // 	submitButton.image.sprite=spr;
        // }

        // if(qNo == 25)
        // { 
        // 	print("The result should be display");
        // 	MultipleChoiceCompletion();
        // }  
        // else
        // {
        // 	attempt = 3;
        // }
    }

	void InitiaPos()
	{
		resultImage.texture = null;
		resultImage.enabled = false;
	}

	void ButtonClick ()
	{
        //try
        //{
            trnsImage.SetActive(true);
            if (button == "1")
            {
                Choose(MCQuestions.Choices1[arr[qNo]]);
            }

            if (button == "2")
            {
                Choose(MCQuestions.Choices2[arr[qNo]]);
            }

            if (button == "3")
            {
                Choose(MCQuestions.Choices3[arr[qNo]]);
            }

            if (button == "4")
            {
                Choose(MCQuestions.Choices4[arr[qNo]]);
            }
        //}
        //catch(IndexOutOfRangeException b)
        //{
        //    print("b= " + b.ToString());
        //}

	}

    public void Submit()
    {
        if(choicesToggle[0].isOn)
        {
            ClickButton("1");
        }
        else if(choicesToggle[1].isOn)
        {
            ClickButton("2");
        }
        else if(choicesToggle[2].isOn)
        {
            ClickButton("3");
        }
        else if(choicesToggle[3].isOn)
        {
            ClickButton("4");
        }
        else
        {
            Debug.Log("Default selelcted");
        }
    }



	void Choose (string str1)
	{
		Debug.Log ("clickCount " + clickCount);
		resultImage.enabled = true;
		//cubes[clickCount-1].enabled = true;
		if(str1 == MCQuestions.Answers[arr[qNo]])
		{ 
			print("correct");
			resultImage.texture = GreenCube;
			//cubes[clickCount-1].texture = GreenCube;
			ScoreValue = ScoreValue + 10;
		}
		else
		{
			print("wrong");
			resultImage.texture = RedCube;
			//cubes[clickCount-1].texture = RedCube;
		}

		StartCoroutine(RedColor());
	}

		public void Submitnext()
		{
		InitiaPos();
		++qNo;
		if(qNo==29)
		{
			//submitButton.image.sprite=spr;//changing the sprite button from next to submit 
		}
        //if(qNo == 10)
        if(qNo == MCQuestions.Question.Length)

        {
            print("The result should be display");
			MultipleChoiceCompletion();
		}  
		else
		{
			attempt = 3;
		}

		}



    void MultipleChoiceCompletion()
    {
        //this void will call if the particular activity is completed with correct or wrong so update the user activity  in  db with correspont score and completion status and attempts...

        print(ScoreValue);
        qNo = 0;
        //if (LoginAunthenticate.uid != "")
        //{
        //    StartCoroutine(InsertScore(ScoreValue));
        //}
		ScoreValue = 0;
		//AssessmentObject.SetActive(false);

        //result.SetActive (true);
        //close the quiz
        //playCampVideo.jumpToSec();
        submitButton.gameObject.SetActive (false);
        startQuiz = false;
        scoreText.text = "Score : 0";
        qObject.SetActive(true);
        result.SetActive(true);

    }

	void disableComponents()
	{
		print("the disable is called");
		for(int zp = 0;zp<4;zp++){ 
			choicesToggle[zp].enabled = false;
			//cubes[zp].enabled = false;

		}
		resultImage.enabled = false;
		questionText.enabled = false;
	}


	void enableComponents()
	{
		questionText.enabled = true;
		for(int zpp = 0;zpp<4;zpp++){ 
			choicesToggle[zpp].enabled = true;

		}

	}

	//IEnumerator InsertScore(int score)
	//{
	//	string datetime = System.DateTime.Now.ToString("yyyy-MM-dd : hh-mm-ss");
	//	string date = System.DateTime.Now.ToString("yyyy-MM-dd");

	
	//	//string newpath = "http://www.antiz-digital.com/TitanSafety/insertscores.php?" + "batchNo=" + batchId +"&uId=" + LoginAunthenticate.uid + "&tdate=" + date + "&tdatetime=" + datetime + "&status=" + "Completed" + "&score=" + score;
 //   	string newpath = "http://172.25.6.119/TitanSafety/insertscores.php?" + "batchNo=" + batchId +"&uId=" + LoginAunthenticate.uid + "&tdate=" + date + "&tdatetime=" + datetime + "&status=" + "Completed" + "&score=" + score;
	
	//    var http = (HttpWebRequest)WebRequest.Create(newpath);
 //       var response = http.GetResponse();

 //       var stream = response.GetResponseStream();
 //       var sr = new StreamReader(stream);
 //       var content = sr.ReadToEnd();
       
	//	 yield return content;
	//	    Debug.Log(content);

	//	Debug.Log(content);
	//}

    public void AppQuit()
    {
        SceneManager.LoadScene("Selection_Menu");
        //Application.Quit();
    }

    public void Proceed()
    {
        //instruct.SetActive(false);
        quiz.SetActive(true);
        startQuiz = true;
    }

}
