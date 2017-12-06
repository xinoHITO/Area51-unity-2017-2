using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	//int se usa para almacenar numeros enteros
	public int velocidadCaminar;
	//float se usa para almacenar numeros decimales
	public float velocidadCorrer;
	//bool es un tipo de variable que solo puede tener dos valores : verdadero y falso
	public bool canControl;

	public int contador;

	public int contadorRojoAzul;
	// Use this for initialization
	void Start () {
//		canControl = true;
//		canControl = false;

		//aqui le estamos asignando un valor int a una variable float
		//esto es valido porque internamente se pueden transformar enteros a decimales
	//	velocidadCorrer = velocidadCaminar + 2;

		//un if puede tener como condicion cualquier expresion que resulte en un valor de true / false
		if (canControl) {
			Debug.Log ("can control esta prendido");
		}//opcionalmente se puede agregar un else cuyo contenido se ejecuta cuando la condicion del if resulta falsa 
		else {
			Debug.Log ("can control esta apagado");
		}

		CambiarColorRandom ();
	}
	
	// Update is called once per frame
	void Update () {

		if (GetComponent<Vida>().salud <= 0) {
			Destroy(gameObject);
		}


		if (canControl) {
			//ejecutamos nuestra funcion movimiento
			Movimiento ();				
		}
		//queremos que cada vez que hagas 10 clicks ...cambies de color
		if (Input.GetMouseButtonDown (0)) {
			//incrementamos el contador
			contador = contador + 1;
			//preguntamos si el contador es exactamente igual a 10
			if (contador == 10) {//podemos usar comparaciones numéricas dentro de un if
				//cambiamos de color
				CambiarColorRandom ();
				//reseteamos el contador de vuelta a cero
				contador = 0;
			}
		}


		if (Input.GetKey (KeyCode.Space)) {
			CambiarColorRandom ();
			velocidadCaminar = 10;
		}

		if (Input.GetMouseButtonDown (1)) {
			CambiarColorRojoAzul ();
		}
	}

	void CambiarColorRojoAzul(){
		//incrementamos el contador en uno
		contadorRojoAzul = contadorRojoAzul + 1;
		//chequeamos si es par o impar para saber que color pintarle
		if (contadorRojoAzul % 2 == 0) {
			GetComponent<Renderer> ().material.color = Color.red;	
		} else {
			GetComponent<Renderer> ().material.color = Color.blue;
		}
	}

	void CambiarColorRandom(){
		GetComponent<Renderer> ().material.color = Random.ColorHSV();
	}

	//creamos nuestra propia funcion llamada Movimiento
	void Movimiento(){
		//detectamos click izquiero del mouse
//		if (Input.GetMouseButtonDown(0)) {
//			velocidadCaminar = 4;
//		}
//
//		//detectamos click derecho del mouse
//		if (Input.GetMouseButtonDown(1)) {
//			velocidadCaminar = 20;
//		}


		if (Input.GetKey (KeyCode.LeftShift)) {
			//detectamos cuando presiones la tecla W
			if (Input.GetKey (KeyCode.W)) {
				if (transform.position.y < 6.2f) {
					//movemos el personaje en el eje Y (osea hacia arriba)
					transform.Translate (0, velocidadCorrer * Time.deltaTime, 0);	
				}
			}

			if (Input.GetKey (KeyCode.S)) {
				if (transform.position.y > -4) {
					transform.Translate (0, -velocidadCorrer * Time.deltaTime, 0);	
				}
			}

			if (Input.GetKey (KeyCode.A)) {
				if (transform.position.x > -12) {
					transform.Translate (-velocidadCorrer * Time.deltaTime, 0, 0);	
				}
			}

			if (Input.GetKey (KeyCode.D)) {
				if (transform.position.x < 12) {
					transform.Translate (velocidadCorrer * Time.deltaTime, 0, 0);	
				}
			}
		} else {
			//detectamos cuando presiones la tecla W
			if (Input.GetKey(KeyCode.W)) {
				if (transform.position.y < 6.2f) {
					//movemos el personaje en el eje Y (osea hacia arriba)
					transform.Translate (0, velocidadCorrer * Time.deltaTime, 0);	
				}
			}

			if (Input.GetKey(KeyCode.S)) {
				if (transform.position.y > -4) {
					transform.Translate (0, -velocidadCorrer * Time.deltaTime, 0);	
				}
			}

			if (Input.GetKey(KeyCode.A)) {
				if (transform.position.x > -12) {
					transform.Translate (-velocidadCorrer * Time.deltaTime, 0, 0);	
				}
			}

			if (Input.GetKey(KeyCode.D)) {
				if (transform.position.x < 12) {
					transform.Translate (velocidadCorrer * Time.deltaTime, 0, 0);	
				}
			}
		
		}



	}
}
