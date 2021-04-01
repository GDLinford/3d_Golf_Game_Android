using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Stop_Rolling : MonoBehaviour
//{
//
//    [SerializeField]
//    private Material FastRoll;
//
//    [SerializeField]
//    private Material SlowRoll;
//
//    [SerializeField]
//    private Rigidbody rb;
//
//    [SerializeField]
//    private MeshRenderer rend;
//
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//        rend = GetComponent<MeshRenderer>();
//    }
//
//    void Update()
//    {
//        rb.angularDrag = 5;
//
//        if (rb.angularVelocity.magnitude < 5)
//            rend.sharedMaterial = SlowRoll;
//        else
//            rend.sharedMaterial = FastRoll;
//
//    }
//
//}
