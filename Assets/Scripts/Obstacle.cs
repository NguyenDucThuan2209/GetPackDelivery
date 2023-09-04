using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Vector2 m_leftMovement;
    [SerializeField] Vector2 m_rightMovement;
    [SerializeField] Transform m_left;
    [SerializeField] Transform m_right;
    [SerializeField] float m_slideDuration;

    private bool m_isClosing;
    private float m_timeCount = 0;
    private float m_startRatio = 0.3f;

    private void Start()
    {
        m_left.localPosition = Vector2.Lerp(new Vector2(m_leftMovement.x, 0), new Vector2(m_leftMovement.y, 0), m_startRatio);
        m_right.localPosition = Vector2.Lerp(new Vector2(m_rightMovement.x, 0), new Vector2(m_rightMovement.y, 0), m_startRatio);
    }
    private void Update()
    {
        if (m_isClosing)
        {
            if (m_timeCount < m_slideDuration)
            {
                m_left.localPosition = Vector2.Lerp(new Vector2(m_leftMovement.x, 0), new Vector2(m_leftMovement.y, 0), m_timeCount / m_slideDuration);
                m_right.localPosition = Vector2.Lerp(new Vector2(m_rightMovement.x, 0), new Vector2(m_rightMovement.y, 0), m_timeCount / m_slideDuration);
                m_timeCount += Time.deltaTime;
            }
            else
            {
                m_timeCount = 0;
                m_isClosing = false;
            }
        }
        else
        {
            if (m_timeCount < m_slideDuration)
            {
                m_left.localPosition = Vector2.Lerp(new Vector2(m_leftMovement.y, 0), new Vector2(m_leftMovement.x, 0), m_timeCount / m_slideDuration);
                m_right.localPosition = Vector2.Lerp(new Vector2(m_rightMovement.y, 0), new Vector2(m_rightMovement.x, 0), m_timeCount / m_slideDuration);
                m_timeCount += Time.deltaTime;
            }
            else
            {
                m_timeCount = 0;
                m_isClosing = true;
            }
        }
        
    }

    public void SetupObstacle(int startRatio, bool isClosing)
    {
        m_startRatio = startRatio;
        m_isClosing = isClosing;
    }
}
