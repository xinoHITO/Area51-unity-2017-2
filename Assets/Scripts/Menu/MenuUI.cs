using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour {


	public void UI_CargarEscena(string _nombreEscena)
	{
		SceneManager.LoadScene (_nombreEscena, LoadSceneMode.Single);
	}

	public void UI_CerrarJuego()
	{
		Application.Quit ();
	}

	public void UI_ToogleMusica(bool _estaPrendido)
	{
		Debug.Log (_estaPrendido);
	}

}
