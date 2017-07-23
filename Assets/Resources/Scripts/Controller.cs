using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class Controller : MonoBehaviour {

    private float horizontal;
    public int moveSpeed = 10;
    public int jumpForce = 200;
    private bool isJumping = true; 
    Rigidbody rb;

    int coinCount = 0;
    public Text coinCounterUI;  

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	
	}


    void Update()
    {
        coinCounterUI.text = "Coins: " + coinCount; 

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //horizontal = Input.GetAxis("Horizontal");
        //Vector3 movement = new Vector3(horizontal, 0.0f, horizontal);
        //rb.AddForce(movement * moveSpeed);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.World);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.World);

        }



        //if (Input.GetButtonDown("Jump"))
        //{
        //    rb.AddForce(new Vector3(0, jumpForce, 0));
        //    isJumping = true;
        //    Debug.Log("Key Press" + Input.GetKeyDown(KeyCode.W));
        //}

        
        if (Input.GetKey(KeyCode.W))
        {

            if (isJumping == false)
            {
                rb.AddForce(new Vector3(0, jumpForce, 0));

                isJumping = true;
                
                //transform.Translate(Vector3.up * jumpForce * Time.deltaTime, Space.World);

            }
           


        }



    }


    void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == "Platform")
        {
            isJumping = false; 
        }

    

    }


    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Coins"))
        {
            Destroy(c.gameObject);
            //Debug.Log("coin collected");
            coinCount++;
           // Debug.Log("My coins: " + coinCount); 

        }
    }



}
