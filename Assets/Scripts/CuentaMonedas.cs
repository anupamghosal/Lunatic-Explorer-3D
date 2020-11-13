using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaMonedas : MonoBehaviour {

    public int puntuacionNivel;

    public Transform monedas;
    public GameObject textoPuntuacion;
    public GameObject MenuGameOver;

    private int numMonedasNivel;

    void Start()
    {
        Time.timeScale = 1f; 
        MenuGameOver.SetActive(false);

        puntuacionNivel = 0;
        numMonedasNivel = monedas.transform.childCount;
        textoPuntuacion.GetComponent<Text>().text = puntuacionNivel + "/" + numMonedasNivel;
    }

    void Update () {
	

        if(puntuacionNivel == numMonedasNivel)
        {
            MenuGameOver.SetActive(true); 
            Time.timeScale = 0f; 
        }


	}

    public void aumentarPuntuacion()
    {
        puntuacionNivel++;
        textoPuntuacion.GetComponent<Text>().text = puntuacionNivel + "/" + numMonedasNivel;
    }
}
