using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MoverElevador : MonoBehaviour
{
    public Animator anim;
    public KeyCode uno, dos, tres;
    private bool Activar_puertas = false;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(uno))
        {
            //(pos.position.y == 20.51056 || pos.position.y == 32.48465)
            Debug.Log("Aqui reconoce la tecla uno z=" + pos.position.z + " y="+ pos.position.y + " x="+pos.position.x);
            anim.SetTrigger("uno");
        }

        if (Input.GetKeyDown(dos))
        {
            //(pos.position.y == 8.536469 || pos.position.y == 32.48465)
            Debug.Log("Aqui reconoce la tecla dos z=" + pos.position.z + " y=" + pos.position.y + " x=" + pos.position.x);
            anim.SetTrigger("dos");
        }

        if (Input.GetKeyDown(tres))
        {
            //(pos.position.y == 20.51056 || pos.position.y == 8.536469)
            Debug.Log("Aqui reconoce la tecla tres z=" + pos.position.z + " y=" + pos.position.y + " x=" + pos.position.x);
            anim.SetTrigger("tres");
        }
    }

    /// <summary>
    /// Hay que resisar los parametros 
    /// </summary>
    /// <param name="externo"></param>
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

