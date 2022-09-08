/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PropValue : MessageBase, IMessage<PropValue> // TypeDefIndex: 25960
{
    // Fields
    private static readonly MessageParser<PropValue> _parser; // 0x00
    public const int TypeFieldNumber = 1; // Metadata: 0x00B0A763
    private uint type_; // 0x18
    public const int IvalFieldNumber = 2; // Metadata: 0x00B0A767
    public const int FvalFieldNumber = 3; // Metadata: 0x00B0A76B
    public const int ValFieldNumber = 4; // Metadata: 0x00B0A76F
    private long val_; // 0x20
    private object value_; // 0x28
    private ValueOneofCase valueCase_; // 0x30

    // Properties
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static MessageParser<PropValue> Parser { get => default; } // 0x0000000181FE23B0-0x0000000181FE2440 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FE2020-0x0000000181FE20B0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FE1CB0-0x0000000181FE1D30 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static string StaticClassName { get => default; } // 0x0000000181FE1310-0x0000000181FE1370 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string ClassName { get => default; } // 0x0000000181FE29F0-0x0000000181FE2AE0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static string StaticFullClassName { get => default; } // 0x0000000181FE2710-0x0000000181FE2770 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string FullClassName { get => default; } // 0x0000000181FE21D0-0x0000000181FE22C0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static ushort StaticCmdId { get => default; } // 0x0000000181FE2900-0x0000000181FE2950 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override ushort CmdId { get => default; } // 0x0000000181FE1DD0-0x0000000181FE1EC0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public uint Type { get => default; set { } } // 0x0000000181FE1080-0x0000000181FE1120 0x0000000181FE2950-0x0000000181FE29F0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public long Ival { get => default; set { } } // 0x0000000181FE2630-0x0000000181FE2710 0x0000000181FE20B0-0x0000000181FE2170
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public float Fval { get => default; set { } } // 0x0000000181FE16C0-0x0000000181FE17A0 0x0000000181FE2440-0x0000000181FE2500
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public long Val { get => default; set { } } // 0x0000000181FE1C10-0x0000000181FE1CB0 0x0000000181FE1270-0x0000000181FE1310
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public ValueOneofCase ValueCase { get => default; } // 0x0000000181FE1370-0x0000000181FE13D0 

    // Nested types
    public enum ValueOneofCase // TypeDefIndex: 25961
    {
        None = 0,
        Ival = 2,
        Fval = 3
    }

    // Constructors
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public PropValue() { } // 0x0000000181FE2EF0-0x0000000181FE2F60
    static PropValue() { } // 0x0000000181FE2E30-0x0000000181FE2EF0

    // Methods
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public PropValue Clone() => default; // 0x0000000181FE22C0-0x0000000181FE23B0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public PropValue ShallowCopy() => default; // 0x0000000181FE1D30-0x0000000181FE1DD0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalSetInPool(bool value) { } // 0x0000000181FE15A0-0x0000000181FE15F0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) { } // 0x0000000181FE2590-0x0000000181FE25E0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) { } // 0x0000000181FE25E0-0x0000000181FE2630
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void Reset() { } // 0x0000000181FE15F0-0x0000000181FE16C0
    public void resetValue() { } // 0x0000000181FE17A0-0x0000000181FE1820
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public void ClearValue() { } // 0x0000000181FE2170-0x0000000181FE21D0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override bool Equals(object other) => default; // 0x0000000181FE19B0-0x0000000181FE1A80
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public bool Equals(PropValue other) => default; // 0x0000000181FE1820-0x0000000181FE19B0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override int GetHashCode() => default; // 0x0000000181FE1EC0-0x0000000181FE2020
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string ToString() => default; // 0x0000000181FE2AE0-0x0000000181FE2E30
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void WriteTo(CodedOutputStream output) { } // 0x0000000181FE2770-0x0000000181FE2900
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override int CalculateSize() => default; // 0x0000000181FE1A80-0x0000000181FE1C10
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public void CopyFrom(PropValue other) { } // 0x0000000181FE13D0-0x0000000181FE15A0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void MergeFrom(CodedInputStream input) { } // 0x0000000181FE1120-0x0000000181FE1270
}

