using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	void Update () {

		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				if (SceneManager.GetActiveScene ().buildIndex == 0) {
					Application.Quit ();
				} else {
					changeToScene (0);
				}
			}
		}
	}

	public void changeToScene(int changeTheScene)
	{
		SceneManager.LoadScene(changeTheScene);
	}
}