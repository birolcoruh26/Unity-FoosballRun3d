using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickLerp : MonoBehaviour
{
    [SerializeField]
    private Transform startMarker;
    [SerializeField]
    private Transform endMarker;

    [SerializeField]
    private float stickSpeed;
    [SerializeField]
    private float journeyLength;
    [SerializeField]
    private float startTime;

    public bool loop = false;

    void Update()
    {
        if (!loop)
        {
            float distcovered = (Time.time - startTime);
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, distcovered / journeyLength);

        }

        if (loop)
        {
            float distCovered = Mathf.PingPong(Time.time - startTime, journeyLength / stickSpeed);
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, distCovered / journeyLength);
        }
    }
}
