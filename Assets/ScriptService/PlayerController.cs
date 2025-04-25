using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int life = 3;
    private PlayerController player;
    

    void Start()
    {
        player = FindAnyObjectByType<PlayerController>();
    }

    public void LoseLife()
    {
        life--;
        if (life <= 0)
        {
            //Lost
        }
        else
        {
            //Reset
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.LoseLife();
        }
    }


    void Update()
    {
        
    }
}
