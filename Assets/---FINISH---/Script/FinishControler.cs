using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishControler : MonoBehaviour
{
    
    
    

  

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("MovingBall"))
        {
            int collidingBallIndex = BallManager.balls.IndexOf(other.transform);
            DestroyTheBall(collidingBallIndex);
            Debug.Log(collidingBallIndex);
            //Destroy(this);

           



        }else if (other.gameObject.CompareTag("Player"))
        {


            Debug.Log("KARAKTER CARPTIMI ?");

            StartCoroutine(WaitforCheerUp(other));
            Debug.Log("Buraya geldimi");
            other.gameObject.GetComponent<CharacterAnimation>().CheerUp();
            



        }
        
    }

    private void DestroyTheBall(int index)
    {
        int length = BallManager.balls.Count;
        Debug.Log("ball triger count"+length);
            if (length==1)
            {
                Debug.Log("Toplar yok edildi");
            }
        for (int i = length-1; i >= index; i++)
        {
            Transform currentBall = BallManager.balls[i];
            Debug.Log("Finish çizgisi ile çarpıştım.");

          // Destroy(currentBall.GetComponent<BallMovement>());
          //  Destroy(currentBall.GetComponent<Collider>());

           
            Destroy(currentBall.gameObject);
            Debug.Log("topu yok ettim"+currentBall.gameObject);
            
            BallManager.balls.RemoveAt(i);


        }
    }

    IEnumerator WaitforCheerUp(Collider other)
    {   other.gameObject.GetComponent<CharacterAnimation>().Run(false);
        yield return new WaitForSeconds(2f);
        Debug.Log("start corotuine çalışıyormu ?");

        other.gameObject.GetComponent<CharacterAnimation>().CheerUp();
        

       
    }
}
