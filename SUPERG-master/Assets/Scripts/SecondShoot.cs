using UnityEngine;
using System.Collections;

public class SecondShoot : MonoBehaviour 
{
	public Transform Bbullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftAlt))
			{
				Transform shot = Instantiate(Bbullet, transform.position, Quaternion.identity) as Transform;
			shoot.shotCounter = shoot.shotCounter + 1;
			}
	}


}
