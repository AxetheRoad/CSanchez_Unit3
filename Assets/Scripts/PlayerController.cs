using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;
    public float gravityModifier;
    public float jumpForce;
    private bool onGround = true;
    public bool gameOver = true;
    // Start is called before the first frame update
    void Start()
    {
      rbPlayer = GetComponent<Rigidbody>();
      Physics.gravity *= gravityModifier;
       // Physics.gravity = Physics.gravity * gravityModifier; Same as top one


    }

    // Update is called once per frame
    void Update()
    {
        bool spaceDown = Input.GetKeyDown(KeyCode.Space);

        if(spaceDown & onGround)
        {
           rbPlayer.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;

        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
        }
    }
}
