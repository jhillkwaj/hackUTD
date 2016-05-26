using UnityEngine;
using System.Collections;

public class Pan : MonoBehaviour {

    public GameObject myo;
    public GameObject scoreObj;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Sushi")
        {
            Destroy(other.gameObject);
            scoreObj.GetComponent<Score>().score++;
        }
    }
}
