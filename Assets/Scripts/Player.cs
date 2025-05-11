using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f ;
    [SerializeField]
    private float jumpForce = 11f ;
    private float movementX ;
    private Rigidbody2D myBody ; 
    private SpriteRenderer sr ;
    private Animator anim ;
    private string WALK_ANIMATION = "Walk" ;

    private bool isGrounded = true ;
    private string GROUND_TAG = "Ground" ;

    private string ENEMY_TAG = "Enemy";
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>(); 
    }

    void Start()
    {

    }

    
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
       
    }

    void FixedUpdate()
    {
       
    }

    void PlayerMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX , 0f , 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer(){
        // anim.SetBool(WALK_ANIMATION , true );

        if (movementX > 0){
            //we are going to the right side 
            anim.SetBool(WALK_ANIMATION , true );
            sr.flipX = false ;
        }  
        else if (movementX<0){
            //we are going to the left side
            anim.SetBool(WALK_ANIMATION , true );
            sr.flipX = true;

        } 
        else{
            //we are staying there 
            anim.SetBool(WALK_ANIMATION , false );
        }
    }


    void PlayerJump(){
        if (Input.GetButtonDown("Jump") && isGrounded ){
            isGrounded = false ;
            myBody.AddForce(new Vector2(0f , jumpForce) , ForceMode2D.Impulse) ; 

       }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG)){
            isGrounded = true ;
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG)){
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.CompareTag(ENEMY_TAG)){
            Destroy(gameObject);  
    }




} }//class
 