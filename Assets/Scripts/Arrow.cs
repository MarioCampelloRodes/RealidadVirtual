using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Crossbow") && !other.CompareTag("Player"))
        {
            rb.linearVelocity = Vector3.zero;
            rb.useGravity = false;
        }
    }
}
