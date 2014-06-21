using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{

    public static int hitCounter;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.Translate(0, 0, -1);
       
    }
	private void OnTriggerEnter(Collider c)
	{
	
        
        if (c.tag != "Player" && c.tag != "ebullet")
		{
            hitCounter++;
            //Destroy(c.gameObject);
			Destroy(gameObject);
			
			//Debug.Log(c.transform.position);
		}
	}
}