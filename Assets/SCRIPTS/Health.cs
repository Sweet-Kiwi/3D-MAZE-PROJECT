using UnityEngine;
using TMPro;
public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;
    public EndScreenAnimation gameOverScreen;
    
    private void Start()
    {
        respawnPosition = transform.position;
    }

    //OTE = OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }

        if (other.CompareTag("Fireball"))
        {
            Damage(2);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("CheckPoint"))
        {
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;
        }
    }

    //to remove some health points
    private void Damage(int value)
    {
        points = points - value;
        //$ = helps interpolate the point
        healthText.text = $"<b>Health:</b> {points}";
        
            //do not destroy, move the player to the start and reset points to 5
            transform.position = respawnPosition;
           // points = 5;
            if (points < 1)
        {
            gameOverScreen.StartFade();
           Destroy(gameObject);
        }
    }

}
