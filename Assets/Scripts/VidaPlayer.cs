using UnityEngine;
using System.Collections;

public class VidaPlayer : MonoBehaviour {

	public int total_live = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		guiText.text = "Vida: "+ total_live;
		if (total_live <= 0) {
			Application.LoadLevel ("Menuinicio");
		}
		
	}
	
}

