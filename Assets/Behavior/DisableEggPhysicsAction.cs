using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Disable Egg Physics", story: "Disable [Egg] Rigidbody", category: "Action", id: "ae2163c6b62145008ae0601ccc450f96")]
public partial class DisableEggPhysicsAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Egg;

    protected override Status OnStart()
    {
        Egg.Value.TryGetComponent(out Rigidbody rb);
        rb.useGravity = false;
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

