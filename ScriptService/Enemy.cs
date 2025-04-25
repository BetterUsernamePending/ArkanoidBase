using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject lastbrick;

    private void OnCollisionEnter(Collision collision)
    {
        lastbrick = collision.gameObject;
        if (collision.gameObject.tag == "Ball" && collision.gameObject != lastbrick)
        {
            collision.gameObject.GetComponent<EnemyController>().Destroy();
        }
    }

    public void ResetEnemy()
    {

    }
}