﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//マウスの座標を表示するテキストをずらして常に画面に文字
//が移るようにするプログラム。テキストにセットする。
//一番左上のテキスト表示対応
public class textSlideLeftTop_org : MonoBehaviour {
    Text text;
    Vector3 screenToWorld;
    // Use this for initialization
    void Start () {
        text = this.gameObject.GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
        //text.rectTransform.position =new Vector2(text.preferredWidth / 2,0);
        //Camera.main.ScreenToWorldPoint(position)
        screenToWorld =
            new Vector3(text.preferredWidth/2, 
            Screen.height-text.preferredHeight / 2, 0);
        screenToWorld = Camera.main.ScreenToWorldPoint(screenToWorld);
        screenToWorld.z = 0;
        text.rectTransform.position = screenToWorld;

        //Debug.Log("textSlide" +Screen.width);
    }
}