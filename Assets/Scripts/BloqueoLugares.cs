using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoLugares : MonoBehaviour
{
    public GameObject mensaje;
    public AudioSource audioSource;
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
            mensaje.SetActive(true);
            audioSource.Play();
            Time.timeScale = 0.0f;
        }
    }
    public void reanudar()
    {
        Time.timeScale = 1.0f;
    }
}
