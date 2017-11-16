using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class list : MonoBehaviour {

	public static List<GameObject> modelos = new List<GameObject>(); //lista para almacenar trofeos obtenidos
	public static GameObject ActiveTrophy; //variable para almacenar el trofeo activo

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			modelos.Add(child.gameObject); //agregar trofeos a lista de trofeos obtenidos
		}
		modelos[0].SetActive (true); //activar primer modelo
		ActiveTrophy = modelos [0]; //asignar primer modelo a variable de trofeo activo
	}

	// Update is called once per frame
	void Update () {

	}
		
}
