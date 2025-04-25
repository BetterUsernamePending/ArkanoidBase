using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int destroypoints;
    [SerializeField] public int CurrentBricks = 0;


    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void EnemyDestroyed()
    {
        CurrentBricks--;
        destroypoints += 100;
        if (CurrentBricks <= 0)
        {
            Debug.Log("WIN");
            //Posteriormente, usa UI
        }
    }
}