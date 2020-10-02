using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct PlayerPhysics
{
    [FieldOffset(8)] public uint m_CachedPtr;
    [FieldOffset(12)] public uint SpawnId;
    [FieldOffset(16)] public uint NetId;
    [FieldOffset(20)] public uint DirtyBits;
    [FieldOffset(24)] public uint SpawnFlags;
    [FieldOffset(25)] public uint sendMode;
    [FieldOffset(28)] public uint OwnerId;
    [FieldOffset(32)] public byte DespawnOnDestroy;
    [FieldOffset(36)] public float Speed;
    [FieldOffset(40)] public float GhostSpeed;
    [FieldOffset(44)] public IntPtr body;
    [FieldOffset(48)] public IntPtr Animator;
    [FieldOffset(52)] public IntPtr rend;
    [FieldOffset(56)] public IntPtr myPlayer;
    [FieldOffset(60)] public IntPtr RunAnim;
    [FieldOffset(64)] public IntPtr IdleAnim;
    [FieldOffset(68)] public IntPtr GhostIdleAnim;
    [FieldOffset(72)] public IntPtr EnterVentAnim;
    [FieldOffset(76)] public IntPtr ExitVentAnim;
    [FieldOffset(80)] public IntPtr SpawnAnim;
    [FieldOffset(84)] public IntPtr Skin;
}