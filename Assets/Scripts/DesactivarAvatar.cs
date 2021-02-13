using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesactivarAvatar : MonoBehaviour
{
    public GameObject avatar;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        if(SceneManager.GetActiveScene().name == "Presentacion")
        {
            avatar.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Presentacion")
        {
            avatar.SetActive(false);
        }
    }
}
