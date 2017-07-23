using UnityEngine;
using System.Collections;

public class CreateFireBall : MonoBehaviour {
    private GameObject fireBall;
    public Transform start;
    public Transform end;
    public float speed;
    private float startTime;
    private float jorneyLength;
    GameObject ball;



    // Use this for initialization
    void Start () {
       // startTime = Time.time;
       // jorneyLength = Vector3.Distance(start.position, end.position);
       // fireBall = Resources.Load("Prefabs/fireBall") as GameObject;
       //// ball = Instantiate(fireBall, start.position, Quaternion.identity) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {


        


    }



    //IEnumerator instance()
    //{
       
    //    yield return new WaitForSeconds(5);
    //    GameObject ball = Instantiate(fireBall, start.position, Quaternion.identity) as GameObject;
    //    float distCovered = (Time.time - startTime) * speed;
    //    float fractJorney = distCovered / jorneyLength;
    //    ball.transform.position = Vector3.Lerp(start.position, end.position, fractJorney);


    //}



    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Destroy(c.gameObject);
        }
    }


}
