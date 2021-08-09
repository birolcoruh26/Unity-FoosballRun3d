using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager manager;
    void OnTriggerEnter()
    {
       manager.CompleteLevel();
    }
    
}
