/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterProgressDetailInfo : MessageBase, IMessage<AsterProgressDetailInfo> // TypeDefIndex: 22002
{
	// Fields
	private static readonly MessageParser<AsterProgressDetailInfo> _parser; // 0x00
	public const int CountFieldNumber = 1; // Metadata: 0x00B008BF
	private uint count_; // 0x18
	public const int LastAutoAddTimeFieldNumber = 2; // Metadata: 0x00B008C3
	private uint lastAutoAddTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterProgressDetailInfo> Parser { get => default; } // 0x00000001835A50E0-0x00000001835A5170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835A4DD0-0x00000001835A4E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835A4A20-0x00000001835A4AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835A44B0-0x00000001835A4510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835A5510-0x00000001835A5600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835A5340-0x00000001835A53A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835A4E60-0x00000001835A4F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835A54C0-0x00000001835A5510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835A4B40-0x00000001835A4C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x00000001835A5200-0x00000001835A52A0 0x00000001835A4410-0x00000001835A44B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastAutoAddTime { get => default; set {} } // 0x00000001835A4D30-0x00000001835A4DD0 0x00000001835A5040-0x00000001835A50E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressDetailInfo() {} // 0x00000001835A58C0-0x00000001835A5920
	static AsterProgressDetailInfo() {} // 0x00000001835A5800-0x00000001835A58C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressDetailInfo Clone() => default; // 0x00000001835A4F50-0x00000001835A5040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressDetailInfo ShallowCopy() => default; // 0x00000001835A4AA0-0x00000001835A4B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835A4640-0x00000001835A4690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835A52A0-0x00000001835A52F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835A52F0-0x00000001835A5340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835A4690-0x00000001835A4700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835A4700-0x00000001835A47D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterProgressDetailInfo other) => default; // 0x00000001835A47D0-0x00000001835A48F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835A4C30-0x00000001835A4D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835A5600-0x00000001835A5800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835A53A0-0x00000001835A54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835A48F0-0x00000001835A4A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterProgressDetailInfo other) {} // 0x00000001835A4510-0x00000001835A4640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835A4310-0x00000001835A4410
}

