using UnityEngine;
using System.Collections;

public class AparicionEnemigos : MonoBehaviour {
	Vector2 pos;
	float maxposx =1.91 f;
	float minposx = -1.91f;
	float maxposy = 3.59f;
	float minposy = -3.59f;
	public float spawnTime=1f;
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
