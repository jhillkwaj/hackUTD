using UnityEngine;
using System.Collections;

public class Center : MonoBehaviour {
    double health = 4.5;
    public AudioClip hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y < -12)
        {
            if (this.transform.position.x < -4)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Abs(this.GetComponent<Rigidbody>().velocity.x), this.GetComponent<Rigidbody>().velocity.y, 0);
            this.transform.position = new Vector3(-4, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x > 4)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(-Mathf.Abs(this.GetComponent<Rigidbody>().velocity.x), this.GetComponent<Rigidbody>().velocity.y, 0);
            this.transform.position = new Vector3(4, this.transform.position.y, this.transform.position.z);
        }
        
            this.transform.position = new Vector3(0, 6.18f, 1.18f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        try
        {
            AudioSource.PlayClipAtPoint(hit, Camera.main.transform.position);
            float power = Vector3.Magnitude(other.GetComponent<Hit>().velocity) * .7f;
            for (int i = 0; i < power * 3; i++)
            {
                GameObject newObj1 = Instantiate(Resources.Load("Sushi", typeof(GameObject))) as GameObject;
                newObj1.GetComponent<Rigidbody>().velocity = new Vector3((float)(Random.value - .5) * 18, (float)(Random.value - .5) * 18, 0);
                newObj1.transform.rotation = Quaternion.Euler(Random.insideUnitSphere * 90);
                newObj1.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 1.18f);
            }
            health -= power;
            if (health <= 0)
            {

                GameObject newObj = Instantiate(Resources.Load("ShowWhale", typeof(GameObject))) as GameObject;
                newObj.transform.position = new Vector3(0, -6.43f, 25f);
                //newObj.transform.position = new Vector3(0, 6.18f, 1.18f);

                for (int i = 0; i < 6; i++)
                {
                    GameObject newObj1 = Instantiate(Resources.Load("Sushi", typeof(GameObject))) as GameObject;
                    newObj1.GetComponent<Rigidbody>().velocity = new Vector3((float)(Random.value - .5) * 18, (float)(Random.value - .5) * 18, 0);
                    newObj1.transform.rotation = Quaternion.Euler(Random.insideUnitSphere * 90);
                    newObj1.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 1.18f);
                }

                Destroy(this.gameObject);

            }
        }
        catch (System.Exception e)
        { }
    }
}
