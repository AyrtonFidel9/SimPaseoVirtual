using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorMision : MonoBehaviour
{
    public GameObject mensaje;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            try
            {
                Time.timeScale = 0.0f;
                mensaje.SetActive(true);
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
    public void destruir(GameObject elem)
    {
        Destroy(elem);
    }
}
