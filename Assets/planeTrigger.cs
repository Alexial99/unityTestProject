using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
	[SerializeField]
	private GameObject _myCarObj;
	[SerializeField]
	private Transform _winPanel;
	
	private void OnTriggerEnter(Collider other)
    {
		if(other.name=="Big_Sedan")
		_myCarObj.GetComponent<CarController>().StopCar();
		_winPanel.localScale= new Vector3 (1f, 1f, 1f);
    }
}