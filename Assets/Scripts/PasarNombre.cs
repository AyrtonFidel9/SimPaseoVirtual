using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasarNombre : MonoBehaviour
{
    public void setName(TMP_InputField valor)
    {
        ConservarNombre.user.setName(valor);
    }
}
