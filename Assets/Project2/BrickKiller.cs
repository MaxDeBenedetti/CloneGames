using UnityEngine;
using System.Collections;

public class BrickKiller : MonoBehaviour {
	
	
	
	public int brickCount = 2;
	
	public TextMesh scoreText;
	public TextMesh highScoreText;
	
	
	
	private int scoreNum =0;
	private int highScoreNum =0;
	
	
	
	// Use this for initialization
	void Start () {
		
		highScoreNum = PlayerPrefs.GetInt("BrickBreakHighScore",0);
		scoreText.text= "Score: " + (scoreNum);
		highScoreText.text = "High Score: " + highScoreNum;
	}
	
	// Update is called once per frame
	void Update () {
	if(brickCount <= 0){
			Application.LoadLevel("BrickBreak");	
		}
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.rigidbody != null){//only bricks and the ball are rigid bodies
			scoreText.text= "Score: " + (++scoreNum);
			if(scoreNum > highScoreNum){
				highScoreNum = scoreNum;
				highScoreText.text = "High Score: " + highScoreNum;
				PlayerPrefs.SetInt("BrickBreakHighScore",highScoreNum);
			}
			brickCount--;
		}
			
	}
}
