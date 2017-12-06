using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour {
	private bool inflar;
	// Use this for initialization
	void Start () {
		Invoke ("ComienzaInflar", 1.0f);
		Invoke ("AutoDestruir", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (inflar == true) {
			transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);	
		} else {
			transform.Translate (5 * Time.deltaTime, 0, 0);
		}
	}

	//se ejecuta cuando algun objeto entra en la zona del trigger 
	void OnTriggerEnter(Collider other){
		//si el objeto que ha entrado al trigger tiene el tag "Enemigo" ... 
		if (other.tag == "Enemigo") {
			//le reducimos su salud
			other.GetComponent<Vida> ().salud = other.GetComponent<Vida> ().salud - 100;
		}


	}

	void ComienzaInflar(){
		inflar = true;
	}

	void AutoDestruir(){
		Destroy (gameObject);
	}
}
