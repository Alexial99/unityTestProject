using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
	[SerializeField]
	private Transform _let;
	[SerializeField]
	private Rigidbody _letRigidBody;
	[SerializeField]
	private Text _myText;
	
	void OnMouseDown()
    {
		
		if(_let.position.x>0f)
		{
			_letRigidBody.AddForce(transform.right*500 );
		}
		else
		{
			_letRigidBody.AddForce(-transform.right*500);
			
		}
		_myText.GetComponent<TextChanger>().changeText();
    }
	
}