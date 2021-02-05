using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float x;
    public float z;
    public float xMouse;
    public CharacterController player;
    public Animator animacion;
    public float velocidadMovimiento;
    public float gravedad = -9.81f;

    public Vector3 move;

    private Vector3 velocidad;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isGrounded)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");

            move = transform.right * x + transform.forward * z;
           
            animacion.SetFloat("VelX", x);
            animacion.SetFloat("VelY", z);
        }

        player.Move(move*Time.deltaTime*velocidadMovimiento);
        velocidad.y += gravedad * Time.deltaTime;
        player.Move(velocidad * Time.deltaTime);

    }

   


}
