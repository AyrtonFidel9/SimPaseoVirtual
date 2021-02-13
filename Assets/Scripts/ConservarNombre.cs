using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConservarNombre : MonoBehaviour
{
    public TMP_InputField valor; 
    public static ConservarNombre user;
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        //valor = GetComponentInChildren<TMP_InputField>();
        //Debug.Log(transform.parent.gameObject.name);
        //canvas = GetComponentInParent<Canvas>();
        //recorrerCanvas();
    }

    void Awake ()
    {
        if (user == null)
        {
            user = this;
            DontDestroyOnLoad(gameObject);
        } else if(user != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //try
        //{
        //    if (nombre != valor.text)
        //    {
        //        nombre = valor.text;
        //    }
        //}
        //catch
        //{

        //}
    }

    public void setName(TMP_InputField valor)
    {
        if (nombre != valor.text)
        {
            nombre = valor.text;
        }
    }

    //void recorrerCanvas()
    //{
        
    //    for(int i = 0; i < canvas.transform.childCount; i++)
    //    {
    //        if(canvas.transform.GetChild(i).name == "inputNombre")
    //        {
    //            valor = canvas.transform.GetChild(i).GetComponent<TMP_InputField>();
    //        }
    //    }
    //}

   
}
