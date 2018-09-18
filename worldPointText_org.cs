using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worldPointText_org : MonoBehaviour {
    private Vector3 position;
    private Vector3 screenToWorldPosition;
    Text text;
	// Use this for initialization
	void Start () {
        text = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        position = Input.mousePosition;
        position.z = 10f;
        screenToWorldPosition
            = Camera.main.ScreenToWorldPoint(position);
        //position = newTest.worldPosition(position);
        text.text ="world ::"+screenToWorldPosition.ToString();

    }
}
