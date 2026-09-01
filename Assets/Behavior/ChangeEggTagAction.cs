using NUnit.Framework.Internal;
using System;
using Unity.Behavior;
using Unity.Properties;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using Action = Unity.Behavior.Action;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Change Egg Tag", story: "[Agent] Changes [Egg] Tag", category: "Action", id: "0f6f800de84dc3c368ee62687d8eb328")]
public partial class ChangeEggTagAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<GameObject> Egg;
    protected override Status OnStart()
    {
        switch (Agent.Value.tag)
        {
            case "Yellow":
                Egg.Value.tag = "YellowEgg";
                break;
            case "Blue":
                Egg.Value.tag = "BlueEgg";
                break;
            case "Red":
                Egg.Value.tag = "RedEgg";
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

