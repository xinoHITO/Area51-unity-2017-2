using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
	public float intervaloDisparo = 1.0f;
	private float tiempoDisparo;
	public GameObject balaPrefab;
	public GameObject spawnBalas;

	public GameObject[] spawns;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempoDisparo += Time.deltaTime;

		if (tiempoDisparo >= intervaloDisparo) {

			for (int i = 0; i < spawns.Length; i++) {
				Instantiate (balaPrefab, spawns[i].transform.position, spawns[i].transform.rotation);
			}

			tiempoDisparo = 0;
		}
	}
}
