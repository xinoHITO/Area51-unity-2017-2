using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

	[SerializeField] private Slider sliderVida;

	[SerializeField] private PlayerControl vida;

	void Update()
	{
		sliderVida.value = (float)vida.salud / 100f;
	}

}
