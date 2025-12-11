using UnityEngine;

public class FloorUp : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed, jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.AddForce(new Vector3(0, jumpForce, 0) * speed * 5f, ForceMode.Impulse);
    }
    void Update()
    {
    }
}
