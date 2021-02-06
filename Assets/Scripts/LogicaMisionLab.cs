using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicaMisionLab : MonoBehaviour
{
    public int numObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonMision;

    // Start is called before the first frame update
    void Start()
    {
        numObjetivos = GameObject.FindGameObjectsWithTag("objetivolap").Length;
        textoMision.text = "Recoge los siguientes elementos: lápiz, mouse, laptop y los cuadros de las autoridades\n" + "Restantes:" + numObjetivos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="objetivolap")
        {
            Destroy(col.transform.parent.gameObject);
            numObjetivos--;
            textoMision.text = "Recoge los siguientes elementos: lápiz, mouse, laptop y los cuadros de las autoridades\n" + "Restantes:" + numObjetivos;
            if (numObjetivos<=0)
            {
                textoMision.text = "\nMisión completada";
                botonMision.SetActive(true);
            }
        }
    }
}
