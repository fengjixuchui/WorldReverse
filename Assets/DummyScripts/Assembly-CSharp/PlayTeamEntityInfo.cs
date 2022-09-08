/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayTeamEntityInfo : MessageBase, IMessage<PlayTeamEntityInfo> // TypeDefIndex: 26101
{
	// Fields
	private static readonly MessageParser<PlayTeamEntityInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0B20F
	private uint entityId_; // 0x18
	public const int PlayerUidFieldNumber = 2; // Metadata: 0x00B0B213
	private uint playerUid_; // 0x1C
	public const int AuthorityPeerIdFieldNumber = 3; // Metadata: 0x00B0B217
	private uint authorityPeerId_; // 0x20
	public const int GadgetConfigIdFieldNumber = 5; // Metadata: 0x00B0B21B
	private uint gadgetConfigId_; // 0x24
	public const int AbilityInfoFieldNumber = 6; // Metadata: 0x00B0B21F
	private AbilitySyncStateInfo abilityInfo_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayTeamEntityInfo> Parser { get => default; } // 0x0000000182F4EDB0-0x0000000182F4EE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F4EA00-0x0000000182F4EA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F4E540-0x0000000182F4E5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F4DB00-0x0000000182F4DB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F4F430-0x0000000182F4F520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F4F110-0x0000000182F4F170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F4EB30-0x0000000182F4EC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F4F3E0-0x0000000182F4F430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F4E660-0x0000000182F4E750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182F4F070-0x0000000182F4F110 0x0000000182F4F520-0x0000000182F4F5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x0000000182F4F340-0x0000000182F4F3E0 0x0000000182F4DF30-0x0000000182F4DFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x0000000182F4EE40-0x0000000182F4EEE0 0x0000000182F4ED10-0x0000000182F4EDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetConfigId { get => default; set {} } // 0x0000000182F4E4A0-0x0000000182F4E540 0x0000000182F4EA90-0x0000000182F4EB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AbilityInfo { get => default; set {} } // 0x0000000182F4DA60-0x0000000182F4DB00 0x0000000182F4E960-0x0000000182F4EA00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayTeamEntityInfo() {} // 0x0000000182F4FA10-0x0000000182F4FA70
	static PlayTeamEntityInfo() {} // 0x0000000182F4F950-0x0000000182F4FA10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayTeamEntityInfo Clone() => default; // 0x0000000182F4EC20-0x0000000182F4ED10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayTeamEntityInfo ShallowCopy() => default; // 0x0000000182F4E5C0-0x0000000182F4E660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F4DD50-0x0000000182F4DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F4EF70-0x0000000182F4EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F4EFF0-0x0000000182F4F070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F4DDD0-0x0000000182F4DF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F4DFD0-0x0000000182F4E0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayTeamEntityInfo other) => default; // 0x0000000182F4E0A0-0x0000000182F4E230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F4E750-0x0000000182F4E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F4F5C0-0x0000000182F4F950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F4F170-0x0000000182F4F340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F4E230-0x0000000182F4E4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayTeamEntityInfo other) {} // 0x0000000182F4DB60-0x0000000182F4DD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F4D8C0-0x0000000182F4DA60
}

