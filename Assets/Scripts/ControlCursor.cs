using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public int tamanioCursor = 32;
    public Texture2D cursorMano, cursorNormal;
    Texture2D cursorActivo;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        cambiarCursor("normal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarCursor(string tipoCursor)
    {
        if(tipoCursor == "normal")
        {
            cursorActivo = cursorNormal;
        }
        else if(tipoCursor == "mano")
        {
            cursorActivo = cursorMano;
        }
    }

    private void OnGUI() {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y,tamanioCursor, tamanioCursor),cursorActivo);    
    }
}
