using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
	public float intervaloDisparo = 1.0f;
	private float tiempoDisparo;
	public GameObject balaPrefab;
	public GameObject spawnBalas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempoDisparo += Time.deltaTime;

		if (tiempoDisparo >= intervaloDisparo) {
			Instantiate (balaPrefab, spawnBalas.transform.position, Quaternion.Euler(0,0,180));
			tiempoDisparo = 0;
		}
	}
}
