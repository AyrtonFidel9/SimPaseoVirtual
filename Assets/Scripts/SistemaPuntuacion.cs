using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SistemaPuntuacion : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Puntuacion;
    public static int puntuacion = 0;
    public static int retosCompletados = 0;

    public GameObject dialogoWaitSecre;
    public GameObject dialogoFinalizar;
    public static bool matriculado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualizarPuntaje();
        if(retosCompletados == 2)
        {
            try
            {
                matriculado = true;
                dialogoWaitSecre.SetActive(false);
                dialogoFinalizar.SetActive(true);    

            }
            catch 
            {
                
            }
            
            
        }
    }
    public void actualizarPuntaje()
    {
        Puntuacion.text = puntuacion + "/30";
    }
}
