//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class RollBall : MonoBehaviour
//{
//    
//
//    bool isMoving = false;
//
//    float xRot, yRot = 0f;
//
//    [SerializeField]
//    private float rotationSpeed = 5f;
//    [SerializeField]
//    private Rigidbody ball;
//    [SerializeField]
//    private float shotPower = 30f;
//    [SerializeField]
//    private LineRenderer line;
//    
//    
//
//    private void Update()
//    {
//        transform.position = ball.position;
//
//        if (Input.GetMouseButton(0)) 
//        {
//            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
//            yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
//            if (yRot < -35f)
//            {
//                yRot = -35f;
//            }
//
//            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
//            line.gameObject.SetActive(true);
//            line.SetPosition(0, transform.position);
//            line.SetPosition(1, transform.position + transform.forward * 4f);
//        }
//
//        if (Input.GetMouseButtonUp(0))
//        {
//            ball.velocity = transform.forward * shotPower;
//            line.gameObject.SetActive(false);
//            isMoving = true;
//           
//        }
//
//     
//    }
//}
