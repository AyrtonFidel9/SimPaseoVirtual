using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraPersona : MonoBehaviour
{
    public float velocidadMouse = 150f;
    public Transform personaje;
    float rotacionX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float valorX = Input.GetAxis("Mouse X") * velocidadMouse * Time.deltaTime;
        float valorY = Input.GetAxis("Mouse Y") * velocidadMouse * Time.deltaTime;

        rotacionX -= valorY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        personaje.Rotate(Vector3.up * valorX);
    }
}
