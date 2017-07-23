using UnityEngine;
using System.Collections;

public class Trap1 : MonoBehaviour {

	



    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            //Destroy(c.gameObject); 
            c.gameObject.transform.position = new Vector3(4,2,0);

        }
    }
}
