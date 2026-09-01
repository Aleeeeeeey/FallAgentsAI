using System;
using System.Collections.Generic;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Assign Waypoints", story: "[Agent] gets [Waypoints]", category: "Action", id: "153619cd67ea703e5e9dc060ed4979ea")]
public partial class AssignWaypointsAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<List<GameObject>> Waypoints;

    protected override Status OnStart()
    {
        AIDirector.instance.AssignWaypoints();

        for (int i = 0; i < 7; i++)
        {
            Waypoints.Value.Add(AIDirector.instance.WaypointsToAssign[i]);
        }
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

