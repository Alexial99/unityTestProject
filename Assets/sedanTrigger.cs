using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sedanTrigger : MonoBehaviour
{
	[SerializeField]
	private GameObject _myCarObj;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
    {
		if(other.name=="Big_Sedan")
        Debug.Log(other.name);
		_myCarObj.GetComponent<moveCar>().StopCar();
    }
}	
