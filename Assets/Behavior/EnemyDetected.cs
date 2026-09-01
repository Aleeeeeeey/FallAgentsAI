using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Enemy Detected")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Enemy Detected", message: "[Agent] has spotted [Enemy]", category: "Events", id: "59a0b48604060bb24a87aba3038f3865")]
public sealed partial class EnemyDetected : EventChannel<GameObject, GameObject> { }

