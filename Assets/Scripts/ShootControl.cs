using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour {
	public GameObject balaPrefab;
	public GameObject balaPrefab2;
	public GameObject spawnBalas;
	public GameObject spawnBalas2;

	public int cantidadBombas = 5;
	//Cuando usas private delante de una variable... ésta ya no aparecerá en el editor.
	//Como esta variable es enteramente controlada internamente por el script
	//no tiene sentido que este visible en el editor
	private float tiempoDisparo = 0;
	public float intervaloDisparo = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//la funcion Instantiate crea una copia del objeto que le pasamos.
		//Luego Unity coloca esta copia en una coordenada y rotacion especifica 
		//dentro de la escena.
		if (Input.GetMouseButton (0)) {
			//tiempoDisparo cuenta la cantidad de tiempo que tenemos
			//presionado el click izquierdo
			tiempoDisparo = tiempoDisparo + Time.deltaTime;
			//revisamos si nuestro contador ya superó el intervalo de tiempo
			//para disparar
			if (tiempoDisparo >= intervaloDisparo) {
				Instantiate (balaPrefab, spawnBalas.transform.position, Quaternion.identity);
				tiempoDisparo = 0;
			}
		}
		//al soltar el click seteamos el contador igual al intervalo
		//esto lo hacemos para que la proxima vez que hagas click
		//el primer disparo sea instataneo (apenas presiones el mouse)
		if (Input.GetMouseButtonUp (0)) {
			tiempoDisparo = intervaloDisparo;	
		}

		if (Input.GetMouseButtonDown (1)) {
			if (cantidadBombas > 0) {
				Instantiate (balaPrefab2, spawnBalas2.transform.position, Quaternion.identity);
				cantidadBombas = cantidadBombas - 1;
			}

		}

	}
}
