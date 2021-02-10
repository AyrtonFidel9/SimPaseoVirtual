using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarPersonaje : MonoBehaviour
{
    public GameObject[] personajes;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        personajes = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            personajes[i] = transform.GetChild(i).gameObject;

        foreach (GameObject item in personajes)
        {
            item.SetActive(false);
        }

        if(personajes[index])
        {
            personajes[index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressHombre()
    {
        personajes[index].SetActive(false);
        index = 1;
        personajes[index].SetActive(true);
        Debug.Log(index.ToString());
    }

    public void pressMujer()
    {
        personajes[index].SetActive(false);
        index = 2;
        personajes[index].SetActive(true);
        Debug.Log(index.ToString());
    }

    public void escenaInicio()
    {
        Debug.Log(index.ToString());
        PlayerPrefs.SetInt("Eleccion",index);
        SceneManager.LoadScene("Inicio");
    }

}
