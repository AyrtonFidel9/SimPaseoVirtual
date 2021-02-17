using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public TMPro.TextMeshProUGUI txtTime;
    public float hora;
    public float minutos;
    float msToWait;
    public bool isFin = false;
    public string retencionName;
    public ulong inicioTimer;
    float segundosRestantes = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake() {
        
    }

    // Update is called once per frame
    void Update()
    {
        temporizador();
    }

    public void iniciarTemporizador()
    {
        ConvertirTimetoMS();
        inicioTimer = (ulong)DateTime.Now.Ticks;
       // PlayerPrefs.SetString(retencionName, inicioTimer.ToString());
        isFin = false;
    }

    void ConvertirTimetoMS()
    {
        float aux = (hora * 60.0f) + minutos;
        msToWait = aux * 60000.0f;
    }

    void temporizador()
    {
        if(!isFin)
        {
            segundosRestantes = saberTotalSegundos();
            if(TimerFinalizado())
            {
                txtTime.text = "FIN";
                return;
            }

            string auxTimer = "";
            auxTimer += ((int)segundosRestantes/3600).ToString()+":";

            auxTimer += ((int)segundosRestantes/60).ToString("00")+":";

            auxTimer += (segundosRestantes % 60).ToString("00");

            txtTime.text = auxTimer;

        }
    }

    float saberTotalSegundos()
    {
        ulong diff = (ulong)DateTime.Now.Ticks - inicioTimer;
        ulong aux = diff / TimeSpan.TicksPerMillisecond;

        return (float)(msToWait - aux)/1000.0f;
    }

    public bool TimerFinalizado()
    {
        if(segundosRestantes < 0)
        {
            isFin = true;
            return true;
        }

        return false;
    }



}
