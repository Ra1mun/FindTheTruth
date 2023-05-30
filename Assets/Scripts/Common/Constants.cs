using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    public static Dictionary<ScenesName, string> _scenes = new Dictionary<ScenesName, string>()
    {
        [ScenesName.Lobby] = "Lobby",
        [ScenesName.SamRoom] = "SamRoom",
        [ScenesName.Lab] = "Lab",
        [ScenesName.KristapherRoom] = "KristapherRoom"
    };
}
