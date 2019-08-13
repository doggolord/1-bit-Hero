using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour {

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
