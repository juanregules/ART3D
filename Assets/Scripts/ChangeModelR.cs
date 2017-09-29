using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeModelR : MonoBehaviour {

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
		//activar el siguiente modelo
		if (indice + 1 == InvisibleObjects.modelos.Count) { //si ya es el último índice
			InvisibleObjects.modelos [0].SetActive (true); //regresar a primer modelo
			InvisibleObjects.ActiveTrophy = InvisibleObjects.modelos [0]; //asignar primer modelo a la variable trofeo activo
			GameObject.Find("ModelName").GetComponent<Text>().text = InvisibleObjects.ActiveTrophy.name; //asignar nombre del modelo a visualización
		} else { //si no es el último índice
			InvisibleObjects.modelos[indice+1].SetActive(true); //activar siguiente modelo en la lista
			InvisibleObjects.ActiveTrophy = InvisibleObjects.modelos [indice+1]; //asignar ese modelo a la variable trofeo activo
			GameObject.Find("ModelName").GetComponent<Text>().text = InvisibleObjects.ActiveTrophy.name; //asignar nombre del modelo a visualización
		}

	}
}
