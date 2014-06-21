using UnityEngine;
using System.Collections;

public class TutScreen : MonoBehaviour {

	void Start()
	{

		Time.timeScale = 0;
	}
	
	private void turnoffStart1()
	{
		gameObject.SetActive(false);
		Time.timeScale = 1;
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			turnoffStart1();
		
		return;
	}
}
