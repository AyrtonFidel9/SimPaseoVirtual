using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaAvatar : MonoBehaviour
{

    //Variables
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private float velocidadRotacionMouse;
    public Animator animacion;
    public float x, y, xMouse;
    bool swCambio = false;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        velocidadRotacionMouse = velocidadRotacion;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        xMouse = Input.GetAxis("Mouse X");
        transform.Translate(x * Time.deltaTime * velocidadMovimiento, 0, y * Time.deltaTime * velocidadMovimiento);
        transform.Rotate(0, xMouse * velocidadRotacionMouse * Time.deltaTime, 0);
        animacion.SetFloat("VelX",x);
        animacion.SetFloat("VelY",y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NPCgradas")
        {
            Debug.Log("Choco con un NPC de las gradas");
        }
    }
}
