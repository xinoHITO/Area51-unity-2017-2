using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour {
	public GameObject balaPrefab;
	public GameObject balaPrefab2;
	public GameObject spawnBalas;
	public GameObject spawnBalas2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//la funcion Instantiate crea una copia del objeto que le pasamos.
		//Luego Unity coloca esta copia en una coordenada y rotacion especifica 
		//dentro de la escena.
		if (Input.GetKeyDown(KeyCode.Space)) {
			//Input.GetMouseButtonDown
			Instantiate (balaPrefab, spawnBalas.transform.position, Quaternion.identity);
			Instantiate (balaPrefab2, spawnBalas2.transform.position, Quaternion.identity);
		}

	}
}
