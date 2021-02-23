using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaObjetivosBaños : MonoBehaviour
{

    public Contarbasura contB;

    void Start()
    {



    }


    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)//metodo para detectar al objeto
    {


        if (col.gameObject.tag == transform.gameObject.tag)
        {
            try
            {
                PickUpObject.TirarB();//aqui estaba mverpersonaje
                Destroy(col.transform.GetChild(0).gameObject);// elimina los objets de la zona de interaccion 
                                                              // al momento que se dirige en nuestro caso a los basureros 
                Contarbasura.TotalB--;//el total de la basura disminuye cada vez que toma contacto con los basureros 
            }
            catch
            {

            }

        }
        else
        {
            Debug.Log("Castigo");//mensjae de penalizacion 
        }
    }

}
