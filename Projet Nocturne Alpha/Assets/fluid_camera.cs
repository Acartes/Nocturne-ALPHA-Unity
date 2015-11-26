using UnityEngine;
using System.Collections;

public class fluid_camera : MonoBehaviour {
	
	public float OrginalX; 
	public float OrginalY; 
	public float OrginalZ; 
	
	public float ActualX; 
	public float ActualY; 
	public float ActualZ; 


	// Use this for initialization
	void Start () {
		OrginalX = transform.position.x; 
		OrginalY = transform.position.y; 
		OrginalZ = transform.position.z; 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ActualX = transform.position.x;
		ActualY = transform.position.y;
		ActualZ = transform.position.z;
/*		if (OrginalX > ActualX + 1f)
			transform.position = new Vector3(ActualX += 0.1f, ActualY, ActualZ);
		if (OrginalX < ActualX - 1f)
			transform.position = new Vector3(ActualX -= 0.1f, ActualY, ActualZ); 
		if (OrginalY > ActualY)
			transform.position = new Vector3(ActualX, ActualY += 0.1f, ActualZ);
		if (OrginalZ > ActualZ - 1f)
			transform.position = new Vector3(ActualX, ActualY, ActualZ += 0.1f);
		if (OrginalZ < ActualZ + 1f)
			transform.position = new Vector3(ActualX, ActualY, ActualZ -= 0.1f);*/
	}
}
