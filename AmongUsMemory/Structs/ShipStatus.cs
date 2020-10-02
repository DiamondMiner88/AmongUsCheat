using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct ShipStatus
{
    [FieldOffset(0)] public uint instance;
    [FieldOffset(4)] public uint _null;
    [FieldOffset(8)] public uint m_CachedPtr;
    [FieldOffset(12)] public uint SpawnId;
    [FieldOffset(16)] public uint NetId;
    [FieldOffset(20)] public uint DirtyBits;
    [FieldOffset(24)] public uint SpawnFlags;
    [FieldOffset(25)] public uint sendMode;
    [FieldOffset(28)] public uint OwnerId;
    [FieldOffset(32)] public byte DespawnOnDestroy;
    [FieldOffset(36)] public uint CameraColor;
    [FieldOffset(52)] public float MaxLightRadius;
    [FieldOffset(56)] public float MinLightRadius;
    [FieldOffset(60)] public float MapScale;
    [FieldOffset(64)] public IntPtr MapPrefab;
    [FieldOffset(68)] public IntPtr ExileCutscenePrefab;
    [FieldOffset(72)] public uint InitialSpawnCenter;
    [FieldOffset(80)] public uint MeetingSpawnCenter;
    [FieldOffset(88)] public uint MeetingSpawnCenter2;
    [FieldOffset(96)] public float SpawnRadius;
    [FieldOffset(100)] public IntPtr CommonTasks;
    [FieldOffset(104)] public IntPtr LongTasks;
    [FieldOffset(108)] public IntPtr NormalTasks;
    [FieldOffset(112)] public IntPtr SpecialTasks;
    [FieldOffset(116)] public IntPtr DummyLocations;
    [FieldOffset(120)] public IntPtr AllCameras;
    [FieldOffset(124)] public IntPtr AllDoors;
    [FieldOffset(128)] public IntPtr AllConsoles;
    [FieldOffset(132)] public IntPtr Systems;
    [FieldOffset(136)] public IntPtr AllStepWatchers;
    [FieldOffset(140)] public IntPtr AllRooms;
    [FieldOffset(144)] public IntPtr FastRooms;
    [FieldOffset(148)] public IntPtr AllVents;
    [FieldOffset(152)] public IntPtr WeaponFires;
    [FieldOffset(156)] public IntPtr WeaponsImage;
    [FieldOffset(160)] public IntPtr VentMoveSounds;
    [FieldOffset(164)] public IntPtr VentEnterSound;
    [FieldOffset(168)] public IntPtr HatchActive;
    [FieldOffset(172)] public IntPtr Hatch;
    [FieldOffset(176)] public IntPtr HatchParticles;
    [FieldOffset(180)] public IntPtr ShieldsActive;
    [FieldOffset(184)] public IntPtr ShieldsImages;
    [FieldOffset(188)] public IntPtr ShieldBorder;
    [FieldOffset(192)] public IntPtr ShieldBorderOn;
    [FieldOffset(196)] public IntPtr MedScanner;
    [FieldOffset(200)] public uint WeaponFireIdx;
    [FieldOffset(204)] public float Timer;
    [FieldOffset(208)] public float EmergencyCooldown;
    [FieldOffset(212)] public uint Type;
}