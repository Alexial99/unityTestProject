using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	private float speed = 10.0f;
	private bool trigger = false ;	
    void Update()
    {
		if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z); 
        }
		if(!trigger)
		{
			transform.Translate(Vector3.forward*Time.deltaTime*4);
		}	
	}
	
	public void StopCar()
	{
		trigger=true;
	}
	
}