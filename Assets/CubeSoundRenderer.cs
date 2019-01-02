using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CubeSoundRenderer : MonoBehaviour {

    GameObject ImageTarget;
    // Use this for initialization
    void Start () {
        ImageTarget = GameObject.Find("ImageTarget");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        ImageTarget.GetComponent<SoundPlayer>().PlaySound(GetComponentInParent<VirtualButtonBehaviour>().VirtualButtonName);
    }
}
