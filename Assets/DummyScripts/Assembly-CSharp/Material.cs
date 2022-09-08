/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Material : MessageBase, IMessage<Material> // TypeDefIndex: 25980
{
	// Fields
	private static readonly MessageParser<Material> _parser; // 0x00
	public const int CountFieldNumber = 1; // Metadata: 0x00B0A8D7
	private uint count_; // 0x18
	public const int DeleteInfoFieldNumber = 2; // Metadata: 0x00B0A8DB
	private MaterialDeleteInfo deleteInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Material> Parser { get => default; } // 0x00000001851F6D20-0x00000001851F6DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851F6AB0-0x00000001851F6B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851F6720-0x00000001851F67A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851F5F50-0x00000001851F5FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851F71B0-0x00000001851F72A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851F6FE0-0x00000001851F7040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851F6B40-0x00000001851F6C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851F7160-0x00000001851F71B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851F6840-0x00000001851F6930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x00000001851F6E40-0x00000001851F6EE0 0x00000001851F5EB0-0x00000001851F5F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteInfo DeleteInfo { get => default; set {} } // 0x00000001851F6130-0x00000001851F61D0 0x00000001851F5E10-0x00000001851F5EB0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Material() {} // 0x00000001851F7540-0x00000001851F75A0
	static Material() {} // 0x00000001851F7480-0x00000001851F7540

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Material Clone() => default; // 0x00000001851F6C30-0x00000001851F6D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Material ShallowCopy() => default; // 0x00000001851F67A0-0x00000001851F6840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851F61D0-0x00000001851F6250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851F6EE0-0x00000001851F6F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851F6F60-0x00000001851F6FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851F6250-0x00000001851F6380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851F64B0-0x00000001851F6580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Material other) => default; // 0x00000001851F6380-0x00000001851F64B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851F6930-0x00000001851F6AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851F72A0-0x00000001851F7480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851F7040-0x00000001851F7160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851F6580-0x00000001851F6720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Material other) {} // 0x00000001851F5FB0-0x00000001851F6130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851F5CD0-0x00000001851F5E10
}

