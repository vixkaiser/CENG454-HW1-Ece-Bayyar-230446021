// FlightController.cs
// CENG 454 - HW1: Sky-High Prototype
// Author: [Ece Bayyar] | Student ID: [230446021]

using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] float pitchSpeed = 45f; //degrees/second
    [SerializeField] float yawSpeed = 45f; //degrees/second
    [SerializeField] float rollSpeed = 45f; //degrees/second
    [SerializeField] float thrustSpeed = 5f; //units/second

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        // TODO (Task 3-C) :
        // Pitch
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * pitchSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-Vector3.right * pitchSpeed * Time.deltaTime);
        }
        
        // Roll
    }

    private void HandleThrust()
    {
        // TODO (Task 3-D) :
    }
}
