using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour
{

    
	public Transform startLocation;
	public Transform endLocation;
	bool animState;
	public float speed;
	float timeStart;
	float jLength;


	void Start ()
	{
		animState = true;
		speed = 1.0F;
		timeStart = Time.time;
		jLength = Vector3.Distance (startLocation.position, endLocation.position);
        
	
	}
	
	// Update is called once per frame
	void Update ()
	{

        
	}

	void OnTriggerEnter (Collider c)
	{
		if (c.CompareTag ("Player")) {
			transform.position = endLocation.position;
			//transform.position = Vector3.Lerp(startLocation.position, endLocation.position, Time.deltaTime);
		}
	}
}
