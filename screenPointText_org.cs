using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenPointText_org: MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = this.gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text ="screen::"+Input.mousePosition.ToString();
	}
}
