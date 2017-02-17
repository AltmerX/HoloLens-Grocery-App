using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    private static Vector3 ImageRotation = new Vector3(90, 0, 0);
    private Camera cam = Camera.main;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(ImageRotation);
      //  transform.localScale = new Vector3(cam.aspect * cam.orthographicSize,cam.orthographicSize,1);

    }
}
