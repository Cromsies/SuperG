using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour 
{

	//public Transform currentTarget = null;
	//public Transform pathNode1 = null;
	//public Transform pathNode2 = null;
	//public GameObject Pickup = null;
	//public float speed = 0.1f;
	public GameObject pU = null;
	public GameObject secondShip = null;
	public Transform shipPosition = null;
	public static bool allowance = false;
	private bool dogShit = false;
	public void powerUp ()
	{
		Instantiate(secondShip, shipPosition.position, Quaternion.identity);


	}
	public void newPowerUp()
	{
		allowance = false;
		Instantiate(pU, transform.position, Quaternion.identity);
	}

	IEnumerator delay()
	{
		allowance = false;
		yield return new WaitForSeconds(8);
		newPowerUp();

	}

void Update()
	{

		//if(currentTarget != null) // this is required because i used the null to stop the shakey effect.
		//	transform.position += (currentTarget.position - transform.position).normalized * speed * Time.deltaTime;
		if(allowance != false)
		dogShit = true;
		if(dogShit != false)
		StartCoroutine(delay());
	
		/*if(currentTarget == pathNode1)
			currentTarget = pathNode2;
		if(currentTarget == pathNode2)
			transform.position = pathNode1.position;
*/

		//transform.Rotate(new Vector3(10, 30, 45) * Time.deltaTime); // fancy way to make the axis rotate 
	}

	/*void next()
	{
		if (currentTarget == pathNode1)
			currentTarget = pathNode2;
		if (currentTarget == pathNode2)
		{
			delay();
		}

	}*/
}
