using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour 

{
    public float speed = 0.4f;
	void Start()
	{
		Destroy(gameObject, 3);
	}
	
	void Update()
	{
		transform.Translate(0, 0, speed);
	}
	private void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{

			//Destroy(c.gameObject);
			Destroy(gameObject);
			
			//Debug.Log(c.transform.position);
		}
	}
}