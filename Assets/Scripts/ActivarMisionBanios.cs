using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMisionBanios : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mensaje;
    public GameObject activador;
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
                mision.SetActive(true);
                misionDos.SetActive(false);
                activador.SetActive(false);
            }
            catch
            {

            }

        }
    }

    public void activarMisionLab()
    {
        misionDos.SetActive(true);
    }
}
