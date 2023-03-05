using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    int jumpcnt = 0; //counting how many jumps are already triggered before landing

    [SerializeField] float ms;

    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void MoveCharacterOnGround()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalInput * ms, rb.velocity.y, verticalInput * ms);
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacterOnGround();
    }
}