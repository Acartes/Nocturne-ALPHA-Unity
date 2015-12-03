﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit[] hits;
		hits = Physics.RaycastAll(transform.position, transform.forward, 10.0F);
		
		for (int i = 0; i < hits.Length; i++) {
			RaycastHit hit = hits[i];
			Renderer rend = hit.transform.GetComponent<Renderer>();
			
			if (rend) {
				// Change the material of all hit colliders
				// to use a transparent shader.
				rend.material.shader = Shader.Find("Transparent/Diffuse");
				Color tempColor = rend.material.color;
				tempColor.a = 0.3F;
				rend.material.color = tempColor;
			}
		}
	}
}
