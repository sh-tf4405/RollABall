using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PendulumBlock : MonoBehaviour
{  
        public float Amplitude = 5f; //êUïù
        public float Frequency = 1f; //ïpìx
        private Vector3 startPos = Vector3.zero;

        private MeshRenderer boxMesh;
        float time = 1.0f;

    
        private void Start()
        {
            startPos = transform.position;

        boxMesh = GetComponent<MeshRenderer>();
        }
        void Update()
        {
            transform.position = startPos + Vector3.forward * Amplitude * Mathf.Sin(Time.time * Frequency);

            time -= Time.deltaTime;

        if (time < 0f)
        {
            boxMesh.enabled = !boxMesh.enabled;
            time = 1f;
        }
       

        }
 }

