using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Deactivate HasEgg", story: "[HasEgg] becomes false", category: "Action", id: "a7e2810dfbfb7f6975cae42136d2a7ba")]
public partial class DeactivateHasEggAction : Action
{
    [SerializeReference] public BlackboardVariable<bool> HasEgg;

    protected override Status OnStart()
    {
        HasEgg.Value = false;
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

