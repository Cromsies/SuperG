using UnityEngine;
using System.Collections;

public class PickUps : MonoBehaviour 
{
	public Rotater pissOff;

	void Start()
	{
		Destroy(gameObject, 5);
		Rotater.allowance = false;
	}
	
	void Update()
	{
		transform.Translate(0, -0.1f, 0);
	
	}
void OnTriggerEnter(Collider c)
{

	
	if(c.tag == "Player")
	{
		
			Rotater.allowance = true;
			pissOff.powerUp();
			Destroy(gameObject);
	
	}
}
}

