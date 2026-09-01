using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Activate Has Egg", story: "[HassEgg] becomes True", category: "Action", id: "f308cf3c5e7a95337ac2bcdb1d3a9b3a")]
public partial class ActivateHasEggAction : Action
{
    [SerializeReference] public BlackboardVariable<bool> HassEgg;

    protected override Status OnStart()
    {
        HassEgg.Value = true;
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

