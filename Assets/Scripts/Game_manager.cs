using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour {

    // Use this for initialization
    private bool gameEnded = false;

    public GameObject gameOverUI;  

	void Update () {
        if (PlayerStats.Lives > 0)
        {
            PauseMenu.gameoverUI = false;
        }
        if (gameEnded)
            return;

        if (PlayerStats.Lives <= 0)
        {
            if (PlayerController.D == true){
                EndGame();
                Time.timeScale = 0f;
            }
        }
	}

    void EndGame ()
    {
        gameEnded = true;
        PauseMenu.gameoverUI = true;
        gameOverUI.SetActive(true);
        Destroy(GameObject.FindWithTag("Player"));
    }
}