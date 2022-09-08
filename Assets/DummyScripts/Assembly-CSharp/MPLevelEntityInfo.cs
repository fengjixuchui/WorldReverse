/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MPLevelEntityInfo : MessageBase, IMessage<MPLevelEntityInfo> // TypeDefIndex: 25102
{
	// Fields
	private static readonly MessageParser<MPLevelEntityInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07FE7
	private uint entityId_; // 0x18
	public const int AuthorityPeerIdFieldNumber = 2; // Metadata: 0x00B07FEB
	private uint authorityPeerId_; // 0x1C
	public const int AbilityInfoFieldNumber = 3; // Metadata: 0x00B07FEF
	private AbilitySyncStateInfo abilityInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MPLevelEntityInfo> Parser { get => default; } // 0x00000001823CE2F0-0x00000001823CE380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823CDFE0-0x00000001823CE070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823CDB80-0x00000001823CDC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823CD3B0-0x00000001823CD410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823CE860-0x00000001823CE950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823CE650-0x00000001823CE6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823CE070-0x00000001823CE160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823CE810-0x00000001823CE860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823CDCA0-0x00000001823CDD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001823CE5B0-0x00000001823CE650 0x00000001823CE950-0x00000001823CE9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x00000001823CE380-0x00000001823CE420 0x00000001823CE250-0x00000001823CE2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AbilityInfo { get => default; set {} } // 0x00000001823CD310-0x00000001823CD3B0 0x00000001823CDF40-0x00000001823CDFE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MPLevelEntityInfo() {} // 0x00000001823CED20-0x00000001823CED80
	static MPLevelEntityInfo() {} // 0x00000001823CEC60-0x00000001823CED20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MPLevelEntityInfo Clone() => default; // 0x00000001823CE160-0x00000001823CE250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MPLevelEntityInfo ShallowCopy() => default; // 0x00000001823CDC00-0x00000001823CDCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823CD5C0-0x00000001823CD640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823CE4B0-0x00000001823CE530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823CE530-0x00000001823CE5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823CD640-0x00000001823CD780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823CD8D0-0x00000001823CD9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MPLevelEntityInfo other) => default; // 0x00000001823CD780-0x00000001823CD8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823CDD90-0x00000001823CDF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823CE9F0-0x00000001823CEC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823CE6B0-0x00000001823CE810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823CD9A0-0x00000001823CDB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MPLevelEntityInfo other) {} // 0x00000001823CD410-0x00000001823CD5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823CD1B0-0x00000001823CD310
}

