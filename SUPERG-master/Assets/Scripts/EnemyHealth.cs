﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int health = 100;
	//public Component[] enemies;
	public GameObject enemies;
	public Material colorChange;
	void Awake()
	{

		enemies = GameObject.Find("Enemy");
	}
	
	void Update()
	{
		if (health < 1)
			Destroy(gameObject);

		foreach (Transform child in enemies.transform)
		{
			child.gameObject.renderer.material = colorChange;
		}



		if(health > 101)
			colorChange.color = Color.blue;
		else 
			colorChange.color = Color.red;
		/*enemies = GetComponentsInChildren<Renderer>();
		foreach (var r in enemies)
			r.material.color = Color.red;*/
	

	}


	public void damage()
	{
		health = health - 100;
	}

	void OnTriggerEnter(Collider c)
	{
		if ( c.tag == "bullet")
			damage();

	}

}
