using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

//OTE = OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }
    }

    //to remove some health points
    private void Damage(int value)
    {
        points = points - value;
        if (points < 1)
        {
            //do not destroy, move the player to the start and reset points to 5
            Destroy(gameObject);
        }
    }

}
