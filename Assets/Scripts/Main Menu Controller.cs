using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void PlayGame(){

        int selectedCharacter = 
        int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
         
        GameManager.instance.CharIndex = selectedCharacter;
        
        SceneManager.LoadScene("Gameplay");
    }


} //class


//chatgpt code -
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class MainMenuController : MonoBehaviour
// {
//     // This method will be called when the Orange player button is clicked
//     public void SelectOrangePlayer()
//     {
//         GameManager.instance.CharIndex = 0;  // Set character index to 0 for Orange player
//         Debug.Log("Orange player selected!");
//         SceneManager.LoadScene("Gameplay");   // Load Gameplay scene
//     }

//     // This method will be called when the Black player button is clicked
//     public void SelectBlackPlayer()
//     {
//         GameManager.instance.CharIndex = 1;  // Set character index to 1 for Black player
//         Debug.Log("Black player selected!");
//         SceneManager.LoadScene("Gameplay");   // Load Gameplay scene
//     }
// }
