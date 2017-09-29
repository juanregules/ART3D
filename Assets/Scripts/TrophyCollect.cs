using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrophyCollect : MonoBehaviour {
	
	public static List<string> trofeos = new List<string>(); //variable para guardar lista de trofeos

	void Start () {
		
		trofeos.Clear (); //limpiar lista dinámica de trofeos para evitar redundancia
		if (PlayerPrefs.GetString ("trofeos") == "") { //si no hay variable trofeos en la memoria
			//no hacer nada
		} else { //si hay variable trofeos en la memoria
			//separar el string de la memoria y convertirlo en la lista de objetos
			foreach (string objetos in PlayerPrefs.GetString("trofeos").Split(',')) {
				trofeos.Add (objetos);
			}
		}
	}

}