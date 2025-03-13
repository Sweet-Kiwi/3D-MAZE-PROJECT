using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using TMPro;
public class PlayerCollection : MonoBehaviour

{
    //ADD A SCORING SYSTEM HERE (HW)
    private int score = 0;
    public TMP_Text scoreText;
    
    
    //only destroy if collectable
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void AddScore(int points)
    {
        score = score + points;
            //score += points is the same thing
            scoreText.text = $"<b>Score:</b> {score}";
    }
}
