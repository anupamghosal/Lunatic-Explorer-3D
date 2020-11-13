using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionMoneda : MonoBehaviour {

    public float velocidadGiro;

    public GameObject cuentaMonedas;

	void Update () {


        
        transform.Rotate(velocidadGiro * Vector3.up * Time.deltaTime);

	}

    
    private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.CompareTag("Player"))
        {

            AudioSource sonido = transform.GetComponent<AudioSource>();
            sonido.Play();

            cuentaMonedas.GetComponent<CuentaMonedas>().aumentarPuntuacion();

            Destroy(transform.gameObject, sonido.clip.length);

            transform.gameObject.GetComponent<MeshRenderer>().enabled = false;
            transform.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
