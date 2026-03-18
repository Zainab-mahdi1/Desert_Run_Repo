using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody rb;
    public float xInput, zInput;
    public float maxSpeed; 
    [SerializeField] bool isRunning;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSpeed = 2.0f;
        maxSpeed = 5.0f;
        rb = GetComponent<Rigidbody>();
        xInput = 0.0f;
        zInput = 0.0f;

    }

    // Update is called once per frame

    void OnMove(InputValue movementValue)
    {
                Vector2 movementVector = movementValue.Get<Vector2>();
                xInput = movementVector.x;
                zInput = movementVector.y;

    }
    void Update()

{
    if (isRunning == false)
        {
            isRunning = true;
            StartCoroutine(AddDistance());
        }
    Vector3 movement = new Vector3(xInput, 0f, 1f + zInput);
    rb.AddForce(movement * playerSpeed);

    Vector3 horizontalVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
    if (horizontalVelocity.magnitude > maxSpeed)
    {
        Vector3 clamped = horizontalVelocity.normalized * maxSpeed;
        rb.linearVelocity = new Vector3(clamped.x, rb.linearVelocity.y, clamped.z);

    }


}

    IEnumerator AddDistance()
        {
            yield return new WaitForSeconds(0.35f);
            MasterInfo.distanceRun += 1;
            isRunning = false;
        }
}

