using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorPregunta : MonoBehaviour {
	public GameObject CanvasPregunta;
	public static List<int> numPreguntas = new List<int>();
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col){
		switch (col.gameObject.tag){
		case "Player":
				CanvasPregunta.SetActive(true);
				Debug.Log("El jugador entra lista: "+numPreguntas.Count);
				break;
		}
	}
	void OnTriggerExit(Collider col){
		switch (col.gameObject.tag){
		case "Player":
				CanvasPregunta.SetActive(false);
				Debug.Log("El jugador salio lista: " + numPreguntas.Count);
			break;
		}
	}

	public void MostrarPregunta()
    {
		int num = generarPregunta();
		CanvasPregunta.transform.GetChild(num).gameObject.SetActive(true);
		//Pregunta[num].SetActive(true);
	}

	int generarPregunta()
    {
		int num_alt = 0;
		bool sw = true;
		if (numPreguntas.Count == 0)
        {
			num_alt = Random.Range(1, 8);
			numPreguntas.Add(num_alt);
        }
        else
        {
            while (sw && numPreguntas.Count<4)
            {
				num_alt = Random.Range(1, 8);
                if (!numPreguntas.Contains(num_alt))
                {
					numPreguntas.Add(num_alt);
					sw = false;
                }
            }
        }
		Debug.Log("Numero aleatorio: "+num_alt);
		return num_alt;
    }
}
