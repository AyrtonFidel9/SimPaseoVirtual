using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject ObjectToPickup;//variable tipo game object
    public static GameObject PickedObject;//objeto que hemos cogido
    public Transform interactionZone;//zona de interaccion lugar donde va ubicar a los objetos cogidos
    // Start is called before the first frame update
    public bool agacharse = false;//variable booleana donde almacena la ejecucion
    public static bool inabilitar = false;//variable tipo bool para habilitar acciones
    private Animator animacion;//varoable para que ejecute la animacion 
    void Start()//metodo start
    {
        animacion = GetComponent<Animator>();//se almacena la animacion  en la variable declarada
    }
    // Update is called once per frame
    void Update()//metodo Update
    {
        Agacharse();//llamo al metodo para que se agache el personaje
    }
    public void Agacharse()//creo un metodo para que se agache el personaje 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))//si se presiona la tecla leftShift el personaje se agacha
        {
            inabilitar = false;//inhabilitado
            agacharse = true;//ejecuta agacharse
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))//deja de precionar
        {
            agacharse = false;
        }
        if (agacharse)
        {
            animacion.SetBool("Quieto", true);//verifica si la animacion esta activa es
                                              // decir esta ejecutamdose
                                              //si es true se agacha,
        }
        else
        {
            animacion.SetBool("Quieto", false);//verifica si la animacion esta activa es
                                               //  decir esta ejecutamdose
                                               //si es falsa es decir no esta quieto, esta en movimiento ejecuta la
                                               //animacion de desplazarse arriba abajo,
                                               //rotar de derecha a izquierda
        }
        if (ObjectToPickup != null && ObjectToPickup.GetComponent<PickableObject>().isPickable == true && PickedObject == null)
        {//con la tecla espacio ejecuto la animacion de
         // agacharse
            if (inabilitar == false)
            {
                PickedObject = ObjectToPickup;//el obejto que hemos cogigo es el que teniamos que coger
                PickedObject.GetComponent<PickableObject>().isPickable = false;//
                PickedObject.transform.SetParent(interactionZone);//la zona de interaccion va a ser el padre del objeto
                PickedObject.transform.position = interactionZone.position;//la posicion del obejto sea la misma de la zona de interacccion
                PickedObject.GetComponent<Rigidbody>().useGravity = false;//le quitamos la gravedad para q se quede el obejto en las manos
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;//aplicamos una fisica al objeto
            }
        }
        else if (PickedObject != null)//con la tecla z paso de estado quieto a                              //  activo
        {
            if (Input.GetKeyDown(KeyCode.F))//si pulsamos la tecla f soltamos el obejto
            {
                inabilitar = true;
                Debug.Log("tecla f");

                PickedObject.GetComponent<PickableObject>().isPickable = true;//porque podemos coger una vez q lo soltamos
                PickedObject.transform.SetParent(null);// el objeto vuelve a su estado incial es decir ya no tiene padre
                PickedObject.GetComponent<Rigidbody>().useGravity = true;//la gravedad vuelve a ser verdadera
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;//la fisica se vuelve falsa
                PickedObject = null;//esto se hace null
            }
        }
    }
    public static void TirarB()
    {
        try
        {
            inabilitar = true;
            PickedObject.GetComponent<PickableObject>().isPickable = true;//porque podemos coger una vez q lo soltamos
            PickedObject.transform.SetParent(null);// el objeto vuelve a su estado incial es decir ya no tiene padre
            PickedObject.GetComponent<Rigidbody>().useGravity = true;//la gravedad vuelve a ser verdadera
            PickedObject.GetComponent<Rigidbody>().isKinematic = false;//la fisica se vuelve falsa
            PickedObject = null;//esto se hace null
        }
        catch
        {

        }
    }
}
