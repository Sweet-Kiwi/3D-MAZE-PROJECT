using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerCollection : MonoBehaviour
{
    //ADD A SCORING SYSTEM HERE (HW)
    //only destroy if collectable
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }
    }
    
}
