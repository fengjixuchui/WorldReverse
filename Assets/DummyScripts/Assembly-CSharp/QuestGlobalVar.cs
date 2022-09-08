/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestGlobalVar : MessageBase, IMessage<QuestGlobalVar> // TypeDefIndex: 24657
{
	// Fields
	private static readonly MessageParser<QuestGlobalVar> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00B06EF7
	private uint key_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B06EFB
	private int value_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestGlobalVar> Parser { get => default; } // 0x000000018452E290-0x000000018452E320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018452DF80-0x000000018452E010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018452DC70-0x000000018452DCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018452D660-0x000000018452D6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018452E6C0-0x000000018452E7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018452E4F0-0x000000018452E550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018452E0B0-0x000000018452E1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018452E670-0x000000018452E6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018452DD90-0x000000018452DE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Key { get => default; set {} } // 0x000000018452E7B0-0x000000018452E850 0x000000018452D6C0-0x000000018452D760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Value { get => default; set {} } // 0x000000018452E010-0x000000018452E0B0 0x000000018452E400-0x000000018452E4A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVar() {} // 0x000000018452EB10-0x000000018452EB70
	static QuestGlobalVar() {} // 0x000000018452EA50-0x000000018452EB10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVar Clone() => default; // 0x000000018452E1A0-0x000000018452E290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVar ShallowCopy() => default; // 0x000000018452DCF0-0x000000018452DD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018452D890-0x000000018452D8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018452E3B0-0x000000018452E400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018452E4A0-0x000000018452E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018452D8E0-0x000000018452D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018452D950-0x000000018452DA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestGlobalVar other) => default; // 0x000000018452DA20-0x000000018452DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018452DE80-0x000000018452DF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018452E850-0x000000018452EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018452E550-0x000000018452E670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018452DB40-0x000000018452DC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestGlobalVar other) {} // 0x000000018452D760-0x000000018452D890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018452D560-0x000000018452D660
}

