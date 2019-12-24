using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class test : MonoBehaviour
{
    internal string text;
    string[] files;
    string pathPreFix;
    string path = Application.streamingAssetsPath + "/mytextfolder";
    //string ppe = "/PPE";
    //string docu = "/Documents";
    //string tools = "/Tools";
    //string comp = "/Components";
    //DirectoryInfo[] info;
    //string path = @"/Users/apple/Desktop/DWI_test";// home path
    String[] spearator = { "| ", "|" };
    int count = 4;
    string[] question;
    string txt = "what is this?! a>#a b>b c>c d>d ans:a |what is unity?! a>a b>b c> d>d ans:a ";
    string[] split;
    string[] OptionA;
    string[] OptionB;
    string[] OptionC;
    string[] OptionD;
    string[] ANS;

    List<string[]> questions;

    void Start()
    {
        //print(System.IO.Directory.GetCurrentDirectory());
        //print("subfolders:");
        ////Change this to change pictures folder
        //pathPreFix = @"file://";
        ////DirectoryInfo dir = new DirectoryInfo(path);

        //string s;
        //int top;
        //string pathTemp;
        //WWW www;
        //Texture2D texTmp;
        ////if (gameObject.tag == "ppe")
        ////{
        //s = path;
        //    files = Directory.GetFiles(s, "*.txt");
        //print("files name :" + files[0]);
        //print("files list :" + files.Length);

        ////String[] strlist = text.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);
        //question = files[0].Split(" "[0]);
        //print(question);
        //String[] spearator = { "s, ", "For" };
        //Int32 count = 2;

        //StreamReader inp_stm = new StreamReader(files[0]);

        //while (!inp_stm.EndOfStream)
        //{
        //    string inp_ln = inp_stm.ReadLine();
        //    // Do Something with the input. 
        //}

        //inp_stm.Close();



        //StreamReader reader = new StreamReader(files[0]);
        //Debug.Log(reader.ReadToEnd());
        //reader.Close();


        split = txt.Split('|');
        foreach (string item in split)
        {
            print(item + "\n");
        }
        //split = files.ToString().Split('|');
        //foreach (string item in files)
        //{
        //    print(item + "\n");
        //}
        for(int q=0;q<split.Length; q++)
        {
            //split = txt.Split('|');
            //question = split[q].Split('?');
            split_fun(questions, split[q],'!');
        }


    }
    public void split_fun(List<string[]> listArr,string singleStr,char ch)
    {
        listArr.Add(singleStr.Split(ch));
        for(int j =0;j<listArr.Count;j++)
        {
            print(listArr[j] + " \n");
        }
    }

}
