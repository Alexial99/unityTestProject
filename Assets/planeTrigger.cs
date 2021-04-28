using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeTrigger : MonoBehaviour
{
	[SerializeField]
	private GameObject _myCarObj;
	[SerializeField]
	private Transform _winPanel;
	
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
		_myCarObj.GetComponent<moveCar>().StopCar();
		_winPanel.localScale= new Vector3 (1f, 1f, 1f);
    }
}
