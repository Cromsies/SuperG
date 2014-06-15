using UnityEngine;
using System.Collections;
//using EnemySpawn; 
//using System.Collections.Generic;

public class Enemy1Move : MonoBehaviour
{
    public Transform startMarker;
    public Transform midPoint1;
	public Transform midPoint2;


    public Transform endMarker;
    
    public float speed = 0.1f;
	public Transform ebullets;
    public Transform currentTarget = null;
    public Animator anim = null;
    

    public bool shooting = false;
   

    private void Start()
    {
        anim = GetComponent<Animator>();
        currentTarget = midPoint1;
    }

        IEnumerator MyMethod() 
	{
        shooting = true;
        GameObject.Instantiate(ebullets, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3);
        shooting = false;
        
	}
  


    void Update()
    {
        if(currentTarget != null) // this is required because i used the null to stop the shakey effect.
            transform.position += (currentTarget.position - transform.position).normalized * speed * Time.deltaTime;
        // normalized takes two points on a large vector and simplifies it to 0-1.
        //transform.position = Vector3.Lerp(transform.position, currentTarget.position, speed * Time.deltaTime  );
        
        if (currentTarget == null )
            Idle();


        if (transform.position == startMarker.position)
            currentTarget = midPoint1;

        
        
    }

    private void Next()
    {
   
		if (currentTarget == midPoint1)
            currentTarget = midPoint2;
        else if (currentTarget == midPoint2)
            currentTarget = endMarker;
       

			return;
          
    }

    private void Idle()
    {
        if (anim != null)
            anim.SetBool("Idle", true);
		if(!shooting)
            StartCoroutine(MyMethod());


    }



    private void OnTriggerEnter(Collider c)
    {
        //Debug.Log(c.name + " | " + currentTarget.name);
		if (currentTarget !=null)
			if (c.name == currentTarget.name)
		{				
			Transform shot = Instantiate(ebullets, transform.position, Quaternion.identity) as Transform;

			Next();
		}

		if (c.name == endMarker.name)
            currentTarget = null;
        if (c.name == midPoint1.name)
            currentTarget = midPoint2;
	
       
        
       

    }
}