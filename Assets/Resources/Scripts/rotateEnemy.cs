using UnityEngine;
using System.Collections;

public class rotateEnemy : MonoBehaviour
{
	public GameObject enemy;
	public int speed;
	public Vector3 vec;
	public GameObject player;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		enemy.transform.Rotate (vec * speed * Time.deltaTime);
	
	}
}
