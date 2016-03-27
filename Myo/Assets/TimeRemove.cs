using UnityEngine;
using System.Collections;

public class TimeRemove : MonoBehaviour {
    float time = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    time -= Time.deltaTime;
        if(time < 0)
        {
            Destroy(this.gameObject);
        }
	}
}
