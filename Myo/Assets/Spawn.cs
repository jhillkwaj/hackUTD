using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    float spawnTime = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if(spawnTime < 0)
        {
            spawnTime = 1;
            GameObject newObj1 = Instantiate(Resources.Load("Sushi", typeof(GameObject))) as GameObject;
            newObj1.GetComponent<Rigidbody>().velocity = new Vector3((float)(Random.value - .5) * 18, (float)(Random.value - .5) * 18, 0);
            newObj1.transform.rotation = Quaternion.Euler(Random.insideUnitSphere * 90);
            newObj1.transform.position= new Vector3(0, 10, 1.18f);
            
        }
	}
}
