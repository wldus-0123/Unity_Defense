using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Monster : MonoBehaviour
{
   [SerializeField] NavMeshAgent agent;

	public UnityEvent OnEndPointArrived;


	private void Update()
	{
		CheckEndPoint();
	}

	public void SetDestination(Vector3 destination)
	{
		agent.destination = destination;
	}

	private void CheckEndPoint()
	{
		if ((transform.position - agent.destination).sqrMagnitude < 0.1f)
		{
			Debug.Log("���Ͱ� �������� �����ߴ�");
			OnEndPointArrived?.Invoke();
			Destroy(gameObject);
		}
	}
}
