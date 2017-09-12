using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyCollect : MonoBehaviour {
	
	private GameObject esteObjeto; //variable para referenciar el objeto trophycollect
	public static List<string> trofeos = new List<string>(); //variable para guardar lista de trofeos

	void Start () {
		esteObjeto= this.gameObject; //asignar objeto a la variable
		DontDestroyOnLoad (esteObjeto); //mantener este objeto en el cambio de escena
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