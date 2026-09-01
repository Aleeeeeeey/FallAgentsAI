using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AIDirector : MonoBehaviour
{
    //Crear un Singleton para referenciar.
    public static AIDirector instance;

    GameObject WaypointHolder;
    public List<GameObject> WaypointList;

    public List<GameObject> WaypointsToAssign;

    public int totalWaypointsAssigned;

    int WaypointListLength;

    public TMP_Text redEggs;
    public TMP_Text yellowEggs;
    public TMP_Text blueEggs;

    void Awake()
    {
        instance = this;

        //Lo primero que hace es recoger todos los waypoints posibles.
        GetWaypoints();
        GetAgents();
    }

    public void GetWaypoints()
    {
        WaypointHolder = GameObject.Find("Waypoints");
        foreach (Transform child  in WaypointHolder.transform)
        {
            WaypointList.Add(child.gameObject);
        }
    }

    public void AssignWaypoints()
    {
        WaypointListLength = WaypointList.Count;
        //6 Veces va a asignar un waypoint al azar a un array para que el NPC copie dicho array de puntos de ruta.
        for (int i = 0; i < 7; i++)
        {
            WaypointsToAssign.Add(WaypointList[Random.Range(0, WaypointListLength)]);

            //Añade al contador de waypoints asignados cada vez.
            totalWaypointsAssigned++;
        }
    }

    public void GetAgents()
    {
        GameObject[] redTeam = GameObject.FindGameObjectsWithTag("Red");
        GameObject[] yellowTeam = GameObject.FindGameObjectsWithTag("Yellow");
        GameObject[] blueTeam = GameObject.FindGameObjectsWithTag("Blue");

        int AgentCount = redTeam.Length + yellowTeam.Length + blueTeam.Length;

        Debug.Log("El número de agntes es : " + AgentCount);
    }

    public void UpdateEggs()
    {
        int redEggCount = GameObject.FindGameObjectsWithTag("RedEgg").Length;
        int yellowEggCount = GameObject.FindGameObjectsWithTag("YellowEgg").Length;
        int blueEggCount = GameObject.FindGameObjectsWithTag("BlueEgg").Length;

        redEggs.text = redEggCount.ToString();
        yellowEggs.text = yellowEggCount.ToString();
        blueEggs.text = blueEggCount.ToString();
    }

    public void WarnTeam(string team)
    {
        switch (team)
        {
            case "Red":
                break;

            case "Yellow":
                break;

            case "Blue":
                break;
        }
    }
}
