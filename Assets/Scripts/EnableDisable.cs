using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour {
	
	public GameObject Enable_Disable;
	public GameObject Also;

	public void Enable () {
		Enable_Disable.SetActive (true);
		Also.SetActive (false);
	}
	
	public void Disable () {
		Enable_Disable.SetActive (false	);
		Also.SetActive (true);
	}
}
