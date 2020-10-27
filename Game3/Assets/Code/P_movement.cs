using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class P_movement : MonoBehaviour
{
    private Vector2 PPosition;
    public float UpValue;

    public float howFast;
    public float MaxY;
    public float MinY;

    public int health = 3;

    public GameObject effect;
    public Text hp;
    public GameObject g_o;

    private void Update()
    {

	hp.text = health.ToString();

    	if (health <= 0) {

		g_o.SetActive(true);
		Destroy(gameObject);

}

	transform.position = Vector2.MoveTowards(transform.position, PPosition, howFast * Time.deltaTime);
        
	if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxY){

		Instantiate(effect,transform.position, Quaternion.identity);
		PPosition = new Vector2(transform.position.x, transform.position.y + UpValue);
		
}

	else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinY){

		Instantiate(effect,transform.position, Quaternion.identity);
		PPosition = new Vector2(transform.position.x, transform.position.y - UpValue);
		
}

    }
}
