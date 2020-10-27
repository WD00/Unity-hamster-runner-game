using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour{

    
    public GameObject[] boxPatterns;

    private float beforeSp;
    public float startBeforeSp;
    public float stoppingTime;
    public float minTime = 0.70f;



    private void Update(){
    
        if (beforeSp <= 0){

		int rand = Random.Range(0, boxPatterns.Length);
		Instantiate(boxPatterns[rand], transform.position, Quaternion.identity);
		beforeSp = startBeforeSp;
		if (startBeforeSp > minTime){
			startBeforeSp -= stoppingTime;
}

	}
   	else {
    	
        	beforeSp -= Time.deltaTime;
    	}
    }
}
