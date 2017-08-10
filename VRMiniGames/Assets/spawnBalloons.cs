using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBalloons : MonoBehaviour {
    public GameObject balloon;
    public float pacing = 0.2f;
    private float lastTime = 0;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Time.time >= lastTime + pacing) {
            float offset = 0;
            offset = Random.Range(-2, 2);
            Vector3 off = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
            Instantiate(balloon, off, Quaternion.identity);
            lastTime = Time.time;
        }

	}
}
