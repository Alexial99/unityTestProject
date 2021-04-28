using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseMove : MonoBehaviour
{
	[SerializeField]
	private Transform _myLet;
	[SerializeField]
	private Rigidbody _myLetRigidBody;
	[SerializeField]
	private Text _myText;
	
	void OnMouseDown()
    {
		
		if(_myLet.position.x>0f)
		{
			_myLetRigidBody.AddForce(transform.right*500 );
		}
		else
		{
			_myLetRigidBody.AddForce(-transform.right*500);
			
		}
		_myText.GetComponent<textChanger>().changeText();
    }
	
	
}
