using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour {


	public float myTime = 0f;
	public Transform RadialProgress;

	// Use this for initialization
	void Start () {
		RadialProgress.GetComponent<Image> ().fillAmount = myTime;
	}
	
	// Update is called once per frame
	void Update () {

		myTime += Time.deltaTime;
		RadialProgress.GetComponent<Image> ().fillAmount = myTime/2;
		if (myTime >= 2f) {
			objectSelector ();
		}

	}


	public void objectSelector(){
		Destroy (gameObject);
		RadialProgress.GetComponent<Image> ().fillAmount = 0;
	}

	private void OnDestroy(){
		Instantiate (Resources.Load ("PickUpEffects"), transform.position, transform.rotation);
	}

	public void Reseteador(){
		myTime = 0f;
		RadialProgress.GetComponent<Image> ().fillAmount = 0f;
	}
}
