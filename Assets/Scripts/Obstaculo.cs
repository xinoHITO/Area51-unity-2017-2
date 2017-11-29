using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Bala") {
			//accedemos al componente Rigidbody dentro del obstaculo
			//y lo seteamos en falso
			GetComponent<Rigidbody>().isKinematic = false;

		}
	}
}
