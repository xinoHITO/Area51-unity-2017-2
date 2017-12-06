using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBomba : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update(){
		//rotamos constantemente en torno al eje Y
		transform.Rotate(0,200*Time.deltaTime,0);
	}

	void OnTriggerEnter(Collider other) {
		//preguntamos por el tag del objeto que hemos tocado
		if (other.tag == "Player") {
			//obtenemos el componente ShootControl dentro del objeto que hemos tocado
			//e incrementamos la variable cantidadBombas en uno
			other.GetComponent < ShootControl> ().cantidadBombas++;
			//nos autodestruimos
			Destroy (gameObject);
		}
	}
}
