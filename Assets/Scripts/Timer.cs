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

    public static int m;
    public static int s;
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
        s--;
        if(s < 0)
        {
            if(m <= 0)
            {
                Debug.Log("Fin del juego");
                Time.timeScale = 0.0f;
                return;
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
