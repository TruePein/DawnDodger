using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
    int points = 10;
    public UpdateScore score;
	// Use this for initialization
	void Start () {
        GameObject Score = GameObject.FindWithTag("Score");
        if (Score != null)
        {
            score = Score.GetComponent<UpdateScore>();

            score.AddScore(points);
        
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    void OnTriggerEnter2D()//Collision col
    {
      //  if (col.gameObject.tag.Equals( "Player") )
        //{
            ScoreManager.Score += points;
            Debug.Log("Entered trigger.");
            Destroy(GetComponent<SpriteRenderer>());
            Destroy(this);
        //}
       
    }
}
