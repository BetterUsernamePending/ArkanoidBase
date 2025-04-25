using UnityEngine;

public class Player : MonoBehaviour
{
    private float vel = 25f;
    private int LimitMove = 13;

    public void ResetPlayer()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        float dirInput = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(dirInput * vel * Time.deltaTime, 0f, 0f);
        float ClampPosX = Mathf.Clamp(transform.position.x, -LimitMove, LimitMove);
        transform.position = new Vector3(ClampPosX, transform.position.y, transform.position.z);

    }



}
