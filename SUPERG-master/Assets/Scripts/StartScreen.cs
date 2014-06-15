using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

    void Start()
    {
        Time.timeScale = 0;
	}

    private void turnoffStart()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

	void Update ()
    {
        if (Input.anyKeyDown)
            turnoffStart();

        return;
	}
}
