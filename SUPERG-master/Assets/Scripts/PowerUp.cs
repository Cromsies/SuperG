using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour 
{

	public GameObject secondShip = null;
	public Transform shipPosition = null;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	


		
	}

	public  void powerUp ()
	{

		Instantiate(secondShip, shipPosition.position, Quaternion.identity);
	}
}
