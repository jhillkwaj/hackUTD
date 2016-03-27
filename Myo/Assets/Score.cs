using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public int score = 0;
    public double time = 100;

    public GameObject gameOver;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score + "\nTime: " + Mathf.RoundToInt((float)time) + "\n";

        if(time < 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
	}
}
