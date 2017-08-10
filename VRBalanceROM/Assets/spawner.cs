using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public float pacing = 1.0f;
    public GameObject ball;
    private float lastTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= lastTime + pacing)
        {
            Instantiate(ball, transform.position, Quaternion.identity);
            lastTime = Time.time;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
