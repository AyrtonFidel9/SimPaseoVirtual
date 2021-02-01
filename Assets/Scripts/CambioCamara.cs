using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    // Start is called before the first frame update
    bool swCambio = false;
    public Camera praPersona;
    public Camera terPersona;
    void Start()
    {
        terPersona.enabled = false;
        praPersona.enabled = true;
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
                swCambio = false;
            }
            else
            {
                terPersona.enabled = false;
                praPersona.enabled = true;
                swCambio = true;
            }

        }
    }
}
