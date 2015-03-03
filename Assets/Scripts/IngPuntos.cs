using UnityEngine;
using System.Collections;

public class IngPuntos : MonoBehaviour {
	public AudioClip LevelUp;
	public static bool dead;
	public int puntos =1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.transform.tag == "Player") {
			AudioSource.PlayClipAtPoint (LevelUp, transform.position);
			GameControl.gamecontrol.total_puntos = GameControl.gamecontrol.total_puntos + puntos;
			Destroy (gameObject);
		} 
		else {
			Destroy (gameObject, 5);
		}
	}
}
