using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Drop Egg", story: "Drops [Egg]", category: "Action", id: "7fc195c6055fc041eaac65e19c45b1fa")]
public partial class DropEggAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Egg;

    protected override Status OnStart()
    {
        Egg.Value.TryGetComponent(out Rigidbody rb);
        rb.useGravity = true;
        Egg.Value.transform.parent = null;
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

