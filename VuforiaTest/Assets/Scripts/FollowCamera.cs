using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    
    private static Vector3 textRotation=new Vector3(0,180,0);
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(textRotation);
    }
}
