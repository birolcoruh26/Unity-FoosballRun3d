using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ThrowTheBalls(0);
            StartCoroutine(WaitForGameOver());
        }
        else if (other.gameObject.CompareTag("MovingBall"))
        {
            int collidingBallIndex = BallManager.balls.IndexOf(other.transform);
            ThrowTheBalls(collidingBallIndex);

            if (BallManager.balls.Count.Equals(0))
            {
                //Düşme animasyonu
                StartCoroutine(WaitForGameOver());
            }
        }
    }

    private void ThrowTheBalls(int index)
    {
        int length = BallManager.balls.Count;

        for (int i = length - 1; i >= index; i--)
        {
            Transform currentBall = BallManager.balls[i];

            Destroy(currentBall.GetComponent<BallMovement>());
            Destroy(currentBall.GetComponent<Collider>());

            currentBall.GetComponent<Rigidbody>().velocity = GenerateRandomThrowingForce();
            Destroy(currentBall.gameObject, 3f);

            BallManager.balls.RemoveAt(i);
        }
    }

    private Vector3 GenerateRandomThrowingForce()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(30f, 40f);
        float randomZ = Random.Range(-40f, -25f);
        return new Vector3(randomX, randomY, randomZ);
    }

    IEnumerator WaitForGameOver()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<CharacterAnimation>().Fall();
        player.GetComponent<PlayerController>().isPlayerDead = true;
        yield return new WaitForSeconds(3f);
        Manager.gameOver = true;
    }

}
