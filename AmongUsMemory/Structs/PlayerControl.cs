using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct PlayerControl
{
    [FieldOffset(8)] public uint m_CachedPtr;
    [FieldOffset(12)] public uint SpawnId;
    [FieldOffset(16)] public uint NetId;
    [FieldOffset(20)] public uint DirtyBits;
    [FieldOffset(24)] public uint SpawnFlags;
    [FieldOffset(25)] public uint sendMode;
    [FieldOffset(28)] public uint OwnerId;
    [FieldOffset(32)] public byte DespawnOnDestroy;
    [FieldOffset(36)] public uint LastStartCounter;
    [FieldOffset(40)] public byte PlayerId;
    [FieldOffset(44)] public float MaxReportDistance;
    [FieldOffset(48)] public byte moveable;
    [FieldOffset(49)] public byte inVent;
    [FieldOffset(52)] public IntPtr _cachedData;
    [FieldOffset(56)] public IntPtr FootSteps;
    [FieldOffset(60)] public IntPtr KillSfx;
    [FieldOffset(64)] public IntPtr KillAnimations;
    [FieldOffset(68)] public float killTimer;
    [FieldOffset(72)] public uint RemainingEmergencies;
    [FieldOffset(76)] public IntPtr nameText;
    [FieldOffset(80)] public IntPtr LightPrefab;
    [FieldOffset(84)] public IntPtr myLight;
    [FieldOffset(88)] public IntPtr Collider;
    [FieldOffset(92)] public IntPtr MyPhysics;
    [FieldOffset(96)] public IntPtr NetTransform;
    [FieldOffset(100)] public IntPtr CurrentPet;
    [FieldOffset(104)] public IntPtr HatRenderer;
    [FieldOffset(108)] public IntPtr myRend;
    [FieldOffset(112)] public IntPtr hitBuffer;
    [FieldOffset(116)] public IntPtr myTasks;
    [FieldOffset(120)] public IntPtr ScannerAnims;
    [FieldOffset(124)] public IntPtr ScannersImages;
    [FieldOffset(128)] public IntPtr closest;
    [FieldOffset(132)] public byte isNew;
    [FieldOffset(136)] public IntPtr cache;
    [FieldOffset(140)] public IntPtr itemsInRange;
    [FieldOffset(144)] public IntPtr newItemsInRange;
    [FieldOffset(148)] public byte scannerCount;
    [FieldOffset(149)] public byte infectedSet;
}