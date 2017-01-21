using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 10, 20, 40, 30, 90 };

		//順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//逆順に表示
		for (int i = array.Length - 1; i >= 0; i--) {
			Debug.Log (array [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
