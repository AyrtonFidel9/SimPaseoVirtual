using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionesGradas : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Timer.m--;
            audioSource.PlayOneShot(clip, volume);
        }
    }
}
