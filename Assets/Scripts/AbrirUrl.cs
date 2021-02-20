using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirUrl : MonoBehaviour
{
    public void abrirLink(string link)
    {
        Application.OpenURL(link);
    }
}
