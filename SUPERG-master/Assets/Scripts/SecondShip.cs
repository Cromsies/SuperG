using UnityEngine;
using System.Collections;

public class SecondShip : MonoBehaviour
{
	public Transform Bbullet;
	private int health = 300;
	public GameObject ssDeath = null;
	public static Rotater makeWork;
	public float Speed = 10.0f;
	// Use this for initialization
	public static bool goodGo = false;
	void Start () 
	{
		goodGo = true;
	}
	void FixedUpdate()
	{
		rigidbody.velocity = Vector3.zero;
		
		{if (Input.GetKey(KeyCode.A))
			transform.position += Vector3.right * Speed * Time.deltaTime;
			if (Input.GetKey(KeyCode.D))
				transform.position += Vector3.left * Speed * Time.deltaTime;
		}
		
		var pos = transform.position; 
		
		
		pos.x = Mathf.Clamp (transform.position.x, -15.0f, 13.0f);
		
		transform.position = pos;
	}
	// Update is called once per frame


	private void damage()
	{
		health = health - 100;
		if (health < 1)
		{
			goodGo = false;
			Destroy(gameObject, 0.4f);
			Destroy(Instantiate(ssDeath, transform.position, ssDeath.transform.rotation), 0.4f);
		}
	}
	public void OnTriggerEnter(Collider c)
	{
		if(c.tag == "ebullet")
			damage();
	}
}
