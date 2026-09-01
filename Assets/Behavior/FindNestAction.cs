using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Find Nest", story: "[Agent] locates [Nest]", category: "Action", id: "787be4e67c6d41ff04eb40647b04797b")]
public partial class FindNestAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<Transform> Nest;
    [SerializeReference] public BlackboardVariable<Transform> BlueNest;
    [SerializeReference] public BlackboardVariable<Transform> RedNest;
    [SerializeReference] public BlackboardVariable<Transform> YellowNest;
    protected override Status OnStart()
    {
        switch (Agent.Value.tag)
        {
            case "Yellow":
                Nest.Value = YellowNest.Value;
                break;
            case "Blue":
                Nest.Value = BlueNest.Value;
                break;
            case "Red":
                Nest.Value = RedNest.Value;
                break;
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

