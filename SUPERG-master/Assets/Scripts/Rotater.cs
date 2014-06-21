using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour 
{

	public float spawnSpeed = 20.0f; 
	private float spawnTimer = 0.0f;
	public GameObject pU = null;

	public void newPowerUp()
	{
		spawnTimer = 0.0f;
		Instantiate(pU, transform.position, transform.rotation);

	}
	/*
	IEnumerator delay()
	{

		spawnTimer = 0.0f;
		yield return new WaitForSeconds(8);
		newPowerUp();
		yield break;
	}*/

void Update()
	{

	
		spawnTimer += Time.deltaTime; 
		if (spawnTimer >= spawnSpeed)
		{
			newPowerUp();
		}

	}


}
