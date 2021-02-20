using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoLugares : MonoBehaviour
{
    public GameObject mensaje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mensaje.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void reanudar()
    {
        Time.timeScale = 1.0f;
    }
}
