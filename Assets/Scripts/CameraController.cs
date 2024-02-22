using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float padding;

    private Vector3 moveDir;

	private void OnEnable()
	{
        Cursor.lockState = CursorLockMode.Confined;
	}

	private void OnDisable()
	{
        Cursor.lockState = CursorLockMode.None;
	}

	private void Update()
	{
        Move();    
	}

    private void Move()
    {
        Pointer();
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }

    private void Pointer()
    {
        Vector2 mouse = Input.mousePosition;

		if (mouse.x < padding)
		{
			moveDir.x = -1;
		}
		else if (mouse.x > Screen.width - padding)
		{
			moveDir.x = 1;
		}
		else
		{
			moveDir.x = 0;
		}

		if (mouse.y < padding)
		{
			moveDir.z = -1;
		}
		else if (mouse.y > Screen.height - padding)
		{
			moveDir.z = 1;
		}
		else
		{
			moveDir.z = 0;
		}
	}

	//private void OnMove(InputValue value)
 //   {
 //       Vector2 input = value.Get<Vector2>();
 //       moveDir.x = input.x;
 //       moveDir.z = input.y;
 //   }

    //private void OnPointer(InputValue value)
    //{
    //    Vector2 input = value.Get<Vector2>();

    //    if(input.x < padding)
    //    {
    //        moveDir.x = -1;
    //    }
    //    else if(input.x > Screen.width - padding)
    //    {
    //        moveDir.x = 1;
    //    }
    //    else
    //    {
    //        moveDir.x = 0;
    //    }

    //    if(input.y < padding)
    //    {
    //        moveDir.z = -1;
    //    }
    //    else if(input.y > Screen.height - padding)
    //    {
    //        moveDir.z = 1;
    //    }
    //    else
    //    {
    //        moveDir.z = 0;
    //    }
    //}
}
