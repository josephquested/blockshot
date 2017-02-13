using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
  public GameObject projectile;
  public float projectileSpeed;

  void Update ()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      Attack();
    }
  }

  public void Attack ()
  {
    var projectileObj = Instantiate(projectile, transform.position, transform.rotation);
    projectileObj.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);
  }
}
