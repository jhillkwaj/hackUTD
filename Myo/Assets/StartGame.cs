using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public GameObject startObj;
    public GameObject sword;
    public GameObject pan;

    public bool start = true;
    public AudioClip sound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    if(true){
            
            if (start)
            {
                AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
                startObj.SetActive(true);
                Destroy(this.gameObject);
            }
            else
            {
                Time.timeScale = 1.0f;
                SceneManager.LoadScene(SceneManager.sceneCount - 1);
            }
        }
	}
}
