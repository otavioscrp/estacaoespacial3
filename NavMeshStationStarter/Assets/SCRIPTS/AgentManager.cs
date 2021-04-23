using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //criação dos agentes no script de navmesh
    GameObject[] agents;

    //atribuir a Tag dos objetos que irão realizar a ação da navmesh 
    //Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    //definição da ação apos o input do jogador com o botão do mouse
    void Update()
    {
        //ao clique do mouse(botão zero)
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            //criação do raycast 
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
