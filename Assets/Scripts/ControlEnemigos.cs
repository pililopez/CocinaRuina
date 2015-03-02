using UnityEngine;
using System.Collections;

public class ControlEnemigos : MonoBehaviour {
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);
	public AudioClip aparece;
	public int puntos = 1;
	public float velocidad = 5;
	private float goRight = -1f;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint(aparece, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
		RaycastHit2D hit = Physics2D.Raycast(transform.position, goRight * transform.right, 0.7f, 1 << LayerMask.NameToLayer("Limite"));
		Debug.DrawRay(transform.position, goRight * transform.right, Color.red);
		
		if (hit) { 
			
			Vector3 localx = new Vector3 (transform.localScale.x * -1, transform.localScale.y * -1, transform.localScale.z);
			transform.localScale = localx;
			goRight *= -1;
		}
	}
	void OnCollisionEnter2D(Collision2D col){

	if (col.gameObject.tag == "Margen") {
		Vector3 localx = new Vector3(transform.localScale.x * -1,transform.localScale.y,transform.localScale.z );
		transform.localScale = localx ;
		goRight *= -1;
		}

	}
}
