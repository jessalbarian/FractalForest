﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMusic : MonoBehaviour {

    public AudioSource plantBeat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Target"){
            plantBeat.Play();
            //Destroy(collision.gameObject);
        //)
    }
}
