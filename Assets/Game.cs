using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	static float timer = 0f;
	public bool canShoot = true;
	public GameObject Explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Cetak Waktu
		timer = timer + Time.deltaTime;
		float a = GameObject.Find ("Player").GetComponent<Player> ().health.CurrentAmmo;

		//Cek Bisa tembak atau tidak
		if (a <= 0) {
			canShoot = false;
		} else {
			canShoot = true;
		}

		//Untuk Tembak
		if(Input.GetMouseButtonDown(0)) GameObject.Find ("Player").GetComponent<Player> ().doShoot ();
		if (Input.GetMouseButtonDown (1)) 
		{
			var enemys = GameObject.FindGameObjectsWithTag("Enemy");
			foreach(var enemy in enemys)
			{
				Destroy(enemy);
				GameObject explosion = (GameObject)Instantiate (Explosion);
				explosion.transform.position = enemy.transform.position;
			}

			var items = GameObject.FindGameObjectsWithTag("Item");
			foreach(var item in items)
			{
				Destroy(item);
				GameObject.Find ("Player").GetComponent<Player> ().getAmmo ();
			}
		}
		//if (timer >= 2f && timer <= 2.4f) {
		//	GameObject.Find ("Enemy_0").transform.position = new Vector3(0, -3, 0);
		//	GameObject.Find ("Enemy_0").GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 5);
		//}
	}
}
