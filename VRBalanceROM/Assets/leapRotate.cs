using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;


public class leapRotate : MonoBehaviour {
    public bool translation = false;
    LeapProvider provider;
	// Use this for initialization
	void Start () {
        provider = FindObjectOfType<LeapProvider>() as LeapProvider;
	}
	
	// Update is called once per frame
	void Update () {
        Frame frame = provider.CurrentFrame;

        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsRight) {
                Quaternion rotateX = transform.rotation;
                rotateX.z = hand.Basis.rotation.z;
                transform.rotation = rotateX;
            }
        }
	}
}
