using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	[SerializeField] Animator animator;
	[SerializeField] int salud;

	public GameObject[] pickups;

	bool isDead;

	public void Herir(int danio)
	{
		if (isDead)
			return;

		salud -= danio;
		if (salud <= 0) 
		{
			Morir ();
		}
		else
			animator.SetTrigger ("Herir");
	}

	void Morir()
	{
		if (isDead)
			return;

		isDead = true;

		//el enemigo tiene un 30% de probabilidad de dropear un power up
		float randomValue = Random.Range (0, 100);
		if (randomValue < 30) {
			int randomIndex = Random.Range (0, pickups.Length);
			Instantiate (pickups[randomIndex], transform.position, Quaternion.identity);	
			//nos autodestruimos

		}

		if(animator)
			animator.SetBool ("EstoyMuerto", true);
	}

	void Destruir()
	{
		Destroy (gameObject);
	}

}
