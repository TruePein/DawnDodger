using UnityEngine;
using System.Collections;

public class UpdateScore : MonoBehaviour {
    GUIText text;
    int score;

	// Use this for initialization
	void Start () {
        text = GetComponent<GUIText>();
        score = 0;
        UpdatePoints();
	}
	
	// Update is called once per frame
	void UpdatePoints () {
        text.text = "Score: " + score;
	}

    public void AddScore(int i)
    {
        score += i;
        UpdatePoints();
    }
}
