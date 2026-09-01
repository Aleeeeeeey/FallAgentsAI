using JetBrains.Annotations;
using System;
using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;

public class FallAgent : MonoBehaviour
{

    private NavMeshAgent agent;
    private string[] classes = { "Objective", "Defensive", "Aggressive" };
    public string assignedClass;

    public string team;
    int areaMask;

    BehaviorGraphAgent graphAgent;
    public BehaviorGraph objectiveGraph;
    public BehaviorGraph defensiveGraph;
    public BehaviorGraph aggressiveGraph;

    void Start()
    {
        //Referencia al agente y le asigna una de las 3 clases a este mismo.
        agent = GetComponent<NavMeshAgent>();
        graphAgent = GetComponent<BehaviorGraphAgent>();
        AssignClass();
    }

    void AssignClass()
    {
        //Elige al azar una de las 3 clases y le asignan areas (el equipo se elige en el inspector, no es al azar).
        assignedClass = classes[UnityEngine.Random.Range(0, classes.Length)];
        AssignAreas();
    }

    void AssignAreas()
    {
        //Quita todo de la máscara de áreas del navmesh.
        areaMask -= 1 << NavMesh.GetAreaFromName("Everything");
        //Dependiendo del equipo y la clase, añadirá zonas diferentes a la máscara de areas del navmesh.
        switch (team)
        {
            case "Blue":
                
                switch (assignedClass)
                {
                    case "Objective":
                        areaMask += 1 << NavMesh.GetAreaFromName("BlueZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        areaMask += 1 << NavMesh.GetAreaFromName("Walkable");
                        areaMask += 1 << NavMesh.GetAreaFromName("Treadmill");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = objectiveGraph;
                        graphAgent.Init();
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("BlueZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = defensiveGraph;
                        graphAgent.Init();
                        break;

                    case "Aggressive":
                        agent.areaMask = NavMesh.AllAreas;
                        graphAgent.Graph = aggressiveGraph;
                        graphAgent.Init();
                        break;
                }

                break;

            case "Yellow":

                switch (assignedClass)
                {
                    case "Objective":
                        areaMask += 1 << NavMesh.GetAreaFromName("YellowZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        areaMask += 1 << NavMesh.GetAreaFromName("Walkable");
                        areaMask += 1 << NavMesh.GetAreaFromName("Treadmill");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = objectiveGraph;
                        graphAgent.Init();
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("YellowZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = defensiveGraph;
                        graphAgent.Init();
                        break;

                    case "Aggressive":
                        agent.areaMask = NavMesh.AllAreas;
                        graphAgent.Graph = aggressiveGraph;
                        graphAgent.Init();
                        break;
                }

                break;

            case "Red":

                switch (assignedClass)
                {
                    case "Objective":
                        areaMask += 1 << NavMesh.GetAreaFromName("RedZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        areaMask += 1 << NavMesh.GetAreaFromName("Walkable");
                        areaMask += 1 << NavMesh.GetAreaFromName("Treadmill");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = objectiveGraph;
                        graphAgent.Init();
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("RedZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        agent.areaMask = areaMask;
                        graphAgent.Graph = defensiveGraph;
                        graphAgent.Init();
                        break;

                    case "Aggressive":
                        agent.areaMask = NavMesh.AllAreas;
                        graphAgent.Graph = aggressiveGraph;
                        graphAgent.Init();
                        break;
                }

                break;
        }
    }
}
