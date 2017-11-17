using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public int velocidad;

	// Use this for initialization
	void Start () {
		CambiarColor ();
	}
	
	// Update is called once per frame
	void Update () {
		Movimiento ();
		if (Input.GetKey (KeyCode.Space)) {
			CambiarColor ();
		}
	}

	void CambiarColor(){
		GetComponent<Renderer> ().material.color = Random.ColorHSV();
	}

	void Movimiento(){
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate (0, velocidad*Time.deltaTime, 0);	
		}

		if (Input.GetKey(KeyCode.S)) {
			transform.Translate (0, -velocidad*Time.deltaTime, 0);	
		}

		if (Input.GetKey(KeyCode.A)) {
			transform.Translate (-velocidad*Time.deltaTime,0, 0);	
		}

		if (Input.GetKey(KeyCode.D)) {
			transform.Translate (velocidad*Time.deltaTime,0, 0);	
		}
	}
}
