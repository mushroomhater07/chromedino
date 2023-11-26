using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float gravity, jumpForce, jumping, jumpgravity;
    private bool jumpflag, upright;
    void Start()
    {
        gravity = GetComponent<Rigidbody2D>().gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravity > 0) upright = true;
        else upright = false;

        if (Input.GetKey(KeyCode.Space))
        {
            jumping = jumpForce;
            jumpflag = true;
        }

        if (jumpflag && Time.timeScale != 0)
        {
            if (upright)
            {
                if (transform.position.y < -3f)
                {
                    jumpflag = false;
                    transform.position = new Vector3(transform.position.x, -3f, transform.position.z);
                }
                else
                {
                    Vector3 newPos = gameObject.transform.position;
                    jumping -= Mathf.Sqrt(jumpgravity * Mathf.Pow(Time.deltaTime, 2));
                    transform.position = new Vector3(newPos.x, newPos.y + jumping, newPos.z);
                }
            }
            else
            {
                if (transform.position.y > 3.3f)
                {
                    jumpflag = false;
                    transform.position = new Vector3(transform.position.x, 3.3f, transform.position.z);
                }
                else
                {
                    Vector3 newPos = gameObject.transform.position;
                    jumping -= Mathf.Sqrt(jumpgravity * Mathf.Pow(Time.deltaTime, 2));
                    transform.position = new Vector3(newPos.x, newPos.y - jumping, newPos.z);
                }
            }



            
        }if (Input.GetKey(KeyCode.E))
        {
            FindObjectOfType<Camera>().transform.Rotate(new Vector3(0,0,180f));
            gravity *= -1;Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 1;
        }
        gameObject.GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}
