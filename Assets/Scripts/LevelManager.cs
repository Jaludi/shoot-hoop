using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    int currentLevel;
    public float timeTillNextLevel = 0f;
    // Use this for initialization
    void Start () {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
       

    }
	
	// Update is called once per frame
	void Update () {

        if (timeTillNextLevel > 0) {
            timeTillNextLevel -= Time.deltaTime;
        
            if (timeTillNextLevel <= 0)
                loadGameOver();
        }
        
    }
    public void mainLoad()
    {
        
        SceneManager.LoadScene(0);
    }
    public void levelLoader()
    {
        
        SceneManager.LoadScene(1);

    }
    public void loadInstruction()
    {
        SceneManager.LoadScene(3);
    }
    public void loadGameOver()
    {
        SceneManager.LoadScene(2);
    }
}
