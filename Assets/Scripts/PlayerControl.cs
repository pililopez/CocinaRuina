using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float moveForce = 365f;            
	public float maxSpeed = 5f; 

//	private LiveController live;
	private ParticleSystem Sangre;
	// Use this for initialization
	void Start () {
//		live = GameObject.Find ("Live").GetComponent<LiveController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
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

/*	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemigo"){
			live.total_live -=10;
			Destroy(col.gameObject);
		}

		if (col.gameObject.tag == "Ingrediente"){
			live.total_live +=20;
			Destroy(col.gameObject);
		}
	}*/

}
