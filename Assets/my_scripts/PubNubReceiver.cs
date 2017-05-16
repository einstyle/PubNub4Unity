using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PubNubMessaging.Core;

public class PubNubReceiver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Pubnub pubnub = new Pubnub("demo", "demo");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
