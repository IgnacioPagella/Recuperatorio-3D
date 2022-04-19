using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Los3Gustos : MonoBehaviour
{
    public bool FRU;
    public bool CHO;
    public bool DDL;
    public int cantHelado;
    float final;
    float descuento;
    float descuentoAplicado;
    float descuento2;

    // Start is called before the first frame update
    void Start()
    {
        if (cantHelado < 250 || cantHelado > 3000)
        {
            Debug.Log("Error");
        }
           else  if (cantHelado > 250 || cantHelado < 3000 || FRU == true)
        {
            final = (cantHelado * 0.5f);
            descuento = (10 * final);
            descuento2 = (descuento / 100);
            descuentoAplicado = (final - descuento2); 
            Debug.Log("usted debe pagar " + descuentoAplicado);

        }
        else if (cantHelado > 250 || cantHelado < 3000)
        {
            final = (cantHelado * 0.5f);
            Debug.Log("usted debe pagar " + final);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
