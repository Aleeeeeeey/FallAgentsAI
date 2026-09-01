using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Compare Egg Tag", story: "[Agent] Checks [Egg] tag", category: "Action", id: "0fa9ab744d4d76ff07b4b8e343297890")]
public partial class CompareEggTagAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<GameObject> Egg;

    protected override Status OnStart()
    {
        switch (Agent.Value.tag)
        {
            case "Yellow":
                
                switch (Egg.Value.tag)
                {
                    case "BlueEgg":
                        Egg.Value.tag = "Egg";
                        break;
                    case "RedEgg":
                        Egg.Value.tag = "Egg";
                        break;
                    case "YellowEgg":
                        break;
                }
                break;

            case "Blue":
                switch (Egg.Value.tag)
                {
                    case "BlueEgg":
                        break;
                    case "RedEgg":
                        Egg.Value.tag = "Egg";
                        break;
                    case "YellowEgg":
                        Egg.Value.tag = "Egg";
                        break;
                }
                break;

            case "Red":
                switch (Egg.Value.tag)
                {
                    case "BlueEgg":
                        Egg.Value.tag = "Egg";
                        break;
                    case "RedEgg":
                        break;
                    case "YellowEgg":
                        Egg.Value.tag = "Egg";
                        break;
                }
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

