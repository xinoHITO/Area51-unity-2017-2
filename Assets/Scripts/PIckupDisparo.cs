using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckupDisparo : MonoBehaviour {
	public GameObject nuevaBalaPrefab;
	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		transform.Rotate(0,200*Time.deltaTime,0);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			other.GetComponent < ShootControl> ().balaPrefab = nuevaBalaPrefab;
			Destroy (gameObject);
		}
	}
}
