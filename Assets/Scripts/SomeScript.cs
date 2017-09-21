using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript : MonoBehaviour {
	private GameObject ayy;
	void Start() {
		ayy = GameObject.Find ("FU");
		ayy.SetActive (false);
	}
	public void multiTapping () {
		ayy.SetActive (true);
	}


}
