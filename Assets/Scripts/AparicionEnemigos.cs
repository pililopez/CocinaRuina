using UnityEngine;
using System.Collections;

public class AparicionEnemigos : MonoBehaviour {
	Vector2 pos;
	float maxposx =9.30f;
	float minposx = -9.30f;
	float maxposy = 6.15f;
	float minposy = -6.15f;
	public float spawnTime=24f;
	public float spawnDelay=1f;
	public GameObject[] enemies;
	public int maxEnemies=8;
	
	private GameObject[] enemiesCreated;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreaEnemigo", spawnDelay, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {}
	void CreaEnemigo (){
		pos = new Vector2 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy));
		int enemyIndex=Random.Range(0, enemies.Length);
		enemiesCreated = GameObject.FindGameObjectsWithTag("Enemigo");
		if (enemiesCreated.Length < maxEnemies){
		Instantiate (enemies [enemyIndex], pos, transform.rotation);
			}
			
		}
	
}
