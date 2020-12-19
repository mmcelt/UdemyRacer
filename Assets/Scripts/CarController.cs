using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	#region Fields

	[SerializeField] float _maxSpeed;

	[SerializeField] Rigidbody _theRB;

	#endregion

	#region MonoBehaviour Methods

	void Start() 
	{
		_theRB.transform.parent = null;
	}
	
	void Update() 
	{
		_theRB.AddForce(new Vector3(0f,0f,100f));

		transform.position = _theRB.transform.position;
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods


	#endregion
}
