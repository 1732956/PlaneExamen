using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationÉlice : MonoBehaviour {


    private float RotationSpeed;

    public void SpeedRotation(float Speed)
    {
        RotationSpeed = Speed;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(3,0,0), RotationSpeed * 200);
    }

    
}
