using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace UnityStandardAssets.Utility
{
    public class MovimientoAleatorio : MonoBehaviour
    {
        NavMeshAgent agente;
        public int rangoDeMovimiento;
        public int rangoDeRotacion;
        public bool ignoreTimescale;

        private float m_LastRealTime;
        private System.Random rnd = new System.Random();
        private int MIN = 0;
        private Vector3 nuevaPos;

        private void Start()
        {
            m_LastRealTime = Time.realtimeSinceStartup;
        }


        // Update is called once per frame
        private void Update()
        {

            Vector3 movimiento = new Vector3(Random.Range(1, rangoDeMovimiento), 0f, Random.Range(1, rangoDeMovimiento));
            Vector3 rotacion = new Vector3(0f, Random.Range(MIN, rangoDeRotacion), 0f);
            float deltaTime = Time.deltaTime;
            if (ignoreTimescale)
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;
            }
            transform.Translate(movimiento * deltaTime, Space.Self);
            transform.Rotate(rotacion * deltaTime, Space.Self);
        }
    }
}
