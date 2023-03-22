using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour
{
  public float rotateSpeed = 90;

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
  }

 /* private void OntriggerEnter(Collider other) 
  {
    if (other.tag == "MoveLocation")
  }
*/}

