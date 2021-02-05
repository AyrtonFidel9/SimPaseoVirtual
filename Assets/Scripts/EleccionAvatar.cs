using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleccionAvatar : MonoBehaviour
{
    public static EleccionAvatar Eleavatar;
    public int avatar; //0 - Hombre y 1 - Mujer
    public GameObject hombre;
    public GameObject mujer;
    void Awake()
    {
        if(Eleavatar == null)
        {
            Eleavatar = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Eleavatar != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cargarAvatar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void eleccionMiAvatar (string eleccion)
    {
        if (eleccion == "Hombre")
            avatar = 0;
        else if (eleccion == "Mujer")
            avatar = 1;
    }

    private void cargarAvatar()
    {
        if(avatar == 0)
        {
            Destroy(mujer);
        }
        else if(avatar == 1)
        {
            Destroy(hombre);
        }
    }

}
