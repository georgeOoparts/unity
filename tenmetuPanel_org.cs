using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tenmetuPanel_org : MonoBehaviour {
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();
    private float elapse;
    private bool mojiOnOff = true;
    public float interval = 0.35f;
    
    // Use this for initialization
    void Start() {
        stopwatch.Start();
    }
    // Update is called once per frame
    void Update() {
        elapse = (float)stopwatch.Elapsed.TotalSeconds;
        //Debug.Log(elapse);
        if (mojiOnOff == true) {
            if (elapse >= interval) {
                mojiOnOff = false;
                this.gameObject.GetComponent<Image>().enabled=false;
                stopwatch.Reset();
                stopwatch.Start();
            }
        } else if (elapse >= interval) {
            mojiOnOff = true;
            this.gameObject.GetComponent<Image>().enabled = true;
            stopwatch.Reset();
            stopwatch.Start();
        }
    }
}