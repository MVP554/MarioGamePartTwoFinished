using UnityEngine;
using System.Collections;

public class GoombaWalk : MonoBehaviour {

	public float speed = -30f;  // always moving to the left

	private Vector2 startPosition;

	private Rigidbody2D body2d;
//	protected CollisionState collisionState;

    void Awake (){

		body2d = GetComponent<Rigidbody2D> ();
//		collisionState = GetComponent<CollisionState> ();
	}

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		body2d.velocity = new Vector2 (speed, body2d.velocity.y);
		//if goomba falls off the ground, restart at initial position
		if (transform.position.y < (startPosition.y - 40))
			transform.position = startPosition;
			

	}

}
