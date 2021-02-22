using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SistemaPuntuacion : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Puntuacion;
    public static int puntuacion = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualizarPuntaje();
    }
    public void actualizarPuntaje()
    {
        Puntuacion.text = puntuacion + "/30";
    }
}
