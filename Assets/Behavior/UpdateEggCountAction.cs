using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Update Egg Count", story: "Uppdate [Egg] Count", category: "Action", id: "f36ef52df98d289bb3d1527d65435c43")]
public partial class UpdateEggCountAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Egg;

    protected override Status OnStart()
    {
        AIDirector.instance.UpdateEggs();
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

