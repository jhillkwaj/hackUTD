using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
    public GameObject myo;
    public GameObject velocityPoint;
    public Vector3 velocity;
    float power;
    Vector3 lastPos;

    void Start()
    {
        lastPos = velocityPoint.transform.position;
    }

    void FixedUpdate()
    {
        velocity = Vector3.Lerp(velocity, velocityPoint.transform.position - lastPos, .8f);
        lastPos = velocityPoint.transform.position;
        power = Vector3.Magnitude(velocity);
    }

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (power > 1.2f)
        {
            GameObject newObj = Instantiate(Resources.Load("Explosion", typeof(GameObject))) as GameObject;
            newObj.transform.position = other.transform.position;
        }
        //Destroy(other.gameObject);
        other.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(this.transform.position - other.transform.position) * -3000 * power);
        other.GetComponent<Rigidbody>().angularVelocity = Vector3.Normalize(this.transform.position - other.transform.position) * -14 * power;

    }
}
