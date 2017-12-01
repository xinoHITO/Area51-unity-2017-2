using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
	public int dano = 20;
	public float velocidad = 10;
	public string targetTag;
	// Use this for initialization
	void Start () {
		Invoke ("AutoDestruir", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocidad * Time.deltaTime, 0, 0);
	}

	//la funcion OnTriggerEnter requiere que ya sea el trigger o el objeto que se mete dentro del trigger
	//al menos uno debe tener el componente Rigidbody

	//se ejecuta cuando algun objeto entra en la zona del trigger 
	void OnTriggerEnter(Collider other){
		//si el objeto que ha entrado al trigger tiene el tag "Enemigo" ... 
		if (other.tag == targetTag) {
			//le reducimos su salud
			other.GetComponent<Vida> ().salud = other.GetComponent<Vida> ().salud - dano;
		}

		//nos auto destruimos
		Destroy	(gameObject);
	}

	void AutoDestruir(){
		//nos auto destruimos
		Destroy	(gameObject);
	}
}
