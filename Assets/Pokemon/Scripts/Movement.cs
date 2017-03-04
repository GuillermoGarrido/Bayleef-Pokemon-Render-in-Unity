using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	Transform trans;

	void Start () {
		trans = GameObject.Find("BR_Bayleef").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)) {
			trans.Translate(Vector3.forward);
		}	
    //The if statements below do not currently function properly
		if(Input.GetKey(KeyCode.DownArrow)) { 
			trans.Translate(Vector3.back);
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			trans.Rotate(Vector3.up);
		}	

		if(Input.GetKey(KeyCode.RightArrow)) {
			trans.Rotate(Vector3.down);
		}	
	}
}
