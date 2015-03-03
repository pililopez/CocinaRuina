using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public GameObject lemon;
	public GameObject puntoDisparo;
	public float velocidad = 5f;
	GameObject nueva_bala;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.B)) {
			nueva_bala = (GameObject)Instantiate(lemon,puntoDisparo.transform.position,Quaternion.identity);
			nueva_bala.rigidbody.AddForce(puntoDisparo.transform.forward*velocidad);}
		Destroy (nueva_bala, 2);
		
	}

}
