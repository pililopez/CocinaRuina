using UnityEngine;
using System.Collections;

public class ControlEnemigos : MonoBehaviour {
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);
	public AudioClip aparece;
	public float amplitudeY=1.0f;
	public float omegaY=1.0f;
	public int puntos = 1;
	public float velocidad = 5;
	public GameObject golpe;
	private float goRight = -1f;
	private float goUp = -1f;
	//private bool destruido = false;	
	private float index;
	private Vector2 movement;
	private Vector2 mov_old;
	private ParticleSystem particle;
	private GameControl total_puntos;
	public bool destroyed = false;

	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint(aparece, transform.position);
		var daño = transform.Find ("Parti_limon");
		particle = (ParticleSystem)daño.GetComponent ("Parti_limon");
		particle.enableEmission = false;
	}
	
	// Update is called once per frame
	/*void Update () {
	
		RaycastHit2D hit = Physics2D.Raycast(transform.position, goUp * transform.up, 0.5f, 1 << LayerMask.NameToLayer("Limite"));
		Debug.DrawRay(transform.position, goUp * transform.up, Color.red);
		
		if (hit) { 
			
			Vector3 localx = new Vector3 (transform.localScale.x * -1, transform.localScale.y * -1, transform.localScale.z);
			transform.localScale = localx;
			goRight *= -1;
		}
		index += Time.deltaTime;
		float x = speed.x * direction.x;
		float y = amplitudeY*Mathf.Sin (omegaY*index);
		mov_old = movement;
		movement = new Vector2 (x, y);
	}*/
	void FixedUpdate(){
		if (!destroyed) {
			rigidbody2D.velocity = movement;
			Vector2 v2 = new Vector2 (goRight * velocidad, goUp * velocidad);
			rigidbody2D.velocity = v2;
				} 
		}
	void OnCollisionEnter2D(Collision2D col){

	if (col.gameObject.tag == "Margen") {
		Vector3 localx = new Vector3(transform.localScale.x * -1,transform.localScale.y,transform.localScale.z );
		transform.localScale = localx ;
		goRight *= -1;
		goUp *= -1;
		}

	}
}
