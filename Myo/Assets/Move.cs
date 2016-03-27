using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 15, -20);	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < 0)
        {
            //spawn new whale
            GameObject newObj = Instantiate(Resources.Load("Whale", typeof(GameObject))) as GameObject;
            newObj.transform.position = new Vector3(0, 6.18f, 1.18f);

            Destroy(this.gameObject);
        }
    }

   
}
