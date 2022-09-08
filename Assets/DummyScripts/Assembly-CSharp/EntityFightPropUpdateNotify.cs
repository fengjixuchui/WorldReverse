/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityFightPropUpdateNotify : MessageBase, IMessage<EntityFightPropUpdateNotify> // TypeDefIndex: 24534
{
    // Fields
    private static readonly MessageParser<EntityFightPropUpdateNotify> _parser; // 0x00
    public const int EntityIdFieldNumber = 1; // Metadata: 0x00B06A5B
    private uint entityId_; // 0x18
    public const int FightPropMapFieldNumber = 2; // Metadata: 0x00B06A5F
    private static readonly MapField<uint, float> _map_fightPropMap_codec; // 0x08
    private readonly MapField<uint, float> fightPropMap_; // 0x20

    // Properties
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static MessageParser<EntityFightPropUpdateNotify> Parser { get => default; } // 0x0000000182E17170-0x0000000182E17200 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E16F00-0x0000000182E16F90 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E16BB0-0x0000000182E16C30 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static string StaticClassName { get => default; } // 0x0000000182E16560-0x0000000182E165C0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string ClassName { get => default; } // 0x0000000182E175C0-0x0000000182E176B0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static string StaticFullClassName { get => default; } // 0x0000000182E173D0-0x0000000182E17430 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string FullClassName { get => default; } // 0x0000000182E16F90-0x0000000182E17080 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static ushort StaticCmdId { get => default; } // 0x0000000182E17570-0x0000000182E175C0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override ushort CmdId { get => default; } // 0x0000000182E16CD0-0x0000000182E16DC0 
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public uint EntityId { get => default; set { } } // 0x0000000182E17330-0x0000000182E173D0 0x0000000182E176B0-0x0000000182E17750
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public MapField<FightPropType, float> FightPropMap { get => default; } // 0x0000000182E165C0-0x0000000182E16620 

    // Nested types
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public static class Types // TypeDefIndex: 24535
    {
        // Nested types
        public enum CmdId // TypeDefIndex: 24536
        {
            None = 0,
            EnetChannelId = 0,
            EnetIsReliable = 1,
            CmdId = 1204
        }
    }

    // Constructors
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public EntityFightPropUpdateNotify() { } // 0x0000000182E17A60-0x0000000182E17AF0
    static EntityFightPropUpdateNotify() { } // 0x0000000182E17930-0x0000000182E17A60

    // Methods
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public EntityFightPropUpdateNotify Clone() => default; // 0x0000000182E17080-0x0000000182E17170
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public EntityFightPropUpdateNotify ShallowCopy() => default; // 0x0000000182E16C30-0x0000000182E16CD0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalSetInPool(bool value) { } // 0x0000000182E16750-0x0000000182E167A0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) { } // 0x0000000182E17290-0x0000000182E172E0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) { } // 0x0000000182E172E0-0x0000000182E17330
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void Reset() { } // 0x0000000182E167A0-0x0000000182E16860
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override bool Equals(object other) => default; // 0x0000000182E16860-0x0000000182E16930
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public bool Equals(EntityFightPropUpdateNotify other) => default; // 0x0000000182E16930-0x0000000182E16A70
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override int GetHashCode() => default; // 0x0000000182E16DC0-0x0000000182E16F00
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override string ToString() => default; // 0x0000000182E17750-0x0000000182E17930
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void WriteTo(CodedOutputStream output) { } // 0x0000000182E17430-0x0000000182E17570
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override int CalculateSize() => default; // 0x0000000182E16A70-0x0000000182E16BB0
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public void CopyFrom(EntityFightPropUpdateNotify other) { } // 0x0000000182E16620-0x0000000182E16750
    [DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
    public override void MergeFrom(CodedInputStream input) { } // 0x0000000182E16400-0x0000000182E16560
}

