using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Equate Nest Location", story: "[NestLocation] Becomes [Nest] Coordinates", category: "Action", id: "a44b00995a8a7c3036084e6f2ba732e6")]
public partial class EquateNestLocationAction : Action
{
    [SerializeReference] public BlackboardVariable<Vector3> NestLocation;
    [SerializeReference] public BlackboardVariable<GameObject> Nest;

    protected override Status OnStart()
    {
        NestLocation.Value = (BlackboardVariable<Vector3>)Nest.Value.transform.position;
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

