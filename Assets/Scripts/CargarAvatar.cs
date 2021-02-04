using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarAvatar : MonoBehaviour
{
    public GameObject hombre;
    public GameObject mujer;
    // Start is called before the first frame update
    void Start()
    {
        EleccionAvatar eleccion = new EleccionAvatar();
        cargarAvatar(eleccion.avatar);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void cargarAvatar(int avatar)
    {
        if (avatar == 0)
        {
            Destroy(mujer);
        }
        else if (avatar == 1)
        {
            Destroy(hombre);
        }
    }
}
