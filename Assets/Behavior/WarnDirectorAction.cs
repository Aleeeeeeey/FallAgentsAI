using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Warn Director", story: "[Agent] Warns Director", category: "Action", id: "cf110db6ba78c0102bb092c19e8fa460")]
public partial class WarnDirectorAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;

    protected override Status OnStart()
    {
        switch (Agent.Value.tag)
        {
            case "Yellow":
                AIDirector.instance.WarnTeam("Yellow");
                break;
            case "Blue":
                AIDirector.instance.WarnTeam("Blue");
                break;
            case "Red":
                AIDirector.instance.WarnTeam("Red");
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

