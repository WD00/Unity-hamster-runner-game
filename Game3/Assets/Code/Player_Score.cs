using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    public int score;    
    public Text scr;


    private void Update(){

	scr.text = score.ToString();

}

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Obstacle")){

		score++;
		Debug.Log(score);

}
    }
}
