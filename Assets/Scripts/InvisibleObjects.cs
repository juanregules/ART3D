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
				modelos.Add (child.gameObject); //agregar trofeos a lista de trofeos obtenidos
			}
		}
		if (TrophyCollect.trofeos.Count == 0) { //si no hay trofeos obtenidos desactivar componentes de navegación
			GameObject.Find("ChangeModelR").SetActive(false);
			GameObject.Find("ChangeModelL").SetActive(false);
		} else {
			modelos[0].SetActive (true); //activar primer modelo
			ActiveTrophy = modelos [0]; //asignar primer modelo a variable de trofeo activo
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
