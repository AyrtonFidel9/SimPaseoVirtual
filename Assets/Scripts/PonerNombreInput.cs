using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PonerNombreInput : MonoBehaviour
{
    public TMP_InputField valor;
    // Start is called before the first frame update
    void Start()
    {
        valor = GetComponent<TMP_InputField>();
        valor.text = ConservarNombre.user.nombre;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
