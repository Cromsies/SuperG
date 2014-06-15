using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int health = 100;
	//public Component[] enemies;
	public GameObject enemies;
	public Material colorChange;
	public Transform Respawn;
    //public Animator deadAnim = null;
    
    public GameObject enemyDeath = null;

    IEnumerator spawnDelay()
    {
        
        yield return new WaitForSeconds(3);
        health = 200;
        yield break;
    }
	void Awake()
	{
		enemies = GameObject.Find("Enemy");
	}
    void Start()
    {
       // deadAnim = GetComponent<Animator>();
    }
    
	void Update()
	{
        if (health < 1)
            transform.position = Respawn.position;
                 
                    StartCoroutine(spawnDelay());
     

	}


	public void damage()
	{
		health = health - 100;

        if (health <= 0)
            
            dead();
	}

	void OnTriggerEnter(Collider c)
	{
        if (c.tag == "bullet")
			damage();

	}

    private void dead()
    {
        
        // Do this before you move your invader back
        Destroy(Instantiate(enemyDeath, transform.position, enemyDeath.transform.rotation), 0.4f);
           
        
        
    }
}
