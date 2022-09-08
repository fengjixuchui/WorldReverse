/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestUpdateQuestVarNotify : MessageBase, IMessage<QuestUpdateQuestVarNotify> // TypeDefIndex: 24620
{
	// Fields
	private static readonly MessageParser<QuestUpdateQuestVarNotify> _parser; // 0x00
	public const int ParentQuestIdFieldNumber = 1; // Metadata: 0x00B06DB3
	private uint parentQuestId_; // 0x18
	public const int QuestVarFieldNumber = 2; // Metadata: 0x00B06DB7
	private static readonly FieldCodec<int> _repeated_questVar_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> questVar_; // 0x20
	public const int ParentQuestVarSeqFieldNumber = 3; // Metadata: 0x00B06DBB
	private uint parentQuestVarSeq_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestUpdateQuestVarNotify> Parser { get => default; } // 0x00000001822E6760-0x00000001822E67F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822E6350-0x00000001822E63E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822E6010-0x00000001822E6090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822E58E0-0x00000001822E5940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822E6BF0-0x00000001822E6CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822E69C0-0x00000001822E6A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822E6520-0x00000001822E6610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822E6BA0-0x00000001822E6BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822E6130-0x00000001822E6220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x00000001822E5BD0-0x00000001822E5C70 0x00000001822E63E0-0x00000001822E6480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> QuestVar { get => default; } // 0x00000001822E6700-0x00000001822E6760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestVarSeq { get => default; set {} } // 0x00000001822E6880-0x00000001822E6920 0x00000001822E6480-0x00000001822E6520

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24621
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24622
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 420
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarNotify() {} // 0x00000001822E7030-0x00000001822E70C0
	static QuestUpdateQuestVarNotify() {} // 0x00000001822E6F50-0x00000001822E7030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarNotify Clone() => default; // 0x00000001822E6610-0x00000001822E6700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarNotify ShallowCopy() => default; // 0x00000001822E6090-0x00000001822E6130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822E5AA0-0x00000001822E5AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822E6920-0x00000001822E6970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822E6970-0x00000001822E69C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822E5AF0-0x00000001822E5BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822E5C70-0x00000001822E5D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestUpdateQuestVarNotify other) => default; // 0x00000001822E5D40-0x00000001822E5E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822E6220-0x00000001822E6350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822E6CE0-0x00000001822E6F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822E6A20-0x00000001822E6BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822E5E80-0x00000001822E6010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestUpdateQuestVarNotify other) {} // 0x00000001822E5940-0x00000001822E5AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822E5760-0x00000001822E58E0
}

