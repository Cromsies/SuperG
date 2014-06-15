using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
    public Transform Bbullet;
    public static float shotCounter;
    //public bullet Bbullet;
    public static float accuracy;
    //public int hitCounter;
    
    void Start()
    {
       //Bbullet = GetComponent<bullet>();
        if (shotCounter > 0)
            accuracy = (bullet.hitCounter / 2) / shotCounter;

    }
    
    void Update()
    {
       
        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Transform shot = Instantiate(Bbullet, transform.position, Quaternion.identity) as Transform;
            shotCounter++;
        }
        if (shotCounter > 0)
        accuracy = (bullet.hitCounter/2) / shotCounter;

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(bullet.hitCounter / 2 * 100 + "= Your Score");
            Debug.Log(accuracy);
        }
        
    }
 



    }



