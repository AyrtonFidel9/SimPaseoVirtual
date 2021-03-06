﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPapel : MonoBehaviour
{
    public AudioClip bien; //sonido cuando falla
    public AudioClip mal; //sonido cuando acierta
    public float volume = 0.5f;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider col)//metodo para detectar al objeto
    {

        if (col.gameObject.tag == "bPapel")
        {
            try
            {
                audioSource.PlayOneShot(bien, volume);
                PickUpObject.TirarB();//aqui estaba mverpersonaje
                Destroy(col.transform.GetChild(0).gameObject);// elimina los objets de la zona de interaccion 
                                                              // al momento que se dirige en nuestro caso a los basureros 
                Contarbasura.TotalB--;//el total de la basura disminuye cada vez que toma contacto con los basureros 
            }
            catch
            {

            }

        }
        else if(col.gameObject.tag == "bOrganico" || col.gameObject.tag == "bPlastico")
        {
            Timer.m--;
            audioSource.PlayOneShot(mal, volume); 
        }
    }
}
