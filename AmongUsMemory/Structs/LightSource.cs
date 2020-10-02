using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct LightSource
{
    [FieldOffset(8)] public uint m_CachedPtr;
    [FieldOffset(12)] public IntPtr child;
    [FieldOffset(16)] public IntPtr requiredDels;
    [FieldOffset(20)] public IntPtr myMesh;
    [FieldOffset(24)] public uint MinRays;
    [FieldOffset(28)] public float LightRadius;
    [FieldOffset(32)] public IntPtr Material;
    [FieldOffset(36)] public IntPtr verts;
    [FieldOffset(40)] public uint vertCount;
    [FieldOffset(44)] public IntPtr buffer;
    [FieldOffset(48)] public IntPtr hits;
    [FieldOffset(52)] public uint filter;
    [FieldOffset(80)] public IntPtr vec;
    [FieldOffset(84)] public IntPtr uvs;
    [FieldOffset(88)] public IntPtr triangles;
    [FieldOffset(92)] public float tol;
    [FieldOffset(96)] public uint del;
    [FieldOffset(104)] public uint tan;
    [FieldOffset(112)] public uint side;
    [FieldOffset(120)] public IntPtr lightHits;
}