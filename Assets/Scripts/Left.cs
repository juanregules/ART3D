using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void changeModel()
	{
		//desactivar modelo activo y tomar su indice
		list.ActiveTrophy.SetActive(false);
		int indice = list.modelos.IndexOf(list.ActiveTrophy);
		//activar el siguiente modelo
		if (indice == 0) { //si ya es el primer modelo
			list.modelos[list.modelos.Count-1].SetActive (true); //regresar a último modelo
			list.ActiveTrophy = list.modelos[list.modelos.Count-1]; //asignar último trofeo a la variable trofeo activo
		} else { //si no es el primer modelo
			list.modelos[indice-1].SetActive(true); //activar siguiente modelo en la lista
			list.ActiveTrophy = list.modelos [indice-1]; //asignar ese modelo a la variable trofeo activo
		}

	}
}
