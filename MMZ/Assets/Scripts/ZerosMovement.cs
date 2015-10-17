using UnityEngine;
using System.Collections;

public class ZerosMovement : MonoBehaviour {
	public float maxspeed;
	public float speed;
	private Animator anim;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update()
	{
		anim.SetFloat ("Walk", Mathf.Abs (Input.GetAxis ("Horizontal")));
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale=new Vector3(-1,1,1);
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale=new Vector3(1,1,1);
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		//rb.AddForce ((Vector2.right *speed)* move);
		if (rb.velocity.x > maxspeed) {
			rb.velocity=new Vector2(maxspeed,0);
		}
		if (rb.velocity.x < -maxspeed) {
			rb.velocity=new Vector2(-maxspeed,0);
		}

	}
}
