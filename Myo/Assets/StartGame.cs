using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public GameObject startObj;
    public GameObject sword;
    public GameObject pan;

    public bool start = true;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space)){
            if (start)
            {
                sword.GetComponent<JointOrientation>().outsideRefrenceUpdate = true;
                pan.GetComponent<PanOrientation>().outsideRefrenceUpdate = true;
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
