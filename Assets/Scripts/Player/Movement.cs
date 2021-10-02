using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5.0f;
    [SerializeField] private Vector3 _jump = new Vector3(0f, 5.0f, 0f);
    [SerializeField] private float _jumpMultiplier = 1.0f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal();
        Jump();
    }
    private void moveHorizontal()
    {
        if (Input.GetButton("Horizontal"))
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(horizontalInput, 0, 0) * _moveSpeed * Time.deltaTime);
        }
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(_jump * _jumpMultiplier, ForceMode.Impulse);
        }
    }
}
