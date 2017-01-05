using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    int currentLevel;
    // Use this for initialization
    void Start () {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameLoader();
        }
	}

    void gameLoader()
    {
        if (currentLevel == 2)
            currentLevel = -1;
        SceneManager.LoadScene(currentLevel + 1);

    }
}
