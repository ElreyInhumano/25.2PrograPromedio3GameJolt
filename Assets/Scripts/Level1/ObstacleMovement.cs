using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed, jumpForce, dmgForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(new Vector3(jumpForce, 0, 0) * speed * 5f, ForceMode.Acceleration);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rbp = collision.gameObject.GetComponent<Rigidbody>();
            rbp.AddForce(new Vector3(dmgForce, 0, 0) * speed * 5f, ForceMode.Impulse);
        }
    }
}
