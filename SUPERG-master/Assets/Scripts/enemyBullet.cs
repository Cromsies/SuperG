using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour 

{
	void Start()
	{
		Destroy(gameObject, 1);
	}
	
	void Update()
	{
		transform.Translate(0, 0, 1);
	}
	private void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{

			//Destroy(c.gameObject);
			Destroy(gameObject);
			
			Debug.Log(c.transform.position);
		}
	}
}