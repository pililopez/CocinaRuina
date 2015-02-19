using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {
	Animator animacion;

	public void  Instrucciones(){
	if (Input.GetMouseButton ("0")) 
			Animation.SetBool ("Instrucciones"), true;		
	if (!Input.GetMouseButton ("0")) 
			Animation.SetBool ("Instrucciones fuera"), true;	

	}
	public void Salir(){
		Application.Quit ();
	}

	public void Jugar(){
		Application.LoadLevel ("fase1");
	}

	public void Logros(){
	/*	if (Input.GetMouseButton ("0")) {
			Animation.SetBool ("Logros", true);	
		}*/
	}
	public void Recetas(){

	}
}
