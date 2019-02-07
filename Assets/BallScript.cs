using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0,0,speed*20);
        StartCoroutine(DestroyBall());
	}
	
    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}
