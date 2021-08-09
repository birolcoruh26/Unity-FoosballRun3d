using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static List<Transform> balls = new List<Transform>();

    void Awake()
    {
        balls.Add(FindObjectOfType<BallMovement>().transform); // ilk top BallMovement scriptine sahip olduğundan onu listeye ekliyoruz.
    }
}
