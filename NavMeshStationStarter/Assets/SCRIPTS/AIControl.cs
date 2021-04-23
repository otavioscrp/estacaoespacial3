using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//atribuir biblioteca de AI para a navegação
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //definir variavel do objeto que realizará as ações do navmesh
    public NavMeshAgent agent;

    //ao iniciar o programa, atrivuir componente de navmesh para o objeto
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

}

