using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoDePersonaje : MonoBehaviour {


    public GameObject objPrincipal; 

    public float distancia = 15; 
    public float altura = 5; 

    public float margenAltura = 3;
    public float margenRotacion = 3;

	void Update () {
		
        if(objPrincipal.transform)
        {
            Transform objetivo = objPrincipal.transform;

            float objetivoAngulo = objetivo.eulerAngles.y;
            float objetivoAltura = objetivo.position.y + altura;

            float camaraAnguloActual = transform.eulerAngles.y;
            float camaraAlturaActual = transform.position.y;

            camaraAnguloActual = Mathf.LerpAngle(camaraAnguloActual, objetivoAngulo, margenRotacion * Time.deltaTime);
            camaraAlturaActual = Mathf.LerpAngle(camaraAlturaActual, objetivoAltura, margenAltura * Time.deltaTime);

            Quaternion rotac = Quaternion.Euler(0, camaraAnguloActual, 0);


            
            Vector3 pos = objetivo.position;
            pos -= rotac * Vector3.forward * distancia;
            pos.y = camaraAlturaActual;
            transform.position = pos;

            transform.LookAt(objetivo);

        }


    }
}
