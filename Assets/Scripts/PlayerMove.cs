using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 100f;
    public float jumpForce = 0.5f;
    public float jumpDecelerationRate = 0.0005f;
    public float jumpCap;
    public bool isJump = false;

    public CharacterController Controller;
    public Transform Cam;

    public AK.Wwise.Event jumpEvent;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        jumpCap = (jumpForce * -1);// + this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        Vector3 Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;
        //Debug.Log(Movement);
        Movement.y = 0f;

        Controller.Move(Movement);

        //Debug.Log(Movement.magnitude);
        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 750 * Time.deltaTime);

            Quaternion CamRotation = Cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;

            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);
        }

        if (Input.GetKey(KeyCode.Space) && !isJump)
        {
            //Debug.Log("jump");
            isJump = true;
            jumpEvent.Post(gameObject);
        }

        if (isJump)
        {
            Vector3 Jump = new Vector3(0, jumpForce, 0);
            Controller.Move(Jump);
            if (jumpForce <= jumpCap)
            {
                isJump = false;
                jumpForce *= -1;
            }
            else
            {
                jumpForce -= jumpDecelerationRate;
            }
            //Debug.Log(jumpForce);
        }
    }
}
