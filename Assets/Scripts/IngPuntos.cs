using UnityEngine;
using System.Collections;

public class IngPuntos : MonoBehaviour {
	public AudioClip LevelUp;
	public static bool dead;
	float resetTimer = 0 ; 
	public int puntos =1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (Time.time > resetTimer && !total_vida){
			AudioSource.PlayClipAtPoint(LevelUp, transform.position);
			resetTimer = Time.time + 3;
			total_puntos = total_puntos + puntos;
			//Debug.Log ("LevelUp;" + GameControl.score);
			Destroy (gameObject);
		}
		
	}
}
