using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//テキストを子にもつ、textPanelのサイズを　子のＴＥＸＴにばっちり合わせる。
//このオブジェのアンカーをストレッチにするとうまく動かない。
public class textPanelSizeSet_org: MonoBehaviour {
    Text kodomoText;
    RectTransform Rt;
    GameObject kodomoObj;
    public float yohaku=10;
	// Use this for initialization
	void Start () {
        kodomoObj = this.gameObject.transform.GetChild(0).gameObject;
        kodomoText = kodomoObj.GetComponent<Text>();
        Rt = this.gameObject.GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update () {
        //アンカーがストレッチ以外ならスクリーン座標の値でパネルの幅、高さを
        //指定できる。
        Rt.sizeDelta
            = new Vector2(kodomoText.preferredWidth + yohaku
            , kodomoText.preferredHeight + yohaku);
        //Debug.Log("textPanelSizeSize_org:::"+kodomoText.preferredWidth);
    }
}
