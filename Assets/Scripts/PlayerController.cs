using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    public bool isPlayerDead = false;

    [SerializeField] float verticalSpeed = 10f;
    [SerializeField] float horizontalInputSpeed = 10f;
    

    Rigidbody rb;
    CharacterAnimation charAnim;
    

    public Transform target;
    

    
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        charAnim = GetComponent<CharacterAnimation>();
        
        if (!Manager.isGameStarted )
        {
            charAnim.Idle(true);
            return;
        }
    }

    void Update()
    {
        if (Manager.isGameStarted && !isPlayerDead   )
        {
            
            
            float xMovement = Input.GetAxis("Horizontal") * horizontalInputSpeed * Time.deltaTime;
            float newXPos = Mathf.Clamp(transform.position.x + xMovement, Constants.LEFT_BOUNDARY, Constants.RIGHT_BOUNDARY);
            transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);
           

            rb.velocity = new Vector3(0, rb.velocity.y, verticalSpeed);
            
            
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stick"))
        {
            charAnim.Jump();
            Debug.Log("Zıpla");
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            charAnim.Fall();
            Debug.Log("Düş");
        }

        else if (other.gameObject.CompareTag("Stick"))
        {
            charAnim.Jump();
            Debug.Log("Zıpla");
            
        }

        else if (other.gameObject.CompareTag("JumpTower")) 
        {
            
            charAnim.TowerJump();
            

        }

       
        
        

        

        

    }
}

