using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {
	public GameObject tutScreen = null;

    void Start()
    {
        Time.timeScale = 0;
	}

    private void turnoffStart()
    {
		Instantiate(tutScreen, transform.position, Quaternion.identity);
        gameObject.SetActive(false);

    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            turnoffStart();

        return;
	}
}
