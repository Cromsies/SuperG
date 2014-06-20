using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 10.0f;

    
    void FixedUpdate()
    {
        rigidbody.velocity = Vector3.zero;
        
		{if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.right * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.left * Speed * Time.deltaTime;
		}

		var pos = transform.position; 


		pos.x = Mathf.Clamp (transform.position.x, -14.0f, 14.0f);

		transform.position = pos;
        
        /*
                float translation = Input.GetAxis("Horizontal") * Speed;

                translation *= Time.deltaTime;

                //Rigidbody transform;
                transform.Translate(translation *-1,0,0);
              */
    }
	void OnTriggerEnter (Collider c)
	{
		var pos = transform.position;
		if(c.tag == "Pickup")
			pos.x = Mathf.Clamp (transform.position.x, -15.0f, 15.0f);

	}
}