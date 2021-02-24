using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contarbasura : MonoBehaviour
{  
    int contador = 0;
    public int contarB;
    public static int TotalB = 6;//total de obejtos 
    public TextMeshProUGUI textoMision;//cambiar texto panel
    public GameObject botonMision;//se activa cuando cumpla los objetivos recogidos
    // Start is called before the first frame update
    public static Contarbasura contadordeBasura;
    void Start()
    {
        textoMision.text = "Recoge la basura y clasificala: manzana, limon, periódico, revista, botella agua, botella gatorade\n" + "Restantes:" + TotalB;
        //texto se que presenta al inicar la mision 
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarContador();
        if (TotalB <= 0)//si el total de la basura es menor que 0 
        {
            contador++;
            textoMision.text = "\nMisión completada";//mensaje de mision compleada
            botonMision.SetActive(true);//se activa cuando se recoge todos los objetos
            if(contador==1)
            {
                SistemaPuntuacion.puntuacion+=10;
                SistemaPuntuacion.retosCompletados++;
            }
                
        }
    }
    public void ActualizarContador()
    {
        textoMision.text = "Recoge la basura y clasificala: manzana, limon, periódico, revista, botella agua, botella gatorade\n" + "Restantes:" + TotalB;
        //actualiza el contador de objetos restantes
    }
}
