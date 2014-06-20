using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour 
{

	public Transform currentTarget = null;
	public Transform pathNode1 = null;
	public Transform pathNode2 = null;
	//public GameObject Pickup = null;
	public float speed = 0.1f;

	public GameObject secondShip = null;
	public Transform shipPosition = null;
	public static bool allowance = false;

	public  void powerUp ()
	{
		Instantiate(secondShip, shipPosition.position, Quaternion.identity);
		allowance = true;
	}

	IEnumerator delay()
	{

		currentTarget = pathNode1;
		yield return new WaitForSeconds(8);

		gameObject.renderer.enabled = true;
	
		next();
		yield break;
	}

void Start()
	{
	
			StartCoroutine(delay());

	}

void Update()
	{

		if(currentTarget != null) // this is required because i used the null to stop the shakey effect.
			transform.position += (currentTarget.position - transform.position).normalized * speed * Time.deltaTime;

	
		/*if(currentTarget == pathNode1)
			currentTarget = pathNode2;
		if(currentTarget == pathNode2)
			transform.position = pathNode1.position;
*/

		transform.Rotate(new Vector3(10, 30, 45) * Time.deltaTime); // fancy way to make the axis rotate 
	}
void OnTriggerEnter(Collider c)
	{
		if (currentTarget !=null)
			if(c.name == currentTarget.name){
			next();}
	

		if(c.tag == "Player")
		{
			powerUp();

			gameObject.renderer.enabled = false;
			currentTarget = pathNode1;
		}
	}

	void next()
	{
		if (currentTarget == pathNode1)
			currentTarget = pathNode2;
		if (currentTarget == pathNode2)
		{
			delay();
		}

	}
}
