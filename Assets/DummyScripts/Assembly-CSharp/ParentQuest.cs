/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ParentQuest : MessageBase, IMessage<ParentQuest> // TypeDefIndex: 24574
{
	// Fields
	private static readonly MessageParser<ParentQuest> _parser; // 0x00
	public const int ParentQuestIdFieldNumber = 1; // Metadata: 0x00B06BD7
	private uint parentQuestId_; // 0x18
	public const int ChildQuestListFieldNumber = 2; // Metadata: 0x00B06BDB
	private static readonly FieldCodec<ChildQuest> _repeated_childQuestList_codec; // 0x08
	private readonly RepeatedMessageField<ChildQuest> childQuestList_; // 0x20
	public const int IsFinishedFieldNumber = 3; // Metadata: 0x00B06BDF
	private bool isFinished_; // 0x28
	public const int IsRandomFieldNumber = 4; // Metadata: 0x00B06BE3
	private bool isRandom_; // 0x29
	public const int RandomInfoFieldNumber = 5; // Metadata: 0x00B06BE7
	private ParentQuestRandomInfo randomInfo_; // 0x30
	public const int QuestVarFieldNumber = 6; // Metadata: 0x00B06BEB
	private static readonly FieldCodec<int> _repeated_questVar_codec; // 0x10
	private readonly RepeatedPrimitiveField<int> questVar_; // 0x38
	public const int ParentQuestStateFieldNumber = 7; // Metadata: 0x00B06BEF
	private uint parentQuestState_; // 0x40
	public const int QuestVarSeqFieldNumber = 8; // Metadata: 0x00B06BF3
	private uint questVarSeq_; // 0x44

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ParentQuest> Parser { get => default; } // 0x0000000181C8EEE0-0x0000000181C8EF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C8E990-0x0000000181C8EA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C8E4F0-0x0000000181C8E570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C8D6A0-0x0000000181C8D700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C8F600-0x0000000181C8F6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C8F1E0-0x0000000181C8F240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C8EAC0-0x0000000181C8EBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C8F5B0-0x0000000181C8F600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C8E610-0x0000000181C8E700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000181C8DD40-0x0000000181C8DDE0 0x0000000181C8EA20-0x0000000181C8EAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChildQuest> ChildQuestList { get => default; } // 0x0000000181C8D990-0x0000000181C8D9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x0000000181C8ED40-0x0000000181C8EDE0 0x0000000181C8DCA0-0x0000000181C8DD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRandom { get => default; set {} } // 0x0000000181C8DE80-0x0000000181C8DF20 0x0000000181C8F140-0x0000000181C8F1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuestRandomInfo RandomInfo { get => default; set {} } // 0x0000000181C8EDE0-0x0000000181C8EE80 0x0000000181C8F6F0-0x0000000181C8F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> QuestVar { get => default; } // 0x0000000181C8EE80-0x0000000181C8EEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestState { get => default; set {} } // 0x0000000181C8ECA0-0x0000000181C8ED40 0x0000000181C8DDE0-0x0000000181C8DE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestVarSeq { get => default; set {} } // 0x0000000181C8F790-0x0000000181C8F830 0x0000000181C8F510-0x0000000181C8F5B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuest() {} // 0x0000000181C8FE60-0x0000000181C8FF10
	static ParentQuest() {} // 0x0000000181C8FD30-0x0000000181C8FE60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuest Clone() => default; // 0x0000000181C8EBB0-0x0000000181C8ECA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParentQuest ShallowCopy() => default; // 0x0000000181C8E570-0x0000000181C8E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C8D9F0-0x0000000181C8DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C8F000-0x0000000181C8F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C8F0A0-0x0000000181C8F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C8DA70-0x0000000181C8DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C8E120-0x0000000181C8E1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ParentQuest other) => default; // 0x0000000181C8DF20-0x0000000181C8E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C8E700-0x0000000181C8E990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C8F830-0x0000000181C8FD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C8F240-0x0000000181C8F510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C8E1F0-0x0000000181C8E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ParentQuest other) {} // 0x0000000181C8D700-0x0000000181C8D990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C8D3F0-0x0000000181C8D6A0
}

