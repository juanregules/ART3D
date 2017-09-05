using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFun : MonoBehaviour {

	private Quaternion rotateBy; //objeto quaternion representa rotaciones

	[Range(1, 10)]
	public int sensitivity; //sensibilidad de rotación

	void Update() {
		if (Input.touchCount == 1) { //detección de actividad touch con un dedo
			for (int i = 0; i < Input.touchCount; ++i) {
				if (Input.GetTouch (i).phase == TouchPhase.Moved) { //detectar desplazamiento del touch
					Vector3 touchPos = Input.GetTouch (i).deltaPosition; //asignar posición de desplazamiento del touch a variable
					Rotate (-touchPos.x, -touchPos.y); //ejectuar método Rotate
					transform.localRotation *= rotateBy; //localRotation es el quaternion del objeto al que se le asigno el script
				}
			}
		}
	}

	public void Rotate(float rotateLeftRight, float rotateUpDown) {

		Camera cam = Camera.main; //asignar cámara


		Vector3 relativeUp = cam.transform.TransformDirection(Vector3.up); //tomar dirección Y de la cámara
		Vector3 relativeRight = cam.transform.TransformDirection(Vector3.right); //tomar dirección X de la cámara
		Vector3 objectRelativeUp = transform.InverseTransformDirection(relativeUp); //crear dirección Y para el objeto
		Vector3 objectRelaviveRight = transform.InverseTransformDirection(relativeRight); //crear dirección X para el objeto

		rotateBy = Quaternion.AngleAxis(rotateLeftRight / transform.localScale.x * (sensitivity), objectRelativeUp)
			* Quaternion.AngleAxis(-rotateUpDown / transform.localScale.x  * (sensitivity), objectRelaviveRight); //asignar rotación a variable rotateBy

	}
}