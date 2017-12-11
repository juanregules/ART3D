using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour {

	public void politicas(){
		Application.OpenURL ("https://tec.mx/es/politicas-de-privacidad-del-tecnologico-de-monterrey");
	}
	public void legal(){
		Application.OpenURL ("https://tec.mx/es/aviso-legal");
	}
	public void aviso(){
		Application.OpenURL ("https://tec.mx/es/avisos-de-privacidad");
	}
	public void targets(){
		Application.OpenURL ("https://canvas.instructure.com");
	}
}

