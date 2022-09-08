/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveEntityState : MessageBase, IMessage<MassiveEntityState> // TypeDefIndex: 26091
{
	// Fields
	private static readonly MessageParser<MassiveEntityState> _parser; // 0x00
	public const int EntityTypeFieldNumber = 1; // Metadata: 0x00B0B18B
	private uint entityType_; // 0x18
	public const int ObjIdFieldNumber = 2; // Metadata: 0x00B0B18F
	private long objId_; // 0x20
	public const int ElementStateFieldNumber = 3; // Metadata: 0x00B0B193
	private uint elementState_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveEntityState> Parser { get => default; } // 0x0000000181DB87A0-0x0000000181DB8830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181DB8490-0x0000000181DB8520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181DB8140-0x0000000181DB81C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181DB7940-0x0000000181DB79A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DB8C10-0x0000000181DB8D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181DB8A00-0x0000000181DB8A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181DB8520-0x0000000181DB8610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DB8BC0-0x0000000181DB8C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181DB8260-0x0000000181DB8350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityType { get => default; set {} } // 0x0000000181DB7C40-0x0000000181DB7CE0 0x0000000181DB7A40-0x0000000181DB7AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long ObjId { get => default; set {} } // 0x0000000181DB79A0-0x0000000181DB7A40 0x0000000181DB8700-0x0000000181DB87A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ElementState { get => default; set {} } // 0x0000000181DB8960-0x0000000181DB8A00 0x0000000181DB78A0-0x0000000181DB7940

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityState() {} // 0x0000000181DB9050-0x0000000181DB90B0
	static MassiveEntityState() {} // 0x0000000181DB8F90-0x0000000181DB9050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityState Clone() => default; // 0x0000000181DB8610-0x0000000181DB8700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityState ShallowCopy() => default; // 0x0000000181DB81C0-0x0000000181DB8260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181DB7CE0-0x0000000181DB7D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DB88C0-0x0000000181DB8910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DB8910-0x0000000181DB8960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181DB7D30-0x0000000181DB7DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181DB7EF0-0x0000000181DB7FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveEntityState other) => default; // 0x0000000181DB7DB0-0x0000000181DB7EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181DB8350-0x0000000181DB8490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DB8D00-0x0000000181DB8F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181DB8A60-0x0000000181DB8BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181DB7FC0-0x0000000181DB8140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveEntityState other) {} // 0x0000000181DB7AE0-0x0000000181DB7C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181DB7790-0x0000000181DB78A0
}

