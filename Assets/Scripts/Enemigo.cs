using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {
	public GameObject[] pickups;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Vida>().salud <= 0) {
			//el enemigo tiene un 30% de probabilidad de dropear un power up
			float randomValue = Random.Range (0, 100);
			if (randomValue < 30) {
				int randomIndex = Random.Range (0, pickups.Length);
				Instantiate (pickups[randomIndex], transform.position, Quaternion.identity);	
			}
			//nos autodestruimos
			Destroy(gameObject);
		}

	}

}
