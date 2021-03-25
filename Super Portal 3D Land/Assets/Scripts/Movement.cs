using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float v;
        public float h;
        public float movespeed;
        public Vector3 move;


        // Update is called once per frame
        void Update()
        {


            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            move.x = h;
            move.z = v;


            GetComponent<Transform>().Translate(move * Time.deltaTime * movespeed);



        }
}
