/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ParentQuestRandomInfo : MessageBase, IMessage<ParentQuestRandomInfo> // TypeDefIndex: 24573
{
	// Fields
	private static readonly MessageParser<ParentQuestRandomInfo> _parser; // 0x00
	public const int EntranceIdFieldNumber = 1; // Metadata: 0x00B06BCB
	private uint entranceId_; // 0x18
	public const int TemplateIdFieldNumber = 2; // Metadata: 0x00B06BCF
	private uint templateId_; // 0x1C
	public const int FactorListFieldNumber = 3; // Metadata: 0x00B06BD3
	private static readonly FieldCodec<uint> _repeated_factorList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> factorList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ParentQuestRandomInfo> Parser { get => default; } // 0x0000000184269B90-0x0000000184269C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184269880-0x0000000184269910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184269540-0x00000001842695C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184268D80-0x0000000184268DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018426A070-0x000000018426A160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184269D50-0x0000000184269DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184269910-0x0000000184269A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184269F80-0x0000000184269FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184269660-0x0000000184269750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntranceId { get => default; set {} } // 0x0000000184269FD0-0x000000018426A070 0x0000000184269AF0-0x0000000184269B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TemplateId { get => default; set {} } // 0x0000000184269100-0x00000001842691A0 0x0000000184268DE0-0x0000000184268E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FactorList { get => default; } // 0x0000000184269F20-0x0000000184269F80 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuestRandomInfo() {} // 0x000000018426A4B0-0x000000018426A540
	static ParentQuestRandomInfo() {} // 0x000000018426A3D0-0x000000018426A4B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuestRandomInfo Clone() => default; // 0x0000000184269A00-0x0000000184269AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuestRandomInfo ShallowCopy() => default; // 0x00000001842695C0-0x0000000184269660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184268FE0-0x0000000184269030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184269CB0-0x0000000184269D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184269D00-0x0000000184269D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184269030-0x0000000184269100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842692E0-0x00000001842693B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ParentQuestRandomInfo other) => default; // 0x00000001842691A0-0x00000001842692E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184269750-0x0000000184269880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018426A160-0x000000018426A3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184269DB0-0x0000000184269F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842693B0-0x0000000184269540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ParentQuestRandomInfo other) {} // 0x0000000184268E80-0x0000000184268FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184268C00-0x0000000184268D80
}

