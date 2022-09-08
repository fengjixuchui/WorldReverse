/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestUpdateQuestVarRsp : MessageBase, IMessage<QuestUpdateQuestVarRsp> // TypeDefIndex: 24617
{
	// Fields
	private static readonly MessageParser<QuestUpdateQuestVarRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06D93
	private int retcode_; // 0x18
	public const int QuestIdFieldNumber = 2; // Metadata: 0x00B06D97
	private uint questId_; // 0x1C
	public const int ParentQuestIdFieldNumber = 3; // Metadata: 0x00B06D9B
	private uint parentQuestId_; // 0x20
	public const int ParentQuestVarSeqFieldNumber = 4; // Metadata: 0x00B06D9F
	private uint parentQuestVarSeq_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestUpdateQuestVarRsp> Parser { get => default; } // 0x00000001834969D0-0x0000000183496A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183496620-0x00000001834966B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001834962B0-0x0000000183496330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183495980-0x00000001834959E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183496E80-0x0000000183496F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183496C30-0x0000000183496C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001834967F0-0x00000001834968E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183496E30-0x0000000183496E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001834963D0-0x00000001834964C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183496170-0x0000000183496210 0x0000000183495C40-0x0000000183495CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x00000001834958E0-0x0000000183495980 0x0000000183496210-0x00000001834962B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000183495CE0-0x0000000183495D80 0x00000001834966B0-0x0000000183496750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestVarSeq { get => default; set {} } // 0x0000000183496AF0-0x0000000183496B90 0x0000000183496750-0x00000001834967F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24618
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24619
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 419
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarRsp() {} // 0x0000000183497350-0x00000001834973B0
	static QuestUpdateQuestVarRsp() {} // 0x0000000183497290-0x0000000183497350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarRsp Clone() => default; // 0x00000001834968E0-0x00000001834969D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestUpdateQuestVarRsp ShallowCopy() => default; // 0x0000000183496330-0x00000001834963D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183495B60-0x0000000183495BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183496B90-0x0000000183496BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183496BE0-0x0000000183496C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183495BB0-0x0000000183495C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183495D80-0x0000000183495E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestUpdateQuestVarRsp other) => default; // 0x0000000183495E50-0x0000000183495FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001834964C0-0x0000000183496620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183496F70-0x0000000183497290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183496C90-0x0000000183496E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183495FA0-0x0000000183496170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestUpdateQuestVarRsp other) {} // 0x00000001834959E0-0x0000000183495B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834957B0-0x00000001834958E0
}

