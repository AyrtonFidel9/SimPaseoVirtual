using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MensajePersonalizado : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Texto;
    public string finjuego;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(finjuego == "ganador")
        {
            Texto.text = "¡Felicidades "+ConservarNombre.user.nombre+"! Has completado el juego exitosamente. Puedes regresar y seguir recorriendo el edificio o regresar al menú principal";
        }
        else if(finjuego == "perdedor")
        {
            Texto.text = "¡Mala suerte "+ConservarNombre.user.nombre+"! el tiempo a terminado y no has podido cumplir el objetivo de matricularte, no te rindas ¡Vuelve a intentarlo!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarCancion()
    {
        audioSource.PlayOneShot(clip, volume);
    }

    public void pararCancion()
    {
        audioSource.Stop();
    }
}
