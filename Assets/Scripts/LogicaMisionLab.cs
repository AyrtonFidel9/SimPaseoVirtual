using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicaMisionLab : MonoBehaviour
{
    //Declaración del nº de objetivos, el texto de la misión y el botón.
    public int numObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonMision;
    public string autoridad = "TICS";
   
    //Declaración para sonidos
    public AudioSource audioSource;
    public AudioClip clip; //sonido cuando falla
    public AudioClip clip2; //sonido cuando acierta
    public float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        numObjetivos = 6;
       // textoMision.text = "¡La misión ha comenzado!\nRecoge todas las fotos de las autoridades\n" + "Restantes:" + numObjetivos;
        //botonMision.SetActive(true);
        //textoMision.text = "\nRecoge la foto de la directora de la carrera de TICS";
    }

    // Update is called once per frame
    void Update()
    {
        if (numObjetivos == 6)
        {
            textoMision.text = "¡La misión ha comenzado!\nRecoge todas las fotos de las autoridades\n" + "Restantes:" + numObjetivos;
            textoMision.text += "\nComienza con la foto de la directora de la carrera de TICS";
            botonMision.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "Respawn")
        {
            switch (autoridad)
            {
                case "TICS":
                    if (col.gameObject.tag == "DirTics")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        textoMision.text = "Acertó, ahora recoja la foto del director de Telecomunicaciones\n" + "Restantes:" + numObjetivos;
                        autoridad = "TELE";
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la foto de la directora de TICS";
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                    }
                    break;
                case "TELE":
                    if (col.gameObject.tag == "DirTele")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        textoMision.text = "Ahora recoja la foto del director de Redes\n" + "Restantes:" + numObjetivos;
                        autoridad = "REDES";
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la foto del director de Telecomunicaciones";
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                    }
                    break;
                case "REDES":
                    if (col.gameObject.tag == "DirRedes")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        textoMision.text = "Correcto, ahora recoja la foto del decano de la facultad\n" + "Restantes:" + numObjetivos;
                        autoridad = "DECANO";
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la foto del director de Redes\n" + "Restantes:" + numObjetivos;
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                    }
                    break;
                case "DECANO":
                    if (col.gameObject.tag == "Decano")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        textoMision.text = "Muy bien,ahora recoja la foto del logotipo de la facultad\n" + "Restantes:" + numObjetivos;
                        autoridad = "LOGO";
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la foto del Decano de la facultad";
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                 
                    }
                    break;
                case "LOGO":
                    if (col.gameObject.tag == "FIE")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        textoMision.text = "Ya casi acabamos, ahora recoja la foto del director de Software\n" + "Restantes:" + numObjetivos;
                        autoridad = "SOFT";
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la foto del logotipo de la facultad";
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                    }
                    break;
                case "SOFT":
                    if (col.gameObject.tag == "DirSoft")
                    {
                        Destroy(col.transform.parent.gameObject);
                        numObjetivos--;
                        audioSource.PlayOneShot(clip2, volume);
                        if (numObjetivos == 0)
                        {
                            textoMision.text = "¡Fantástico, misión completada!";
                            SistemaPuntuacion.puntuacion += 10;
                            botonMision.SetActive(true);
                        }
                    }
                    else
                    {
                        textoMision.text = "Foto incorrecta, recoja la del director de Software";
                        audioSource.PlayOneShot(clip, volume);
                        Timer.m--;
                    }
                    break;

            }
        }
       


    }
}
