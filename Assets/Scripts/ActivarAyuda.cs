using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAyuda : MonoBehaviour
{
    public void pausar()
    {
        Time.timeScale = 0.0f;
    }

    public void reanudar()
    {
        Time.timeScale = 1.0f;
    }
}
