using UnityEngine;
using System.Collections;

public class PickUps : MonoBehaviour 
{
	public GameObject secondShip = null;
	public Transform shipPosition = null;
	
	public  void powerUp ()
	{
		Instantiate(secondShip, shipPosition.position, Quaternion.identity);
	
	}
	public void newPowerUp()
	{
		Instantiate(gameObject, transform.position, Quaternion.identity);
	}
	IEnumerator delay()
	{
		yield return new WaitForSeconds(8);
		newPowerUp();


	}
	void Start()
	{
		Destroy(gameObject, 5);
	}
	
	void Update()
	{
		transform.Translate(0, -0.1f, 0);
		if(secondShip != null)
		StartCoroutine(delay());
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

