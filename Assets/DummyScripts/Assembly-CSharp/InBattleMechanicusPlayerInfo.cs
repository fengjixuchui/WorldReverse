/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusPlayerInfo : MessageBase, IMessage<InBattleMechanicusPlayerInfo> // TypeDefIndex: 24107
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusPlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0593B
	private uint uid_; // 0x18
	public const int BuildingPointsFieldNumber = 2; // Metadata: 0x00B0593F
	private uint buildingPoints_; // 0x1C
	public const int BuildingListFieldNumber = 3; // Metadata: 0x00B05943
	private static readonly FieldCodec<InBattleMechanicusBuildingInfo> _repeated_buildingList_codec; // 0x08
	private readonly RepeatedMessageField<InBattleMechanicusBuildingInfo> buildingList_; // 0x20
	public const int PickCardIdFieldNumber = 4; // Metadata: 0x00B05947
	private uint pickCardId_; // 0x28
	public const int IsCardConfirmedFieldNumber = 5; // Metadata: 0x00B0594B
	private bool isCardConfirmed_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusPlayerInfo> Parser { get => default; } // 0x0000000181A5DCB0-0x0000000181A5DD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A5D900-0x0000000181A5D990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A5D3D0-0x0000000181A5D450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A5C960-0x0000000181A5C9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A5E1A0-0x0000000181A5E290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A5DEF0-0x0000000181A5DF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A5DAD0-0x0000000181A5DBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A5E150-0x0000000181A5E1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A5D5F0-0x0000000181A5D6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000181A5D330-0x0000000181A5D3D0 0x0000000181A5D990-0x0000000181A5DA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingPoints { get => default; set {} } // 0x0000000181A5CDA0-0x0000000181A5CE40 0x0000000181A5CE40-0x0000000181A5CEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusBuildingInfo> BuildingList { get => default; } // 0x0000000181A5D590-0x0000000181A5D5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PickCardId { get => default; set {} } // 0x0000000181A5D860-0x0000000181A5D900 0x0000000181A5D450-0x0000000181A5D4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCardConfirmed { get => default; set {} } // 0x0000000181A5DA30-0x0000000181A5DAD0 0x0000000181A5C9C0-0x0000000181A5CA60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPlayerInfo() {} // 0x0000000181A5E730-0x0000000181A5E7C0
	static InBattleMechanicusPlayerInfo() {} // 0x0000000181A5E620-0x0000000181A5E730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPlayerInfo Clone() => default; // 0x0000000181A5DBC0-0x0000000181A5DCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusPlayerInfo ShallowCopy() => default; // 0x0000000181A5D4F0-0x0000000181A5D590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A5CC40-0x0000000181A5CC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A5DDD0-0x0000000181A5DE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A5DE60-0x0000000181A5DEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A5CC90-0x0000000181A5CDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A5D070-0x0000000181A5D140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusPlayerInfo other) => default; // 0x0000000181A5CEE0-0x0000000181A5D070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A5D6E0-0x0000000181A5D860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A5E290-0x0000000181A5E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A5DF50-0x0000000181A5E150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A5D140-0x0000000181A5D330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusPlayerInfo other) {} // 0x0000000181A5CA60-0x0000000181A5CC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A5C7A0-0x0000000181A5C960
}

