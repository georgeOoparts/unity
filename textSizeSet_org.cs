using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textSizeSet_org : MonoBehaviour {

    Text text;
    //Text textPanel;

    //GameObject oyaPanel;
    //RectTransform oyaRt;
    //public float widthPlus = 10;
    void Start() {
        //このオブジェの親　パネルのオブジェクトを取得
        //oyaPanel = this.gameObject.transform.parent.gameObject;
        //oyaRt=oyaPanel.GetComponent<RectTransform>();

        //preferredWidth,preferredHeightを使うため,textAtai
        //textAtai = this.gameObject.GetComponent<Text>();
        //この文字のサイズを手に入れる。
        text = this.gameObject.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update() {
        //textオブジェクトのサイズを文字に会わせる 
        text.rectTransform.sizeDelta
            = new Vector2(text.preferredWidth, text.preferredHeight);
        ////panelのサイズを文字に会わせる
        //if (text.preferredWidth != 0) {
        //   oyaRt.sizeDelta
        //        = new Vector2(text.preferredWidth +
        //        widthPlus, text.preferredHeight + widthPlus);
        //} else {
        //    oyaRt.sizeDelta = new Vector2(0,0);
        //}
    }
}
