using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    public Canvas canvas;  
    public int blockSize = 35; //define the city's block size in meters

    // UI Elements
    public TextMeshProUGUI backwardsForceText;
    public TextMeshProUGUI positionText;
    public TextMeshProUGUI rotationText;

    public TMP_InputField posXInputField;
    public TMP_InputField posYInputField;
    public TMP_InputField rotInputField;

    public int inputCoordX = 0;
    public int inputCoordY = 0;
    public float inputRot = 0;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        //UI updates
        backwardsForceText.text = "Backwards Force (I & O) = " + player.GetComponent<PlayerController>().backwardsStepForce;
        positionText.text = "POS (X,Z) = " + player.transform.position.x.ToString("F2") + "," + player.transform.position.z.ToString("F2") + ")";
        rotationText.text = "ROT (Y) = " + player.transform.rotation.eulerAngles.y.ToString("F2"); //display rotation in euler angles with two digits
    }

    public void UpdateCoordinates()
    {
        Debug.Log(posXInputField.text);
        inputCoordX = int.Parse(posXInputField.text);
        inputCoordY = int.Parse(posYInputField.text);
        inputRot = float.Parse(rotInputField.text);

    }

}
