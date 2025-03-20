using System;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
    public EndScreenAnimation winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //turns player off
            other.gameObject.SetActive(false);
            winScreen.StartFade();
        }
    }
}
