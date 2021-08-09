using UnityEngine;

public class Stick : MonoBehaviour
{
   // CharacterAnimation charAnim;

    private void Awake()
    {
        //charAnim = GetComponent<CharacterAnimation>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().velocity += new Vector3(0, Constants.JUMP_AMOUNT, 0);

            Destroy(gameObject.GetComponent<Collider>()); 
        }
    }

}
