using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour {
	private AudioSource audioSource;
	public int transpose = 0;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		var note = -1; // invalid value to detect when note is pressed
		if (Input.GetKeyDown ("a"))	note = 0;  // C
		if (Input.GetKeyDown ("s"))	note = 2;  // D
		if (Input.GetKeyDown ("d"))	note = 4;  // E
		if (Input.GetKeyDown ("f"))	note = 5;  // F
		if (Input.GetKeyDown ("g"))	note = 7;  // G
		if (Input.GetKeyDown ("h"))	note = 9;  // A
		if (Input.GetKeyDown ("j"))	note = 11; // B
		if (Input.GetKeyDown ("k"))	note = 12; // C
		if (Input.GetKeyDown ("l"))	note = 14; // D

		if (note >= 0 && audioSource != null)
		{ // if some key pressed...
			audioSource.pitch = Mathf.Pow(2, (note+transpose) / 12.0f);
			audioSource.Play();
		}
	}
}