/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusBuildingInfo : MessageBase, IMessage<InBattleMechanicusBuildingInfo> // TypeDefIndex: 24106
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusBuildingInfo> _parser; // 0x00
	public const int BuildingIdFieldNumber = 1; // Metadata: 0x00B0592B
	private uint buildingId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B0592F
	private uint level_; // 0x1C
	public const int CostPointsFieldNumber = 3; // Metadata: 0x00B05933
	private uint costPoints_; // 0x20
	public const int RefundPointsFieldNumber = 4; // Metadata: 0x00B05937
	private uint refundPoints_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusBuildingInfo> Parser { get => default; } // 0x0000000184A02FA0-0x0000000184A03030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A02BF0-0x0000000184A02C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A027E0-0x0000000184A02860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A01F50-0x0000000184A01FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A034F0-0x0000000184A035E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A03200-0x0000000184A03260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A02DC0-0x0000000184A02EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A034A0-0x0000000184A034F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A029A0-0x0000000184A02A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingId { get => default; set {} } // 0x0000000184A03160-0x0000000184A03200 0x0000000184A03260-0x0000000184A03300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000184A021D0-0x0000000184A02270 0x0000000184A02900-0x0000000184A029A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostPoints { get => default; set {} } // 0x0000000184A02D20-0x0000000184A02DC0 0x0000000184A02C80-0x0000000184A02D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefundPoints { get => default; set {} } // 0x0000000184A02740-0x0000000184A027E0 0x0000000184A01FB0-0x0000000184A02050

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingInfo() {} // 0x0000000184A039C0-0x0000000184A03A20
	static InBattleMechanicusBuildingInfo() {} // 0x0000000184A03900-0x0000000184A039C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingInfo Clone() => default; // 0x0000000184A02EB0-0x0000000184A02FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusBuildingInfo ShallowCopy() => default; // 0x0000000184A02860-0x0000000184A02900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A02270-0x0000000184A022C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A030C0-0x0000000184A03110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A03110-0x0000000184A03160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A022C0-0x0000000184A02350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A02350-0x0000000184A02420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusBuildingInfo other) => default; // 0x0000000184A02420-0x0000000184A02570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A02A90-0x0000000184A02BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A035E0-0x0000000184A03900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A03300-0x0000000184A034A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A02570-0x0000000184A02740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusBuildingInfo other) {} // 0x0000000184A02050-0x0000000184A021D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A01E20-0x0000000184A01F50
}

