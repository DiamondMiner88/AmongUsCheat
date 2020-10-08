using System;
using System.Runtime.InteropServices;

[System.Runtime.InteropServices.StructLayout(LayoutKind.Explicit)]
public struct TextRenderer
{
    [FieldOffset(0x10)] public float scale;
    [FieldOffset(0x30)] public Color Color;
    [FieldOffset(0x84)] public uint _;
}