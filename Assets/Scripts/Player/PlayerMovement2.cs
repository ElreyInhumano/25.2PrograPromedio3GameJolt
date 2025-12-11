using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed, jumpForce;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    void Update()
    {
        PlayerMoves();
    }

    void PlayerMoves()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(h, v);
        direction.Normalize();
        rb.linearVelocity = new Vector3(-direction.y, 0, direction.x) * speed + Vector3.up * rb.linearVelocity.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0) * speed * 5f, ForceMode.Force);
        }
    }
}
