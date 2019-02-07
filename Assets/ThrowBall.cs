using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {

    public GameObject ballObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 2.0f;
            Vector3 ballPos = Camera.current.ScreenToWorldPoint(mousePos);
            Instantiate(ballObj, ballPos, Quaternion.identity);
        }
	}
}
