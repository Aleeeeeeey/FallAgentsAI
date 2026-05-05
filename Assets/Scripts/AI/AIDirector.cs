using UnityEngine;

public class AIDirector : MonoBehaviour
{
    //Crear un Singleton para referenciar.
    public static AIDirector instance;

    GameObject WaypointHolder;
    public Transform[] WaypointList;

    public Transform[] WaypointsToAssign;

    public int totalWaypointsAssigned;

    void Awake()
    {
        instance = this;

        //Lo primero que hace es recoger todos los waypoints posibles.
        GetWaypoints();
    }

    void GetWaypoints()
    {
        WaypointHolder = GameObject.Find("Waypoints");
        WaypointList = WaypointHolder.GetComponentsInChildren<Transform>();
    }

    void AssignWaypoints()
    {
        //6 Veces va a asignar un waypoint al azar a un array para que el NPC copie dicho array de puntos de ruta.
        for (int i = 0; i < 6; i++)
        {
            WaypointsToAssign[i] = WaypointList[Random.Range(0, WaypointList.Length)];

            //Añade al contador de waypoints asignados cada vez.
            totalWaypointsAssigned++;
        }
    }
}
