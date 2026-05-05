using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.AI;

public class FallAgent : MonoBehaviour
{

    private NavMeshAgent agent;
    private string[] classes = { "Objective", "Defensive", "Aggressive" };
    public string assignedClass;

    public string team;
    int areaMask;

    void Start()
    {
        //Referencia al agente y le asigna una de las 3 clases a este mismo.
        agent = GetComponent<NavMeshAgent>();
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
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("BlueZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        agent.areaMask = areaMask;
                        break;

                    case "Aggresive":
                        agent.areaMask = NavMesh.AllAreas;
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
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("YellowZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        agent.areaMask = areaMask;
                        break;

                    case "Aggresive":
                        agent.areaMask = NavMesh.AllAreas;
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
                        break;

                    case "Defensive":
                        areaMask += 1 << NavMesh.GetAreaFromName("RedZone");
                        areaMask += 1 << NavMesh.GetAreaFromName("Nest");
                        break;

                    case "Aggresive":
                        agent.areaMask = NavMesh.AllAreas;
                        break;
                }

                break;
        }
    }
}
