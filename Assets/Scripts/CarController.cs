using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	#region Fields

	[SerializeField] Rigidbody _theRB;
	[SerializeField] float _maxSpeed;
	[SerializeField] float _forwardAccel = 8f, _reverseAccel = 4f;

	float _speedInput;
	#endregion

	#region MonoBehaviour Methods

	void Start() 
	{

		_theRB.transform.parent = null;
	}

	void Update()
	{
		_speedInput = 0f;

		if (Input.GetAxis("Vertical") > 0)
		{
			_speedInput = Input.GetAxis("Vertical") * _forwardAccel;
		}
		else if(Input.GetAxis("Vertical") < 0)
		{
			_speedInput = Input.GetAxis("Vertical") * _reverseAccel;
		}

		transform.position = _theRB.transform.position;
	}

	void FixedUpdate() 
	{
		_theRB.AddForce(new Vector3(0f, 0f, _speedInput * 1000f));
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods


	#endregion
}
