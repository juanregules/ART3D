using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	void Update () {

		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				changeToScene (0);
				return;
			}
		}
	}

	public void changeToScene(int changeTheScene)
	{
		SceneManager.LoadScene(changeTheScene);
	}
}