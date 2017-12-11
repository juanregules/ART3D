using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initialize : MonoBehaviour {

	// Use this for initialization
	public GameObject hidden;
	public GameObject targets;


	void Start () {
		hidden.SetActive (false);
		targets.SetActive (false);
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
