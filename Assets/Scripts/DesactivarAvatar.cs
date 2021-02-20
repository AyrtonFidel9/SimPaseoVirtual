using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesactivarAvatar : MonoBehaviour
{
    public GameObject avatar;
    // Start is called before the first frame update
    void Start()
    {
        desactivarCamara();
        //string escena = Application.loadedLevelName;
        ////Debug.Log(SceneManager.GetActiveScene().name);
        //if (escena == "Presentacion")
        //{
        //    avatar.SetActive(false);
        //}
        //else if (escena == "Inicio")
        //{
        //    avatar.SetActive(true);
        //}

        //Debug.Log("escena: "+escena);
    }

    // Update is called once per frame
    void Update()
    {
        desactivarCamara();
        //string escena = Application.loadedLevelName;
        //Debug.Log("escena: " + escena);
        ////Debug.Log(SceneManager.GetActiveScene().name);
        //if (escena == "Presentacion")
        //{
        //    avatar.SetActive(false);
        //}
        //else if (escena == "Inicio")
        //{
        //    avatar.SetActive(true);
        //}
    }   
    void desactivarCamara()
    {
        if (SceneManager.GetActiveScene().name == "Presentacion")
        {
            //desactivar pantallas del tutorial
            avatar.transform.GetChild(3).gameObject.SetActive(false);
            //desactivar pantallas para el juego
            avatar.transform.GetChild(4).gameObject.SetActive(false);
            avatar.transform.GetChild(5).gameObject.SetActive(false);

            avatar.transform.GetChild(1).gameObject.transform.GetChild(9).gameObject.SetActive(false);
            avatar.transform.GetChild(1).gameObject.transform.GetChild(10).gameObject.SetActive(false);
            avatar.transform.GetChild(2).gameObject.transform.GetChild(7).gameObject.SetActive(false);
            avatar.transform.GetChild(2).gameObject.transform.GetChild(8).gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Inicio")
        {
            avatar.transform.GetChild(1).gameObject.transform.GetChild(9).gameObject.SetActive(true);
            avatar.transform.GetChild(1).gameObject.transform.GetChild(10).gameObject.SetActive(true);
            avatar.transform.GetChild(2).gameObject.transform.GetChild(7).gameObject.SetActive(true);
            avatar.transform.GetChild(2).gameObject.transform.GetChild(8).gameObject.SetActive(true);

            //activar pantallas para el juego
            avatar.transform.GetChild(4).gameObject.SetActive(true);

            //activar colliders de las misiones
            avatar.transform.GetChild(5).gameObject.SetActive(true);
            //activar colliders de bloqueo
            avatar.transform.GetChild(6).gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Tutorial") {
            avatar.transform.GetChild(3).gameObject.SetActive(true);
        }
    }

}
    