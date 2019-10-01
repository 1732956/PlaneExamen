using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour {
    Rigidbody rbd;
    public int TrustFACTOR = 5000;
    public int RelationFactor = 5000;
    public ParticleSystem Fume;
    RotationÉlice MonÉlice;
    // Use this for initialization
    void Start () {
        rbd = gameObject.GetComponent<Rigidbody>();
        MonÉlice = gameObject.GetComponentInChildren<RotationÉlice>();
        
    }
	
	// Update is called once per frame
	void Update () {
        MonÉlice.SpeedRotation(rbd.velocity.magnitude);
        if (Input.GetAxis("Jump") != 0)
        {
            Fume.Play();
            rbd.AddRelativeForce(new Vector3(Input.GetAxis("Jump") * TrustFACTOR * Time.deltaTime, 0, 0));
        }
        else
        {
            Fume.Stop();
        }

        if (Input.GetAxis("Horizontal") != 0)
        {

            rbd.AddForceAtPosition(new Vector3(Input.GetAxis("Horizontal") * RelationFactor, 0, 0), new Vector3(0, 50, 0));
        }
    }
}
