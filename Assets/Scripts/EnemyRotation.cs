using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] 
    [Range(0f, 6f)] float lerpTime;

    [SerializeField] 
    Vector3[] myAngels;

    int angleIndex;
    int len;

    float t = 0f;

    void Start()
    {
        len = myAngels.Length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler(myAngels[angleIndex]),lerpTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);

        if (t > .9f)
        {
            t = 0f;
            angleIndex = Random.Range(0, len - 1);
        }
    }
}
