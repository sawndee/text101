using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

	// Use this for initialization
	public Text text;
	void Start () {
		text.text = "hi";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
		text.text = "You are in prison, you are tired of butt rape, " +
					"you have decided you must escape before your " +
					"cellmate wakes up.  He feels most frisky in the " +
					"morning.  You look around your cell.  There is a " +
					"bed, a mirror and a door that leads outside to the hall. \n\n" +
					"Press S for sheets, M for mirror, or D for Door";
		}
	}
}
