using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager Manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Manager.LevelComplete();
        }
    }
}
