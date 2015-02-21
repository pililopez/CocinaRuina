using UnityEngine;
using System.Collections;

public class AparicionEnemigos : MonoBehaviour {

	public float spawnTime=1f;
	public float spawnDelay=1f;
	public GameObject[] enemies;
	public int maxEnemies=4;
	
	private GameObject[] enemiesCreated;
	// Use this for initialization
	void Start () {
	InvokeRepeating ("DispensEnemigos", spawnDelay, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {}
	void CreaEnemigo (){
		int enemyIndex=Random.Range(0, enemies.Length);
		enemiesCreated = GameObject.FindGameObjectsWithTag("Enemigo");
		if (enemiesCreated.Length < maxEnemies){
		Instantiate (enemies [enemyIndex], transform.position, transform.rotation);
			}
			
		}
	
}
