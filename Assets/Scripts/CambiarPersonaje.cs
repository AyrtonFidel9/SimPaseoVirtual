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

        if (personajes[index])
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
        /* personajes[3].SetActive(true);
        personajes[4].SetActive(true); */
    }

    public void pressMujer()
    {
        personajes[index].SetActive(false);
        index = 2;
        personajes[index].SetActive(true);
        /* personajes[3].SetActive(true);
        personajes[4].SetActive(true); */
    }

    public void escenaInicio()
    {
        PlayerPrefs.SetInt("Eleccion 2", index);
        PlayerPrefs.GetInt("NombrePlayer", 0);
        SceneManager.LoadScene("Inicio");
    }

    public void escenaTutorial ()
    {
        PlayerPrefs.SetInt("Eleccion 2", index);
        PlayerPrefs.GetInt("NombrePlayer", 0);
        SceneManager.LoadScene("Tutorial");
    }

    public void escenaPresentacion()
    {
        PlayerPrefs.SetInt("Eleccion 2", index);
        PlayerPrefs.GetInt("NombrePlayer", 0);
        SceneManager.LoadScene("Presentacion");
    }

    //void desactivarCamara()
    //{
    //    if (SceneManager.GetActiveScene().name == "Presentacion")
    //    {
    //        personajes[3].SetActive(false);
    //        personajes[4].SetActive(false);
    //        personajes[5].SetActive(false);
    //        personajes[6].SetActive(false);

    //        personajes[1].transform.GetChild(9).gameObject.SetActive(false);
    //        personajes[1].transform.GetChild(10).gameObject.SetActive(false);
    //        personajes[2].transform.GetChild(7).gameObject.SetActive(false);
    //        personajes[2].transform.GetChild(8).gameObject.SetActive(false);
    //    }
    //}

}
