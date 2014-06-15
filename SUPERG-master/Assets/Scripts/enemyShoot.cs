using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {


	public Transform ebullets;

	void Update () 
	
	{
	
		if(Input.GetKeyDown(KeyCode.J))
		{
			Transform shot = Instantiate(ebullets, transform.position, Quaternion.identity) as Transform;
		}
	}
}
