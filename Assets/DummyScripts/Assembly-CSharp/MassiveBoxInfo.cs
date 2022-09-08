/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveBoxInfo : MessageBase, IMessage<MassiveBoxInfo> // TypeDefIndex: 26084
{
	// Fields
	private static readonly MessageParser<MassiveBoxInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0B0FB
	private int id_; // 0x18
	public const int ConfigIdFieldNumber = 2; // Metadata: 0x00B0B0FF
	private uint configId_; // 0x1C
	public const int CenterFieldNumber = 3; // Metadata: 0x00B0B103
	private Vector center_; // 0x20
	public const int ExtentsFieldNumber = 4; // Metadata: 0x00B0B107
	private Vector extents_; // 0x28
	public const int UpFieldNumber = 5; // Metadata: 0x00B0B10B
	private Vector up_; // 0x30
	public const int ForwardFieldNumber = 6; // Metadata: 0x00B0B10F
	private Vector forward_; // 0x38
	public const int RightFieldNumber = 7; // Metadata: 0x00B0B113
	private Vector right_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveBoxInfo> Parser { get => default; } // 0x000000018164F8C0-0x000000018164F950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018164F330-0x000000018164F3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018164EC40-0x000000018164ECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018164D960-0x000000018164D9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018164FF10-0x0000000181650000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018164FC20-0x000000018164FC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018164F500-0x000000018164F5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018164FEC0-0x000000018164FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018164ED60-0x000000018164EE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Id { get => default; set {} } // 0x000000018164EBA0-0x000000018164EC40 0x000000018164F950-0x000000018164F9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x000000018164F460-0x000000018164F500 0x000000018164D9C0-0x000000018164DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x000000018164D620-0x000000018164D6C0 0x000000018164F290-0x000000018164F330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Extents { get => default; set {} } // 0x000000018164F6E0-0x000000018164F780 0x0000000181650000-0x00000001816500A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Up { get => default; set {} } // 0x000000018164DA60-0x000000018164DB00 0x00000001816500A0-0x0000000181650140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Forward { get => default; set {} } // 0x000000018164DF40-0x000000018164DFE0 0x000000018164F780-0x000000018164F820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Right { get => default; set {} } // 0x000000018164F3C0-0x000000018164F460 0x000000018164F820-0x000000018164F8C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveBoxInfo() {} // 0x0000000181650640-0x00000001816506A0
	static MassiveBoxInfo() {} // 0x0000000181650580-0x0000000181650640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveBoxInfo Clone() => default; // 0x000000018164F5F0-0x000000018164F6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveBoxInfo ShallowCopy() => default; // 0x000000018164ECC0-0x000000018164ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018164DE70-0x000000018164DF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018164FA80-0x000000018164FB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018164FB50-0x000000018164FC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018164DFE0-0x000000018164E410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018164E410-0x000000018164E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveBoxInfo other) => default; // 0x000000018164E4E0-0x000000018164E6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018164EE50-0x000000018164F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181650140-0x0000000181650580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018164FC80-0x000000018164FEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018164E6F0-0x000000018164EBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveBoxInfo other) {} // 0x000000018164DB00-0x000000018164DE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018164D6C0-0x000000018164D960
}

