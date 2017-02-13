using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
  public float speed = 3.0F;

  void Update()
	{
		MovementInput();
		FaceCursor();
	}

	void MovementInput ()
	{
		CharacterController controller = GetComponent<CharacterController>();
		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0)
		{
			movement *= 0.75f;
		}
		controller.SimpleMove(movement * speed);
	}

	void FaceCursor ()
	{
		Plane playerPlane = new Plane(Vector3.up, transform.position);
  	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
  	float hitdist = 0.0f;
  	if (playerPlane.Raycast (ray, out hitdist))
		{
    	Vector3 targetPoint = ray.GetPoint(hitdist);
    	Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
    	transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 100 * Time.deltaTime);
		}
	}
}
