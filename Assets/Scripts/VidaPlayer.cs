using UnityEngine;
using System.Collections;

public class VidaPlayer : MonoBehaviour {

	public int total_vida = 3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		guiText.text = ""+ total_vida;//cambiar por imagen

		if (total_vida <= 0) {
			Application.LoadLevel ("menu");
		}
		
	}
	
}

