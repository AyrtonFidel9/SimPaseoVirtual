using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivadorRetoGradas : MonoBehaviour
{
    public GameObject panel;
    public GameObject boton;
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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            try
            {
                Time.timeScale = 0.0f;
                panel.SetActive(true);
                boton.SetActive(true);
                audioSource.PlayOneShot(clip, volume);
            }
            catch 
            {
                
            }
            
        }
    }
    public void reanudar()
    {
        Time.timeScale = 1.0f;
    }
    
}
