using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMisionLab : MonoBehaviour
{
    public GameObject mensaje;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    public GameObject mision;

    public GameObject misionDos;

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
                mensaje.SetActive(true);
                audioSource.PlayOneShot(clip, volume);
                LogicaMisionLab.autoridad = "TICS";
                mision.SetActive(true);
                misionDos.SetActive(false);
            }
            catch
            {

            }

        }
    }

}
