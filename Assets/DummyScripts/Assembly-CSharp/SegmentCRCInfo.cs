/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SegmentCRCInfo : MessageBase, IMessage<SegmentCRCInfo> // TypeDefIndex: 24004
{
	// Fields
	private static readonly MessageParser<SegmentCRCInfo> _parser; // 0x00
	public const int ModuleFieldNumber = 1; // Metadata: 0x00B0554F
	private uint module_; // 0x18
	public const int OffsetFieldNumber = 2; // Metadata: 0x00B05553
	private uint offset_; // 0x1C
	public const int SizeFieldNumber = 3; // Metadata: 0x00B05557
	private uint size_; // 0x20
	public const int CrcFieldNumber = 4; // Metadata: 0x00B0555B
	private string crc_; // 0x28
	public const int RetcodeFieldNumber = 5; // Metadata: 0x00B0555F
	private int retcode_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SegmentCRCInfo> Parser { get => default; } // 0x00000001849F0F50-0x00000001849F0FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849F0BA0-0x00000001849F0C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849F0740-0x00000001849F07C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849EFBB0-0x00000001849EFC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849F1460-0x00000001849F1550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849F11B0-0x00000001849F1210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849F0CD0-0x00000001849F0DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849F1410-0x00000001849F1460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849F0900-0x00000001849F09F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Module { get => default; set {} } // 0x00000001849EFDD0-0x00000001849EFE70 0x00000001849F07C0-0x00000001849F0860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Offset { get => default; set {} } // 0x00000001849F06A0-0x00000001849F0740 0x00000001849EFF60-0x00000001849F0000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Size { get => default; set {} } // 0x00000001849F0EB0-0x00000001849F0F50 0x00000001849F0C30-0x00000001849F0CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Crc { get => default; set {} } // 0x00000001849F10C0-0x00000001849F1160 0x00000001849F00A0-0x00000001849F0150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001849F0600-0x00000001849F06A0 0x00000001849F0000-0x00000001849F00A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentCRCInfo() {} // 0x00000001849F19A0-0x00000001849F1A10
	static SegmentCRCInfo() {} // 0x00000001849F18E0-0x00000001849F19A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentCRCInfo Clone() => default; // 0x00000001849F0DC0-0x00000001849F0EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentCRCInfo ShallowCopy() => default; // 0x00000001849F0860-0x00000001849F0900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849EFE70-0x00000001849EFEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849F1070-0x00000001849F10C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849F1160-0x00000001849F11B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849EFEC0-0x00000001849EFF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849F0300-0x00000001849F03D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SegmentCRCInfo other) => default; // 0x00000001849F0150-0x00000001849F0300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849F09F0-0x00000001849F0BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849F1550-0x00000001849F18E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849F1210-0x00000001849F1410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849F03D0-0x00000001849F0600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SegmentCRCInfo other) {} // 0x00000001849EFC10-0x00000001849EFDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849EFA60-0x00000001849EFBB0
}

