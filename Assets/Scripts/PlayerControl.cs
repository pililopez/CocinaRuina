using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	Animator animacion;
	public float moveForce = 365f;            
	public float maxSpeed = 5f; 

//	private VidaPlayer vida;
	private ParticleSystem Sangre;
	// Use this for initialization
	void Start () {
//		vida = GameObject.Find ("Vida").GetComponent<VidaPlayer> ();
		animacion = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")) { 
			animacion.SetBool("sube", true);
			animacion.SetBool("baja", false);
			animacion.SetBool("izq_dch", false);
			animacion.SetBool("izq_dch", false);	
		}
		if (Input.GetKeyDown ("s")) { 
			animacion.SetBool("sube", false);
			animacion.SetBool("baja", true);
			animacion.SetBool("izq_dch", false);
			animacion.SetBool("izq_dch", false);	
		}
		if (Input.GetKeyDown ("d")) { 
			animacion.SetBool("sube", false);
			animacion.SetBool("baja", false);
			animacion.SetBool("izq_dch", true);
			transform.localScale = new Vector3(0.37f,0.37f,0.0f);

		}
		if (Input.GetKeyDown ("a")) { 
			animacion.SetBool("sube", false);
			animacion.SetBool("baja", false);
			animacion.SetBool("izq_dch", true);
			transform.localScale = new Vector3(-0.37f,0.37f,0.0f);
		}
	}
	void FixedUpdate (){
	// Cache the horizontal input.
		float h = Input.GetAxis ("Horizontal");
		
		
		if (h * rigidbody2D.velocity.x < maxSpeed)             
			rigidbody2D.AddForce (Vector2.right * h * moveForce);                  


		float v = Input.GetAxis ("Vertical");
		
		
		if (v * rigidbody2D.velocity.y < maxSpeed)             
			rigidbody2D.AddForce (Vector2.up * v * moveForce);                  


		if (v == 0 && h == 0) {
			if(v==0)
				rigidbody2D.velocity = new Vector3(0,rigidbody2D.velocity.y);
			if(h==0)
				rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x,0);
				}

		}



}
