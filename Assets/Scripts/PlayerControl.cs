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
		if (Input.GetButtonDown ("W")) { 
			animacion.SetBool("sube", true);	
		}
		if (Input.GetButtonDown ("S")) { 
			animacion.SetBool("baja", true);	
		}
		if (Input.GetButtonDown ("D")) { 
			animacion.SetBool("izq_dch", true);	
		}
		if (Input.GetButtonDown ("A")) { 
			animacion.SetBool("izq_dch", true);	
		}
	}
	void FixedUpdate (){
	// Cache the horizontal input.
		float h = Input.GetAxis ("Horizontal");
		
		
		if (h * rigidbody2D.velocity.x < maxSpeed)             
			rigidbody2D.AddForce (Vector2.right * h * moveForce);                  
		if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
			rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

		float v = Input.GetAxis ("Vertical");
		
		
		if (v * rigidbody2D.velocity.y < maxSpeed)             
			rigidbody2D.AddForce (Vector2.up * v * moveForce);                  
		if (Mathf.Abs (rigidbody2D.velocity.y) > maxSpeed)
			rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.y) * maxSpeed, rigidbody2D.velocity.y);



		}



}
