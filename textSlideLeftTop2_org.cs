using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//マウスの座標を表示するテキストをずらして常に画面に文字
//が移るようにするプログラム。テキストにセットする。
//一番左上のテキスト表示対応
public class textSlideLeftTop2_org : MonoBehaviour {
    Text text;
    Text text2;
    Vector3 screenToWorld;
    //GameObject ueText;
    // Use this for initialization
    void Start () {
        text = this.gameObject.GetComponent<Text>();
        text2 =GameObject.Find("TextW").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        screenToWorld =
            new Vector3(text.preferredWidth/2, 
            Screen.height-text2.preferredHeight
            - text.preferredHeight / 2, 0);
        screenToWorld = Camera.main.ScreenToWorldPoint(screenToWorld);
        screenToWorld.z = 0;
        text.rectTransform.position = screenToWorld;
    }
}
