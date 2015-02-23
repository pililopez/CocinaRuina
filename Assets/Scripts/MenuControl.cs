using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	Animator animacion;


	void Start(){
		animacion = GetComponent<Animator> ();

	}

	public void  Instrucciones(){

		if (Input.GetMouseButtonDown (0)) { 
			animacion.SetBool("instruc", true);	
					}

	}
	public void Salir(){
		Application.Quit ();
	}

	public void Jugar(){
		Application.LoadLevel ("fase1");
	}

	public void Logros(){
		if (Input.GetMouseButtonDown (0)) {
				animacion.SetBool ("logro", true);	
		}
		if (Input.GetMouseButtonDown (0)) { 
				animacion.SetBool ("Logros fuera", true);	
		}
	}
	public void Recetas(){

	}
}
