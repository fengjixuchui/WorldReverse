/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestVarOp : MessageBase, IMessage<QuestVarOp> // TypeDefIndex: 24613
{
	// Fields
	private static readonly MessageParser<QuestVarOp> _parser; // 0x00
	public const int IndexFieldNumber = 1; // Metadata: 0x00B06D63
	private uint index_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B06D67
	private int value_; // 0x1C
	public const int IsAddFieldNumber = 3; // Metadata: 0x00B06D6B
	private bool isAdd_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestVarOp> Parser { get => default; } // 0x00000001843504F0-0x0000000184350580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843501E0-0x0000000184350270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018434FE00-0x000000018434FE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018434F770-0x000000018434F7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184350A00-0x0000000184350AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843507F0-0x0000000184350850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184350310-0x0000000184350400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843509B0-0x0000000184350A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018434FF20-0x0000000184350010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x000000018434FD60-0x000000018434FE00 0x0000000184350140-0x00000001843501E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Value { get => default; set {} } // 0x0000000184350270-0x0000000184350310 0x0000000184350700-0x00000001843507A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAdd { get => default; set {} } // 0x000000018434F6D0-0x000000018434F770 0x0000000184350610-0x00000001843506B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestVarOp() {} // 0x0000000184350E40-0x0000000184350EA0
	static QuestVarOp() {} // 0x0000000184350D80-0x0000000184350E40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestVarOp Clone() => default; // 0x0000000184350400-0x00000001843504F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestVarOp ShallowCopy() => default; // 0x000000018434FE80-0x000000018434FF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018434F930-0x000000018434F980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843506B0-0x0000000184350700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843507A0-0x00000001843507F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018434F980-0x000000018434FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018434FB40-0x000000018434FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestVarOp other) => default; // 0x000000018434FA00-0x000000018434FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184350010-0x0000000184350140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184350AF0-0x0000000184350D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184350850-0x00000001843509B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018434FC10-0x000000018434FD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestVarOp other) {} // 0x000000018434F7D0-0x000000018434F930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018434F5C0-0x000000018434F6D0
}

