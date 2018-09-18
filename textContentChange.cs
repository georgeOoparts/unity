using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textContentChange : MonoBehaviour {
    GameObject t1;
    GameObject t2;
    GameObject t3;
    GameObject t4;
    GameObject t5;
    GameObject t6;
    GameObject t7;

    Text text1;
    Text text2;
    Text text3;
    Text text4;
    Text text5;
    Text text6;
    Text text7;

    int count = 1;
    // Use this for initialization
    void Start () {
        Debug.Log("reStart::");
        t1 = GameObject.Find("Text1");
        t2 = GameObject.Find("Text2");
        t3 = GameObject.Find("Text3");
        t4 = GameObject.Find("Text4");
        t5 = GameObject.Find("Text5");
        t6 = GameObject.Find("Text6");
        t7 = GameObject.Find("Text7");

        text1 = t1.GetComponent<Text>();
        text2 = t2.GetComponent<Text>();
        text3 = t3.GetComponent<Text>();
        text4 = t4.GetComponent<Text>();
        text5 = t5.GetComponent<Text>();
        text6 = t6.GetComponent<Text>();
        text7 = t7.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        text1.text = content(1, count);
        text2.text = content(2, count);
        text3.text = content(3, count);
        text4.text = content(4, count);
        text5.text = content(5, count);
        text6.text = content(6, count);
        text7.text = content(7, count);
        if (Input.GetMouseButtonDown(0)) count++;
	}
    string content(int i, int j) {
        string content = "";
        if (i == 1) {
            if (j == 1) content = "三角形";
            else if (j == 2) content = "点";
            else content = "";
        }else if (i==2) {
            if (j == 1) content = "ABC";
            else if (j == 2) content = "A";
            else if (j == 3) content = "垂線";
            else content = "";
        } else if (i == 3) {
            if (j == 1) content = "がある。";
            else if (j == 2) content = "から辺";
            else if (j == 3) content = "と辺";
            else content = "";
        } else if (i == 4) {
            if (j == 1) content = "";
            else if (j == 2) content = "BC";
            else if (j == 3) content = "BC";
            else content = "";
        } else if (i == 5) {
            if (j == 1) content = "";
            else if (j == 2) content = "に";
            else if (j == 3) content = "の交点を";
            else content = "";
        } else if (i == 6) {
            if (j == 1) content = "";
            else if (j == 2) content = "垂線";
            else if (j == 3) content = "Ｐ";
            else content = "";
        } else if (i == 7) {
            if (j == 1) content = "";
            else if (j == 2) content = "を引く";
            else if (j == 3) content = "と名づける";
            else content = "";
        }
        return (content);
    }
}
