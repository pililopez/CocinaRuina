using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public GameObject lemon;
	public GameObject puntoDisparo;
	public float velocidad = 10f;
	GameObject nueva_bala;
	PlayerControl pcontrol;
	
	// Use this for initialization
	void Start () {
		pcontrol = gameObject.GetComponent<PlayerControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			nueva_bala = (GameObject)Instantiate(lemon,transform.position,transform.rotation);
			nueva_bala.rigidbody2D.AddForce(pcontrol.vdisparo * velocidad*50);}
		Destroy (nueva_bala, 2);
		
	}

}
