using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleObjects : MonoBehaviour {

	public static List<GameObject> modelos = new List<GameObject>(); //lista para almacenar trofeos obtenidos
	public static GameObject ActiveTrophy; //variable para almacenar el trofeo activo

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			child.gameObject.SetActive (false); //desactivar todos los modelos
			if (TrophyCollect.trofeos.Contains (child.gameObject.name)) {
				modelos.Add(child.gameObject); //agregar trofeos a lista de trofeos obtenidos
			}
		}
		if (TrophyCollect.trofeos.Count == 0) { //si no hay más de un trofeo obtenido desactivar componentes de navegación
			GameObject.Find("ChangeModelR").SetActive(false);
			GameObject.Find("ChangeModelL").SetActive(false);
		} else {
			if (TrophyCollect.trofeos.Count == 1) {
				GameObject.Find("ChangeModelR").SetActive(false);
				GameObject.Find("ChangeModelL").SetActive(false);
			}
			GameObject.Find ("NoTrophies").SetActive (false); //desactivar mensaje de no trofeos
			modelos[0].SetActive (true); //activar primer modelo
			ActiveTrophy = modelos [0]; //asignar primer modelo a variable de trofeo activo
		}
	}

	void OnDestroy () {
		modelos.Clear (); //limpiar variable estática cuando hay cambio de escena
	}
}
