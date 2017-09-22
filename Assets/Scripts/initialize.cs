using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initialize : MonoBehaviour {

	// Use this for initialization
	public GameObject hidden;
	public GameObject objetos;


	void Start () {
		hidden.SetActive (false);
		objetos.SetActive (true);
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
