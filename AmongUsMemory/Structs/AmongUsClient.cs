using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct AmongUsClient
{
    [FieldOffset(8)] public uint m_CachedPtr;
    [FieldOffset(12)] public float MinSendInterval;
    [FieldOffset(16)] public uint NetIdCnt;
    [FieldOffset(20)] public float timer;
    [FieldOffset(24)] public IntPtr SpawnableObjects;
    [FieldOffset(28)] public byte InOnlineScene;
    [FieldOffset(32)] public IntPtr DestroyedObjects;
    [FieldOffset(36)] public IntPtr allObjects;
    [FieldOffset(40)] public IntPtr allObjectsFast;
    [FieldOffset(44)] public IntPtr Streams;
    [FieldOffset(48)] public IntPtr networkAddress;
    [FieldOffset(52)] public uint networkPort;
    [FieldOffset(56)] public IntPtr connection;
    [FieldOffset(60)] public uint mode;
    [FieldOffset(64)] public uint GameId;
    [FieldOffset(68)] public uint HostId;
    [FieldOffset(72)] public uint ClientId;
    [FieldOffset(76)] public IntPtr allClients;
    [FieldOffset(80)] public uint LastDisconnectReason;
    [FieldOffset(84)] public IntPtr LastCustomDisconnect;
    [FieldOffset(88)] public IntPtr PreSpawnDispatcher;
    [FieldOffset(92)] public IntPtr Dispatcher;
    [FieldOffset(96)] public byte IsGamePublic;
    [FieldOffset(100)] public uint GameState;
    [FieldOffset(104)] public IntPtr TempQueue;
    [FieldOffset(108)] public byte appPaused;
    [FieldOffset(112)] public uint AutoOpenStore;
    [FieldOffset(116)] public uint GameMode;
    [FieldOffset(120)] public IntPtr OnlineScene;
    [FieldOffset(124)] public IntPtr MainMenuScene;
    [FieldOffset(128)] public IntPtr GameDataPrefab;
    [FieldOffset(132)] public IntPtr PlayerPrefab;
    [FieldOffset(136)] public IntPtr ShipPrefabs;
    [FieldOffset(140)] public uint TutorialMapId;
    [FieldOffset(144)] public float SpawnRadius;
    [FieldOffset(148)] public uint discoverState;
    [FieldOffset(152)] public IntPtr DisconnectHandlers;
    [FieldOffset(156)] public IntPtr GameListHandlers;
}