using UnityEngine;

public class CollectableBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("MovingBall"))
        {
            if (!BallManager.balls.Count.Equals(0))
            {
                gameObject.tag = "MovingBall";
                transform.position = BallManager.balls[BallManager.balls.Count - 1].position + new Vector3(0, 0, Constants.BALL_OFFSET);

                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                gameObject.GetComponent<SphereCollider>().isTrigger = false;
                gameObject.GetComponent<SphereCollider>().radius = Constants.SPHERE_RADIUS;    // toplarkenki radius ile aynı olursa bu satıra gerek yok.

                BallManager.balls.Add(transform);  // listeye bu topu ekliyoruz

                if (!gameObject.GetComponent<BallMovement>())
                {
                    gameObject.AddComponent<BallMovement>();
                }

                Destroy(this);
            }
        }
    }
}
