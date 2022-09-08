/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestUpdateQuestVarReq : MessageBase, IMessage<QuestUpdateQuestVarReq> // TypeDefIndex: 24614
{
	// Fields
	private static readonly MessageParser<QuestUpdateQuestVarReq> _parser; // 0x00
	public const int QuestIdFieldNumber = 1; // Metadata: 0x00B06D6F
	private uint questId_; // 0x18
	public const int QuestVarOpListFieldNumber = 2; // Metadata: 0x00B06D73
	private static readonly FieldCodec<QuestVarOp> _repeated_questVarOpList_codec; // 0x08
	private readonly RepeatedMessageField<QuestVarOp> questVarOpList_; // 0x20
	public const int ParentQuestIdFieldNumber = 3; // Metadata: 0x00B06D77
	private uint parentQuestId_; // 0x28
	public const int ParentQuestVarSeqFieldNumber = 4; // Metadata: 0x00B06D7B
	private uint parentQuestVarSeq_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestUpdateQuestVarReq> Parser { get => default; } // 0x000000018167ED50-0x000000018167EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018167E9A0-0x000000018167EA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018167E630-0x000000018167E6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018167DD10-0x000000018167DD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018167F2A0-0x000000018167F390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018167F030-0x000000018167F090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018167EB70-0x000000018167EC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018167F250-0x000000018167F2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018167E750-0x000000018167E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x000000018167DC70-0x000000018167DD10 0x000000018167E590-0x000000018167E630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<QuestVarOp> QuestVarOpList { get => default; } // 0x000000018167DF20-0x000000018167DF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x000000018167E0D0-0x000000018167E170 0x000000018167EA30-0x000000018167EAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestVarSeq { get => default; set {} } // 0x000000018167EE70-0x000000018167EF10 0x000000018167EAD0-0x000000018167EB70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24615
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24616
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 418
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarReq() {} // 0x000000018167F7A0-0x000000018167F830
	static QuestUpdateQuestVarReq() {} // 0x000000018167F690-0x000000018167F7A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarReq Clone() => default; // 0x000000018167EC60-0x000000018167ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarReq ShallowCopy() => default; // 0x000000018167E6B0-0x000000018167E750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018167DF80-0x000000018167DFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018167EF10-0x000000018167EFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018167EFA0-0x000000018167F030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018167DFD0-0x000000018167E0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018167E2E0-0x000000018167E3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestUpdateQuestVarReq other) => default; // 0x000000018167E170-0x000000018167E2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018167E840-0x000000018167E9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018167F390-0x000000018167F690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018167F090-0x000000018167F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018167E3B0-0x000000018167E590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestUpdateQuestVarReq other) {} // 0x000000018167DD70-0x000000018167DF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018167DAD0-0x000000018167DC70
}

