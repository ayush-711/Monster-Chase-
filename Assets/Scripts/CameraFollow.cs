using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player ;
    private Vector3 tempPos ;

    [SerializeField]
    private float minX , maxX ;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player ==null){
            return ;
        }
        tempPos = transform.position;
        tempPos.x = player.position.x ;

        if (tempPos.x < minX){
            tempPos.x = minX;
        }

        if ( tempPos.x > maxX){
            tempPos.x = maxX;
        }

        transform.position = tempPos ;
    }
} //class


//chatgpt code - 
// using UnityEngine;
// using System.Collections;  // For using IEnumerator and Coroutines

// public class CameraFollow : MonoBehaviour
// {
//     private Transform player;  // The player object to follow
//     private Vector3 tempPos;   // Temporary position for camera movement

//     [SerializeField]
//     private float minX, maxX;  // X-axis limits for camera movement

//     void Start()
//     {
//         // Start the coroutine to find the player object
//         StartCoroutine(FindPlayer());
//     }

//     // Coroutine to find the player object in the scene
//     private IEnumerator FindPlayer()
//     {
//         // Keep checking until the player object is found
//         while (GameObject.FindWithTag("Player") == null)
//         {
//             yield return null;  // Wait for the next frame
//         }

//         // Once the player is found, get the player's transform component
//         player = GameObject.FindWithTag("Player").transform;
//     }

//     // Update the camera position after the player has been found
//     void LateUpdate()
//     {
//         // If player is still not found, return
//         if (player == null)
//         {
//             return;
//         }

//         // Set the camera's x position to match the player's x position
//         tempPos = transform.position;
//         tempPos.x = player.position.x;

//         // Clamp the camera's position within the specified limits
//         if (tempPos.x < minX)
//         {
//             tempPos.x = minX;
//         }

//         if (tempPos.x > maxX)
//         {
//             tempPos.x = maxX;
//         }

//         // Update the camera's position
//         transform.position = tempPos;
//     }
// }

