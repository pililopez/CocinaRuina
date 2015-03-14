
using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	//Este script sirve para objetos q deban aparecer en todas las escenas
	public int total_puntos = 0;
	public int total_vida = 3;
	
	public static GameControl gamecontrol;
	
	void Awake(){
		if (gamecontrol == null) {
			gamecontrol = this;
			DontDestroyOnLoad (gameObject);
		} else if (gamecontrol != this) {
			Destroy (this);
		}
	}
	
	public void Level2(){
		Application.LoadLevel ("fase2");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (total_puntos > 50) {
			total_puntos = -50 ;
			total_vida = (total_vida + 1);
		}
		if (total_puntos < 0) {
			total_puntos = +50 ;
			total_vida = (total_vida - 1);
		}
	
	}
}
