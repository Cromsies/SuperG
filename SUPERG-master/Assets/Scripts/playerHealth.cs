using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{

    public int health = 200;
    //public Component[] enemies;
    public GameObject gameOver;
    public GameObject stats;
    public Vector3 statPopup;
    public GameObject playerDeath = null;
    public static bullet Bullet;
    
    


    public Vector3 Center;// =new Vector3(0.1558609, 0.4 , -11.97797);

    void Awake()
    {
        renderer.enabled = true;
        
        
    }

    private void Start()
    {
        bullet.hitCounter = 0;
    }

    IEnumerator gameDelay()
    {
      //  Debug.Log("this should be popping up");

        yield return new WaitForSeconds(0.5f);
        Destroy(Instantiate(stats, statPopup, Quaternion.identity), 5.0f);
        
        
        yield return new WaitForSeconds(5);
        GameObject.Instantiate(gameOver, Center, Quaternion.identity);
        
        yield break;
    }

    public void damage()
    {
        health = health - 100;
        if(health < 1)
        {
            pDead();
           
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "ebullet")
            damage();

    }
    private void pDead()
    {
        // this destroys the instantiated prefab "playerDeath" after .4 seconds
        renderer.enabled = false;
        collider.enabled = false;
        Destroy(Instantiate(playerDeath, transform.position, playerDeath.transform.rotation), 0.4f);
        

        StartCoroutine(gameDelay());
    }
}
