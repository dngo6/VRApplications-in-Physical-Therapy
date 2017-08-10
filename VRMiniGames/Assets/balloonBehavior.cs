using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonBehavior : MonoBehaviour {
    public float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 force = new Vector2(-speed, 0);
        Rigidbody2D bod = gameObject.GetComponent<Rigidbody2D>();
        bod.gravityScale = 0;
        bod.AddForce(force);
	}

}
