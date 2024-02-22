using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
	[SerializeField] Transform endPoint;

	private void MoveTo(Vector3 point)
	{
		agent.destination = point;
	}
	private void OnRightClick(InputValue value)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out RaycastHit hitInfo))
		{
			Debug.DrawLine(Camera.main.transform.position, hitInfo.point, Color.red, 0.2f);
			MoveTo(hitInfo.point);
		}
	}

	// ���콺 �ȵż� ��ü
	private void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out RaycastHit hitInfo))
			{
				Debug.DrawLine(Camera.main.transform.position, hitInfo.point, Color.red, 0.3f);
				MoveTo(hitInfo.point);
			}
		}
	}
}
