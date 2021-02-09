using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.Utilities;

/**
 * SIMPLE PLAYER CONTROLLER
 * 
 * horizontal input = move
 * vertical input = rotate
 * 
 */

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f; //Player's walking speed
    public float lookSpeed = 50.0f; //Player's turning speed
    public int backwardsStepForce = 400;

    private readonly int xRange = 350; // Ground plane size (x-axis) * 10
    private readonly int yRange = 350; // Ground plane size (y-axis) * 10

    private Camera playerCamera;
    private Rigidbody playerRb;
    //private PlayerControl _controls;

    public Vector3 startPosition; //Used to reset to initial position
    public Vector3 startRotation; //User to reset to initial rotatin
    public Vector2 inputVec;

    public Vector3 currentRotation; //Player's current rotation
    private Vector3 moveVec;

    public float horizontalInput; //Value of horizontal input
    public float verticalInput; //Value of vertical input

    public bool tookStep = false;

    private void Awake()
    {
       // _controls = new PlayerControl();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main; //Set playerCamera to camera with 'main'tag
        playerRb = GetComponent<Rigidbody>();

        //Record start position and rotation
        startPosition = transform.position;
        startRotation = transform.eulerAngles;

        currentRotation = startRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //PLAYER INPUT

       horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");
    

        if (verticalInput > 0)
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
            tookStep = false;
        }
        else if (verticalInput < 0 && !tookStep)
        {
            tookStep = true;
            playerRb.AddRelativeForce(Vector3.back * backwardsStepForce, ForceMode.Impulse);
        }

        currentRotation.y += horizontalInput * Time.deltaTime * lookSpeed;
        transform.eulerAngles = new Vector3(0, currentRotation.y, 0);

        if (Input.GetKeyDown(KeyCode.Alpha0))    //Return to start 
        {
            transform.position = startPosition;
            currentRotation = startRotation;
            
            //ADD WAIT until you can move again

        }

        //Change the backwards force
        if (Input.GetKeyDown(KeyCode.I) && (backwardsStepForce > 100))
        {
            backwardsStepForce -= 10;
        }
        if (Input.GetKeyDown(KeyCode.O) && (backwardsStepForce < 700))
        {
            backwardsStepForce += 10;
        }

        #region Location Shortut
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(0, 1, 245);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = new Vector3(245, 1, 245);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position = new Vector3(245, 1, 105);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            transform.position = new Vector3(385, 1, 105);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            transform.position = new Vector3(385, 1, -140);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            transform.position = new Vector3(140, 1, -140);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            transform.position = new Vector3(140, 1, 0);
        }
        #endregion



        //Limit player's movement to the plane
        //if (transform.position.x < 0)
        //{
        //    transform.position = new Vector3(0, transform.position.y, transform.position.z);
        //}
        //if (transform.position.z < 0)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        //}
    }
    void OnMove(InputValue input)
    {
        //_controls.Player.Move.performed += cntx => inputVec = cntx.ReadValue<Vector2>();
       // _controls.Player.Move.canceled += cntx => inputVec = Vector2.zero;

        //Vector2 inputVec = new Vector2();
        ////InputValue input,
        //inputVec = input.Get<Vector2>();
        //verticalInput = inputVec.y;
        //horizontalInput = inputVec.x;

        //float inputV = input.Get<float>();
        //verticalInput = inputV;
    }

    void OnRotate(InputValue input)
    {
        //float inputH = input.Get<float>();
        //horizontalInput = inputH;
    }

    //void OnBackwardsForce(InputValue input)
    //{
    //    float inputFloat = input.Get<float>();
    //    if (inputFloat > 0)
    //    {
    //        backwardsStepForce += 10;
    //    }
    //    else
    //    {
    //        backwardsStepForce -= 10;
    //    }
    //}
}
