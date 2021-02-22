using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResponderPregunta : MonoBehaviour {


	//public Text canva_puntos;
	public int puntosPorRespuesta=0;
	public GameObject activadorPregunta;
	public GameObject Pregunta;

	public GameObject canvasPreguntas;
	public GameObject MisionCompletada;
	public GameObject MisionFallida;

	public GameObject Mensage1;
	public GameObject Mensage2;

	public AudioClip win;
	public AudioClip lose;

	public AudioSource audioSource;

	public float volume = 0.5f;

	public int numPre = 1;

	public int puntos = 0;

	void Start (){
		audioSource = GetComponent<AudioSource>();
	}

    private void Update()
    {
        if (numPre == 3 && puntos < 3)
        {
			MisionFallida.SetActive(true);
			canvasPreguntas.SetActive(false);
			puntos = 0;
			numPre = 0;
			Timer.m--;
			ActivadorPregunta.numPreguntas.Clear();
			//activadorPregunta.SetActive();
		}
        else if(numPre == 3 && puntos == 3)
        {
			SistemaPuntuacion.puntuacion += 10;
			MisionCompletada.SetActive(true);
			canvasPreguntas.SetActive(false);
			activadorPregunta.SetActive(false);
			Mensage1.SetActive(false);
			Mensage2.SetActive(false);
        }
    }

 //   public void Preguntas(){
	//	//puntos+=puntosPorRespuesta;
	//	StartCoroutine (res_correcta ());
	//}

	//IEnumerator res_correcta()
	//{
	//	gameObject.GetComponent<AudioSource> ().Play();
	//	//canva_puntos.text = puntos.ToString();
	//	yield return new WaitForSeconds (0.5f);
	//	//canva_puntos.text = "" + puntos;
	//	Destroy (Pregunta);
	//	Destroy (activadorPregunta);
	//	//activadorPregunta.GetComponent<Collider> ().enabled = false;
	//}

	public void sumarPuntos()
    {
		audioSource.PlayOneShot(win, volume);
		puntos++;
		Debug.Log(puntos);
    }

	public void respuestaIncorrecta()
    {
		audioSource.PlayOneShot(lose, volume);
    }

	public void contarPreguntas()
    {
		numPre++;
		Debug.Log(numPre);
	}

	

}
