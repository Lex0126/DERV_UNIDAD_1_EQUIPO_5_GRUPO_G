using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    // para poder agregar una variable en el unity se tiene que acompaniar con SerializeField
    Renderer rend;
    [SerializeField]Color colorcito;
    // Start is called before the first frame update
    void Start()
    {
        rend= GetComponent<Renderer>();
        //colorcito = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = colorcito;
    }
}
