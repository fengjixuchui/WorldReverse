/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestCreateEntityReq : MessageBase, IMessage<QuestCreateEntityReq> // TypeDefIndex: 24593
{
	// Fields
	private static readonly MessageParser<QuestCreateEntityReq> _parser; // 0x00
	public const int EntityFieldNumber = 1; // Metadata: 0x00B06C8B
	private CreateEntityInfo entity_; // 0x18
	public const int QuestIdFieldNumber = 2; // Metadata: 0x00B06C8F
	private uint questId_; // 0x20
	public const int IsRewindFieldNumber = 3; // Metadata: 0x00B06C93
	private bool isRewind_; // 0x24
	public const int ParentQuestIdFieldNumber = 4; // Metadata: 0x00B06C97
	private uint parentQuestId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestCreateEntityReq> Parser { get => default; } // 0x0000000182A54290-0x0000000182A54320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A53EE0-0x0000000182A53F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A53AF0-0x0000000182A53B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A52F90-0x0000000182A52FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A54700-0x0000000182A547F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A544B0-0x0000000182A54510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A54010-0x0000000182A54100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A546B0-0x0000000182A54700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A53C10-0x0000000182A53D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo Entity { get => default; set {} } // 0x0000000182A53440-0x0000000182A534E0 0x0000000182A539B0-0x0000000182A53A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000182A52EF0-0x0000000182A52F90 0x0000000182A53A50-0x0000000182A53AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRewind { get => default; set {} } // 0x0000000182A541F0-0x0000000182A54290 0x0000000182A52FF0-0x0000000182A53090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000182A534E0-0x0000000182A53580 0x0000000182A53F70-0x0000000182A54010

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24594
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24595
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 410
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityReq() {} // 0x0000000182A54BB0-0x0000000182A54C10
	static QuestCreateEntityReq() {} // 0x0000000182A54AF0-0x0000000182A54BB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityReq Clone() => default; // 0x0000000182A54100-0x0000000182A541F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityReq ShallowCopy() => default; // 0x0000000182A53B70-0x0000000182A53C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A53270-0x0000000182A532F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A543B0-0x0000000182A54430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A54430-0x0000000182A544B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A532F0-0x0000000182A53440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A53580-0x0000000182A53650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestCreateEntityReq other) => default; // 0x0000000182A53650-0x0000000182A537C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A53D00-0x0000000182A53EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A547F0-0x0000000182A54AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A54510-0x0000000182A546B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A537C0-0x0000000182A539B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestCreateEntityReq other) {} // 0x0000000182A53090-0x0000000182A53270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A52D80-0x0000000182A52EF0
}

