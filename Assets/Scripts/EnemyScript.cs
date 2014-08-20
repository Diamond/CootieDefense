using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public float pause;
	public float movePerTurn = 3.0f;
	private float _moveRemaining = 0.0f;
	public float speed = 5.0f;
	private float _lastMovedAt;
	private bool _moving = false;
	private float _mySpeed;

	// Use this for initialization
	void Start () {
		_lastMovedAt = Time.time;
		_mySpeed = speed;
		_moveRemaining = movePerTurn;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - _lastMovedAt >= pause) {
			float xMove = speed * Time.deltaTime;
			_moveRemaining -= xMove;
			this.transform.position -= new Vector3(xMove, 0.0f, 0.0f);
			if (_moveRemaining <= 0) {
				_lastMovedAt = Time.time;
				_moveRemaining = movePerTurn;
			}
		}

	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "TowerBullet") {
			this.gameObject.GetComponent<HealthyScript>().Hurt ();
			c.gameObject.SetActive(false);
		}
	}
}
