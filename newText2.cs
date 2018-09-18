using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newText2 : MonoBehaviour {
    
    GameObject kObj;
    private Vector3 position;
    
    // Use this for initialization
    void Start () {
        kObj = GameObject.Find("control");
    }
	
	// Update is called once per frame
	void Update () {
        kansu kKansu =kObj.GetComponent<kansu>();
        position = Input.mousePosition;
        position = kKansu.worldPosition(position);

        Debug.Log(position);
	}
}
