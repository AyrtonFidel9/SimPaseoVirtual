using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;//variable de tipo publica y booleana para poder coger el objeto
    // Start is called before the first frame update

    //funcion que me oermite detectar el obejto la colision
    private void OnTriggerEnter(Collider other)//funcion que permite detectar al colaider para realizar la interaccion
    {
        if (other.tag == "PlayerInteractionZone")
        {//si la etiqueta del trigger en el que estamos colisonando es el player interaction zone
            //etiqueta de la zona de interaccion
            other.GetComponentInParent<PickUpObject>().ObjectToPickup = this.gameObject;//busca un componente en el padre y busca el script 
            //pickUpObject  y dentro del script busca la variable ObjectToPickup
        }
    }
    private void OnTriggerExit(Collider other)//funcion que sale de la zona de interaccion 
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickup = null;//cuadno se sale de 
            //la zona de interaccion ya no reconoce al objeto, elimina al objeto detectado
        }
    }
}
