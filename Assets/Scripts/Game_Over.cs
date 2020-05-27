using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour {

    public void Retry()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Cursor.visible = true;
    }
}
