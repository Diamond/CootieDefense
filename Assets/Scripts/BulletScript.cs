using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float speed = 0.5f;

	void Update()
	{
		this.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	}
}
