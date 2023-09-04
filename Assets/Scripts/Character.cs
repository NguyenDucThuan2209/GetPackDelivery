using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float m_jumpForce;
    [SerializeField] float m_cameraOffset;

    [SerializeField] Camera m_camera;
    [SerializeField] Rigidbody2D m_rigidbody;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_rigidbody.velocity = transform.up * m_jumpForce;
        }

        if (transform.position.y > m_camera.transform.position.y + m_cameraOffset)
        {
            m_camera.transform.position = new Vector3(0f, transform.position.y - m_cameraOffset, -10f);
        }
    }
}
