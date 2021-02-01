using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called before the first frame update
    Space relativeTo; //variable para configurar el espacio de la camara
    public Transform[] targets; //variable para asignar los componentes a los cuales la camara girara alrededor de ellos
    int currentTarget = 0; //indice que servira para apuntar a un componente del vector asignado
    private Vector3 m_Position = new Vector3(0, 1.75f, 0);

    public float sensitivity = 10.0f; //sensibilidad del mouse
    Vector3 mouseDelta = Vector3.zero; //contiene los inputs de movimiento
    Vector3 amount = Vector3.zero; //

    Vector3 camPos = Vector3.zero;

    
    void Start()
    {
        relativeTo = Space.Self;
        amount.z = 100;
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            currentTarget = currentTarget + 1 >=
                targets.Length ? 0 : currentTarget + 1;

        }

        mouseDelta.Set(
            Input.GetAxisRaw("Mouse X"),
            Input.GetAxisRaw("Mouse Y"),
            Input.GetAxisRaw("Mouse ScrollWheel")
            );

        amount += mouseDelta * sensitivity;
        amount.z = Mathf.Clamp(amount.z, 50, 300);
        amount.y = Mathf.Clamp(amount.y, -89, 0);
        camPos =
            Quaternion.AngleAxis(amount.x, Vector3.up)
            * Quaternion.AngleAxis(amount.y, Vector3.right)
            * Vector3.forward;

        camPos *= amount.z * 0.1f;
        camPos += targets[currentTarget].transform.position;
        transform.position = camPos;
        transform.LookAt(targets[currentTarget].transform.position); //funcón para que la camara mire al 
    }
}
