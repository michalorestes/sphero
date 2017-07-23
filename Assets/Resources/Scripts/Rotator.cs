using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public int rotationSpeed; 

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(rotationSpeed, 0, 0) * 10 * Time.deltaTime); 

	
	}
}
