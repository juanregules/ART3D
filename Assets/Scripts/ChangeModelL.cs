using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModelL : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeModel()
	{
		//desactivar modelo activo y tomar su indice
		InvisibleObjects.ActiveTrophy.SetActive(false);
		int indice = InvisibleObjects.modelos.IndexOf(InvisibleObjects.ActiveTrophy);
		//recuperar modelos inactivos, y activar el siguiente
		if (indice == 0) { //si ya es el primer modelo
			InvisibleObjects.modelos[InvisibleObjects.modelos.Count-1].SetActive (true); //regresar a último modelo
			InvisibleObjects.ActiveTrophy = InvisibleObjects.modelos[InvisibleObjects.modelos.Count-1]; //asignar último trofeo a la variable trofeo activo
		} else { //si no es el primer modelo
			InvisibleObjects.modelos[indice-1].SetActive(true); //activar siguiente modelo en la lista
			InvisibleObjects.ActiveTrophy = InvisibleObjects.modelos [indice-1]; //asignar ese modelo a la variable trofeo activo
		}

	}
}
