using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float limitesup, limiteinf, limiteizq, limitedrc;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var posx = personaje.position.x; 
		var posy = personaje.position.y; 
		if (limiteinf > personaje.position.y || limitesup < personaje.position.y) {
						posy = transform.position.y;
				}
		 if (limiteizq > personaje.position.x || limitedrc < personaje.position.x) {
			posx =transform.position.x;
				}
		transform.position = new Vector3 (posx, posy, transform.position.z);
				
	}
}

	

