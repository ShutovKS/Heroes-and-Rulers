using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    void Start()
    {
        // ��������� ���������� ������
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // ������� ����� ����������
        agent.destination = GameObject.Find("������").transform.position;
    }
}
