using UnityEngine;
using System.Collections;

public class HealthyScript : MonoBehaviour {
	public int health = 4;
	public Sprite[] healthbars;
	public Transform display;
	public ParticleEmitter deadsplosion;

	// Update is called once per frame
	void UpdateDisplay () {
		display.GetComponent<SpriteRenderer>().sprite = healthbars[health];
	}

	public void Hurt()
	{
		health--;
		UpdateDisplay();
		if (health <= 0) {
			//deadsplosion.Emit();
			this.gameObject.SetActive(false);
		}
	}

	public void Heal()
	{
		health++;
		UpdateDisplay();
	}

	void OnMouseDown()
	{
		Hurt ();
	}
}
