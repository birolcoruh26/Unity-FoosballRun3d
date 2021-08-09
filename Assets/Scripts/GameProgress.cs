using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameProgress : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform EndLine;
    [SerializeField] UnityEngine.UI.Slider slider;
    float maxDistance;
    private void Start()
    {
        maxDistance = getDistance();
    }
    private void Update()
    {
        if(Player.position.z<=maxDistance && Player.position.z <= EndLine.position.z)
        {
            float distance = 1 - (getDistance() / maxDistance);
            setProgress(distance);

        }
    }
    float getDistance()
    {
        return Vector3.Distance(Player.position, EndLine.position);
    }
    void setProgress(float p)
    {
        slider.value = p;
    }
}
