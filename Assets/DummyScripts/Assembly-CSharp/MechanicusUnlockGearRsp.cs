/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusUnlockGearRsp : MessageBase, IMessage<MechanicusUnlockGearRsp> // TypeDefIndex: 23898
{
	// Fields
	private static readonly MessageParser<MechanicusUnlockGearRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05153
	private int retcode_; // 0x18
	public const int MechanicusIdFieldNumber = 2; // Metadata: 0x00B05157
	private uint mechanicusId_; // 0x1C
	public const int GearIdFieldNumber = 3; // Metadata: 0x00B0515B
	private uint gearId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusUnlockGearRsp> Parser { get => default; } // 0x0000000182AA7CB0-0x0000000182AA7D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AA79A0-0x0000000182AA7A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AA75C0-0x0000000182AA7640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AA6DC0-0x0000000182AA6E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AA8120-0x0000000182AA8210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AA7F10-0x0000000182AA7F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AA7AD0-0x0000000182AA7BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AA80D0-0x0000000182AA8120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AA7780-0x0000000182AA7870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182AA7520-0x0000000182AA75C0 0x0000000182AA70F0-0x0000000182AA7190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x0000000182AA7A30-0x0000000182AA7AD0 0x0000000182AA7050-0x0000000182AA70F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GearId { get => default; set {} } // 0x0000000182AA7E70-0x0000000182AA7F10 0x0000000182AA76E0-0x0000000182AA7780

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23899
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23900
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3908
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearRsp() {} // 0x0000000182AA8560-0x0000000182AA85C0
	static MechanicusUnlockGearRsp() {} // 0x0000000182AA84A0-0x0000000182AA8560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearRsp Clone() => default; // 0x0000000182AA7BC0-0x0000000182AA7CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusUnlockGearRsp ShallowCopy() => default; // 0x0000000182AA7640-0x0000000182AA76E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AA6F80-0x0000000182AA6FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA7DD0-0x0000000182AA7E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA7E20-0x0000000182AA7E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AA6FD0-0x0000000182AA7050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AA72D0-0x0000000182AA73A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusUnlockGearRsp other) => default; // 0x0000000182AA7190-0x0000000182AA72D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AA7870-0x0000000182AA79A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AA8210-0x0000000182AA84A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AA7F70-0x0000000182AA80D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AA73A0-0x0000000182AA7520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusUnlockGearRsp other) {} // 0x0000000182AA6E20-0x0000000182AA6F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AA6CB0-0x0000000182AA6DC0
}

