using System;
using System.Collections.Generic;
using Improbable.Gdk.Core;

namespace Improbable.Gdk.PlayerLifecycle
{
    public delegate IObservable<EntityTemplate> GetPlayerEntityTemplateDelegate(
        string clientWorkerId,
        Vector3f position,
        string playerDatabaseId);

    public static class PlayerLifecycleConfig
    {
        public const float PlayerHeartbeatIntervalSeconds = 5f;
        public const int MaxNumFailedPlayerHeartbeats = 12;

        public static GetPlayerEntityTemplateDelegate  CreatePlayerEntityTemplate;
    }
}
