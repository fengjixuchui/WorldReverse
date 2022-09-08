/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TaskVar : MessageBase, IMessage<TaskVar> // TypeDefIndex: 24504
{
	// Fields
	private static readonly MessageParser<TaskVar> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00B06923
	private uint key_; // 0x18
	public const int ValueListFieldNumber = 2; // Metadata: 0x00B06927
	private static readonly FieldCodec<int> _repeated_valueList_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> valueList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TaskVar> Parser { get => default; } // 0x0000000183E210D0-0x0000000183E21160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E20E00-0x0000000183E20E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E20AF0-0x0000000183E20B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E20470-0x0000000183E204D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E21480-0x0000000183E21570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E21290-0x0000000183E212F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E20EF0-0x0000000183E20FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E21430-0x0000000183E21480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E20C10-0x0000000183E20D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Key { get => default; set {} } // 0x0000000183E21570-0x0000000183E21610 0x0000000183E204D0-0x0000000183E20570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> ValueList { get => default; } // 0x0000000183E20E90-0x0000000183E20EF0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TaskVar() {} // 0x0000000183E218D0-0x0000000183E21960
	static TaskVar() {} // 0x0000000183E217F0-0x0000000183E218D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TaskVar Clone() => default; // 0x0000000183E20FE0-0x0000000183E210D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TaskVar ShallowCopy() => default; // 0x0000000183E20B70-0x0000000183E20C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E206A0-0x0000000183E206F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E211F0-0x0000000183E21240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E21240-0x0000000183E21290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E206F0-0x0000000183E207B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E207B0-0x0000000183E20880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TaskVar other) => default; // 0x0000000183E20880-0x0000000183E209B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E20D00-0x0000000183E20E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E21610-0x0000000183E217F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E212F0-0x0000000183E21430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E209B0-0x0000000183E20AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TaskVar other) {} // 0x0000000183E20570-0x0000000183E206A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E20300-0x0000000183E20470
}

