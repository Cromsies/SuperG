using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
	
	public int health = 100;
	//public Component[] enemies;

	
	void Update()
	{
		if (health < 1)
			Destroy(gameObject);
		

	}
	
	
	public void damage()
	{
		health = health - 100;
	}
	
	void OnTriggerEnter(Collider c)
	{
		if ( c.tag == "ebullet")
			damage();
		
	}
	
}
