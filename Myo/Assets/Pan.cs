using UnityEngine;
using System.Collections;
using VibrationType = Thalmic.Myo.VibrationType;

public class Pan : MonoBehaviour {

    public GameObject myo;
    public GameObject scoreObj;
    private ThalmicMyo myoScript;

    void Start()
    {
        myoScript = myo.GetComponent<ThalmicMyo>();
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Sushi")
        {
            myoScript.Vibrate(VibrationType.Short);
            Destroy(other.gameObject);
            scoreObj.GetComponent<Score>().score++;
        }
    }
}
