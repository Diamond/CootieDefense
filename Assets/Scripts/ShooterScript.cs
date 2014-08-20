using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour {
	public float timeBetweenShots = 0.0f;
	private float _lastShot = 0.0f;
	public Transform bullet;

	void Start()
	{
		_lastShot = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - _lastShot >= timeBetweenShots) {
			Shoot();
		}
	}

	void Shoot()
	{
		_lastShot = Time.time;
		var newBullet = Instantiate(bullet) as Transform;
		newBullet.position = this.transform.position;
	}
}
