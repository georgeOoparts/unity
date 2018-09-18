using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kansu : MonoBehaviour {
    //スクリーンポジションからワールドポジションに変換するプログラム
    //空のオブジェにでも入れて、外のオブジェから使う。
    
    public Vector3 worldPosition(Vector3 s) {
        s.z =10f;
        s= Camera.main.ScreenToWorldPoint(s);
        return (s);
    }
}
