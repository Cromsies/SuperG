using UnityEngine;
using System.Collections;

public class PickUps : MonoBehaviour 
{
	public Rotater pissOff;
	public GameObject secondShip = null;
	public Transform shipPosition = null;
	
	
	public void powerUp ()
	{
		Instantiate(secondShip, shipPosition.position, Quaternion.identity);
		
		
	}
	void Start()
	{

		Destroy(gameObject, 6);
		//Rotater.allowance = false;
	}
	
	void Update()
	{
		transform.Translate(0, -0.1f, 0);
	
	}
void OnTriggerEnter(Collider c)
{

	
	if(c.tag == "Player")
	{
		

	powerUp();
	Destroy(gameObject);
	
	}
}
}

