using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed ;

    private Rigidbody2D myBody ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       myBody = GetComponent<Rigidbody2D> ();
       speed = 7 ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.linearVelocity= new Vector2(speed , myBody.linearVelocityY) ;
    }
} //class
