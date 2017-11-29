using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
	public float velocidad = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocidad * Time.deltaTime, 0, 0);
	}

	//la funcion OnTriggerEnter requiere que ya sea el trigger o el objeto que se mete dentro del trigger
	//al menos uno debe tener el componente Rigidbody

	//se ejecuta cuando algun objeto entra en la zona del trigger 
	void OnTriggerEnter(Collider other){
		//si el objeto que ha entrado al trigger tiene el nombre "Enemigo" ... lo destruimos
		if (other.tag == "Enemigo") {
			Destroy (other.gameObject);
		}

		//nos auto destruimos
		Destroy	(gameObject);
	}
}
