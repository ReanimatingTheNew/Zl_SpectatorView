﻿using HoloToolkit.Sharing.Spawning;
using HoloToolkit.Sharing.SyncModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SyncDataClass]
public class Vase3 : SyncSpawnedObject
{
    /// <summary>
    /// Transform (position, orientation and scale) for the object.
    /// </summary>
    [SyncData] public SyncInteger postAction;

}

