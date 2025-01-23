    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private Rigidbody m_rigidBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float m_MoveX = Input.GetAxis("Horizontal");
        float m_MoveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(m_MoveX, 0.0f, m_MoveZ);
        m_rigidBody.MovePosition(transform.position + movement * m_speed * Time.deltaTime);
    }
}
