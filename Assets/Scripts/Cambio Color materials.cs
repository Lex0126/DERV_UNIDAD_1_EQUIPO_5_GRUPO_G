using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColormaterials : MonoBehaviour
{
  // Start is called before the first frame update
    // para poder agregar una variable en el unity se tiene que acompaniar con SerializeField
    Renderer rend;
    [SerializeField]Material color1;
   [SerializeField] Material color2;

    int estado;


    

    void Start()
    {
        rend= GetComponent<Renderer>();
        estado = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            if (estado ==0){
                estado=1;
                rend.material= color1;
            }else{
                estado=0;
                rend.material= color2;
            }
        }
    }
}
