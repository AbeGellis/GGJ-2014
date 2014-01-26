using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public enum PlatColor {Red, Blue, Yellow, Violet, Green, Orange};

	public PlatColor color;

	public bool solid = true;

	void Start () {

	}
	
	// Update is called once per frame
	protected virtual void Update () {
		renderer.material.color = getPlatColor(color);
		setLayer(color);
		/*if (solid) 
			(collider2D as BoxCollider2D).center = new Vector2 (0f, 0f);
		else {
			GameObject player = FindObjectOfType<PlayerMove>().gameObject;
			float yDiff = Mathf.Max(player.transform.position.y - transform.position.y, 0f);
			Vector2 raise = new Vector2 (-transform.up.x/transform.up.y * (yDiff + 10f) , yDiff + 10f);
			(collider2D as BoxCollider2D).center = raise;
		}*/
		if (!solid)
			(collider2D as BoxCollider2D).center = new Vector2(0f, 10f);
	}

	public Color getPlatColor(PlatColor p) {
		switch (p) {
		case PlatColor.Red:
			return ColorManager.red;
		case PlatColor.Blue:
			return ColorManager.blue;
		case PlatColor.Green:
			return ColorManager.green;
		case PlatColor.Orange:
			return ColorManager.orange;
		case PlatColor.Violet:
			return ColorManager.violet;
		case PlatColor.Yellow:
			return ColorManager.yellow;
		}
		return Color.white;
	}

	public void setLayer(PlatColor p) {
		switch (p) {
		case PlatColor.Red:
			gameObject.layer = LayerMask.NameToLayer ("Red");
			break;
		case PlatColor.Blue:
			gameObject.layer = LayerMask.NameToLayer ("Blue");
			break;
		case PlatColor.Green:
			gameObject.layer = LayerMask.NameToLayer ("Green");
			break;
		case PlatColor.Violet:
			gameObject.layer = LayerMask.NameToLayer ("Violet");
			break;
		case PlatColor.Orange:
			gameObject.layer = LayerMask.NameToLayer ("Orange");
			break;
		case PlatColor.Yellow:
			gameObject.layer = LayerMask.NameToLayer ("Yellow");
			break;
		}
	}
}
