using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIcontroller : MonoBehaviour
{
    public void RestartGame(){
        // SceneManager.LoadScene("GamePlay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton(){
        SceneManager.LoadScene("MainMenu");
    }


}


