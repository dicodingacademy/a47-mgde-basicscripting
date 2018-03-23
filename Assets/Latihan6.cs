using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour {

	public int[] intArray; // Deklarasi Array

	// Use this for initialization
	void Start () {
		Debug.Log ("Menampilkan Seluruh Array");
		foreach (int a in intArray) {
			Debug.Log (a);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
