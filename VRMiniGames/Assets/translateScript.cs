using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;

public class translateScript : MonoBehaviour
{
    LeapProvider provider;
    public float force = 20;
    public GameObject scoreKeep;
    // Use this for initialization
    void Start()
    {
        provider = FindObjectOfType<LeapProvider>() as LeapProvider;
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = provider.CurrentFrame;
        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsRight)
            {
                float factor = hand.GrabStrength * force;
                Vector2 forceF = new Vector2(0, factor);

                gameObject.GetComponent<Rigidbody2D>().AddForce(forceF);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            GameObject.Destroy(other.gameObject);
            scoreKeep.GetComponent<score>().points++;
        }
    }
}
