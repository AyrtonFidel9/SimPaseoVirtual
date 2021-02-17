using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutos;
    public int segundos;
    public TMPro.TextMeshProUGUI txtTime;

    private int m,s;
    // Start is called before the first frame update

    public void iniciarTimer()
    {
        m = minutos;
        s = segundos;
        escribirTimer(m,s);   
        Invoke("actualizarTimer",1f);
        Debug.Log("El temporizador se inicio");
    }

    public void detenerTimer()
    {
        CancelInvoke();
    }

    public void actualizarTimer()
    {
        Debug.Log("Me estoy actualizando");
        s--;
        if(s < 0)
        {
            if(m == 0)
            {
                //programación para el fin del juego
            }
            else{
                m--;
                s = 59;
            }
        }
        escribirTimer(m,s);
        Invoke("actualizarTimer",1f);
    }

    private void escribirTimer(int m, int s)
    {
        if(s < 10)
        {
            txtTime.text = m.ToString() + ":0" + s.ToString();
        }
        else
        {
            txtTime.text = m.ToString() + ":" + s.ToString();
        }
    }
}
