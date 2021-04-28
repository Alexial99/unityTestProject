using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SedanTrigger : MonoBehaviour
{
	[SerializeField]
	private GameObject _myCarObj;
	
	private void OnTriggerEnter(Collider other)
    {
		//if(other.name=="Big_Sedan")
		//{
			_myCarObj.GetComponent<CarController>().StopCar();
		//}	
    }
}	