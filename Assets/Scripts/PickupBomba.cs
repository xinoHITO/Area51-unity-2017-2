using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBomba : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update(){
		transform.Rotate(0,200*Time.deltaTime,0);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			other.GetComponent < ShootControl> ().cantidadBombas++;
			Destroy (gameObject);
		}
	}
}
