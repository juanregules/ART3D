using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour {

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
		int indice = list.objetos.IndexOf(list.ActiveTrophy);
		//activar el siguiente modelo
		if (indice + 1 == list.objetos.Count) { //si ya es el último índice
			list.objetos [0].SetActive (true); //regresar a primer modelo
			list.ActiveTrophy = list.objetos [0]; //asignar primer modelo a la variable trofeo activo
		} else { //si no es el último índice
			list.objetos[indice+1].SetActive(true); //activar siguiente modelo en la lista
			list.ActiveTrophy = list.objetos [indice+1]; //asignar ese modelo a la variable trofeo activo
		}

	}

}
