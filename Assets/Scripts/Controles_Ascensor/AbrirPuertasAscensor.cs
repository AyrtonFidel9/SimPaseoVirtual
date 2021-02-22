using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AbrirPuertasAscensor : MonoBehaviour
{
    public Animator anim;
    public KeyCode teclas;
    public bool Activar_puertas;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclas))
        {
            Debug.Log("Aqui reconoce la tecla " + Activar_puertas);
            anim.SetTrigger("abrir");
        }
    }

    private void OnTriggerEnter(Collider externo)
    {
        if (externo.gameObject.tag == "Player")
        {
            Debug.Log("Aqui reconoce al personaje");
            Activar_puertas = true;
        }
    }

    private void OnTriggerExit(Collider externo)
    {
        if (externo.gameObject.tag == "Player")
        {
            Activar_puertas = false;
        }
    }
}
