using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialForce = 3f;
    private Rigidbody rigid;
    public Player player;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.one * initialForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && collision.gameObject)
        {
            collision.gameObject.GetComponent<EnemyController>().Destroy();
        }
    }

    public void ResetBall()
    {

    }

}
