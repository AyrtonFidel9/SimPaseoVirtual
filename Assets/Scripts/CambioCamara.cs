using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioCamara : MonoBehaviour
{
    // Start is called before the first frame update
    bool swCambio = false;
    public Camera praPersona;
    public Camera terPersona;

    public Canvas pantallaJuego;
    public Canvas pantallaTutorial;
    void Start()
    {
        terPersona.enabled = false;
        praPersona.enabled = true;
        pantallaJuego.renderMode = RenderMode.ScreenSpaceCamera;
        pantallaJuego.worldCamera = praPersona;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (swCambio)
            {
                terPersona.enabled = true;
                praPersona.enabled = false;
                pantallaJuego.worldCamera = terPersona;
                swCambio = false;
            }
            else
            {
                terPersona.enabled = false;
                praPersona.enabled = true;
                pantallaJuego.worldCamera = praPersona;
                swCambio = true;
            }

        }
    }
}
