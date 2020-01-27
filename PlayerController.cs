using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //General Variables
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Collider playerCollider;
    [SerializeField] private float distToGround;

    //Movement Variables
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private Vector2 movementVector;

    //Camera Variables
    [SerializeField] private Camera cam;

    //Rotation Variables
    [SerializeField] private Vector3 desiredMoveDirection;
    [SerializeField] private bool blockRotationPlayer = false;
    [SerializeField] private float desiredRotationSpeed = 0.1f;
    [SerializeField] private float Speed;
    [SerializeField] private float allowPlayerRotation = 0.1f;

    //Animator Variables 
    public Animator anim;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        cam = Camera.main;
        playerCollider = gameObject.GetComponent<Collider>();
    }

    void Start()
    {
        distToGround = playerCollider.bounds.extents.y;
    }

    private void Update()
    {
        //Movement Code BEGIN
        if (movementVector != Vector2.zero)
        {
            InputMagnitude();
        }

    }

    public void Move(Vector2 movement)
    {
        movementVector = movement;
    }

    private void PlayerMovement()
    {
        float InputX = movementVector.x;
        float InputZ = movementVector.y;

        var camera = Camera.main;
        var forward = cam.transform.forward;
        var right = cam.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        desiredMoveDirection = forward * InputZ + right * InputX;
        desiredMoveDirection = new Vector3(desiredMoveDirection.x * 0.1f, desiredMoveDirection.y * 0.1f, desiredMoveDirection.z * 0.1f);

        if (blockRotationPlayer == false)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), desiredRotationSpeed);
        }

        transform.Translate(desiredMoveDirection, Space.World);
        
    }

	void InputMagnitude() {
        //Calculate Input Vectors
        float InputX = movementVector.x;
        float InputZ = movementVector.y;

		//anim.SetFloat ("InputZ", InputZ, VerticalAnimTime, Time.deltaTime * 2f);
		//anim.SetFloat ("InputX", InputX, HorizontalAnimSmoothTime, Time.deltaTime * 2f);

		//Calculate the Input Magnitude
		Speed = new Vector2(movementVector.x, movementVector.y).sqrMagnitude;

		//Physically move player
		//if (Speed > allowPlayerRotation) {
			//anim.SetFloat ("InputMagnitude", Speed, StartAnimTime, Time.deltaTime);
			PlayerMovement();
		//} else if (Speed < allowPlayerRotation) {
			//anim.SetFloat ("InputMagnitude", Speed, StopAnimTime, Time.deltaTime);
		//}
	}

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }
}