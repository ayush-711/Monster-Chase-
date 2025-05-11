using UnityEngine;
using UnityEngine.SceneManagement ;

public class GameManager : MonoBehaviour
{
    public static GameManager instance ;

    [SerializeField]
    private GameObject[] characters ;

    private int _charIndex ;
    public int CharIndex{
        get{return _charIndex;}
        set{ _charIndex = value ;}
    }

    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    private void OnEnable() {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable() {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    private void OnLevelFinishedLoading(Scene scene , LoadSceneMode mode){

        if ( scene.name == "GamePlay"){
            Instantiate (characters[CharIndex]);

            // GameManager.instance.CharIndex = 0; // for orange
            // GameManager.instance.CharIndex = 1; // for black

        }
    }
}


//chatgpt code - 
//     private void OnLevelFinishedLoading(Scene scene , LoadSceneMode mode)
// {
//     if (scene.name == "Gameplay")
//     {
//         Debug.Log("Instantiating player with CharIndex: " + CharIndex);
//         GameObject player = Instantiate(characters[CharIndex]);
//         Debug.Log("Player instantiated: " + player.name);
//         player.transform.position = new Vector3(0, 0, 0);  // Adjust as needed
//     }
// }


  
// } //class
