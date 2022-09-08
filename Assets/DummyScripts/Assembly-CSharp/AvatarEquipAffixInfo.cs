/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarEquipAffixInfo : MessageBase, IMessage<AvatarEquipAffixInfo> // TypeDefIndex: 26069
{
	// Fields
	private static readonly MessageParser<AvatarEquipAffixInfo> _parser; // 0x00
	public const int EquipAffixIdFieldNumber = 1; // Metadata: 0x00B0AF77
	private uint equipAffixId_; // 0x18
	public const int LeftCdTimeFieldNumber = 2; // Metadata: 0x00B0AF7B
	private uint leftCdTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarEquipAffixInfo> Parser { get => default; } // 0x00000001831DCF90-0x00000001831DD020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831DCC80-0x00000001831DCD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831DC8D0-0x00000001831DC950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831DC2C0-0x00000001831DC320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831DD320-0x00000001831DD410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831DD150-0x00000001831DD1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831DCD10-0x00000001831DCE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831DD2D0-0x00000001831DD320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831DCA90-0x00000001831DCB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EquipAffixId { get => default; set {} } // 0x00000001831DC950-0x00000001831DC9F0 0x00000001831DC830-0x00000001831DC8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftCdTime { get => default; set {} } // 0x00000001831DD410-0x00000001831DD4B0 0x00000001831DCEF0-0x00000001831DCF90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipAffixInfo() {} // 0x00000001831DD770-0x00000001831DD7D0
	static AvatarEquipAffixInfo() {} // 0x00000001831DD6B0-0x00000001831DD770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipAffixInfo Clone() => default; // 0x00000001831DCE00-0x00000001831DCEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipAffixInfo ShallowCopy() => default; // 0x00000001831DC9F0-0x00000001831DCA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831DC450-0x00000001831DC4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831DD0B0-0x00000001831DD100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831DD100-0x00000001831DD150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831DC4A0-0x00000001831DC510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831DC510-0x00000001831DC5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarEquipAffixInfo other) => default; // 0x00000001831DC5E0-0x00000001831DC700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831DCB80-0x00000001831DCC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831DD4B0-0x00000001831DD6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831DD1B0-0x00000001831DD2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831DC700-0x00000001831DC830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarEquipAffixInfo other) {} // 0x00000001831DC320-0x00000001831DC450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831DC1C0-0x00000001831DC2C0
}

