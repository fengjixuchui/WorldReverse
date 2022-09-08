/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestCreateEntityRsp : MessageBase, IMessage<QuestCreateEntityRsp> // TypeDefIndex: 24596
{
	// Fields
	private static readonly MessageParser<QuestCreateEntityRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06CAF
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B06CB3
	private uint entityId_; // 0x1C
	public const int EntityFieldNumber = 3; // Metadata: 0x00B06CB7
	private CreateEntityInfo entity_; // 0x20
	public const int QuestIdFieldNumber = 7; // Metadata: 0x00B06CBB
	private uint questId_; // 0x28
	public const int IsRewindFieldNumber = 8; // Metadata: 0x00B06CBF
	private bool isRewind_; // 0x2C
	public const int ParentQuestIdFieldNumber = 9; // Metadata: 0x00B06CC3
	private uint parentQuestId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestCreateEntityRsp> Parser { get => default; } // 0x00000001850B6BB0-0x00000001850B6C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850B6800-0x00000001850B6890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850B63B0-0x00000001850B6430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850B55F0-0x00000001850B5650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850B7130-0x00000001850B7220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850B6E70-0x00000001850B6ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850B6930-0x00000001850B6A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850B70E0-0x00000001850B7130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850B64D0-0x00000001850B65C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001850B61D0-0x00000001850B6270 0x00000001850B5B90-0x00000001850B5C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001850B6DD0-0x00000001850B6E70 0x00000001850B7220-0x00000001850B72C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo Entity { get => default; set {} } // 0x00000001850B5AF0-0x00000001850B5B90 0x00000001850B6270-0x00000001850B6310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x00000001850B5550-0x00000001850B55F0 0x00000001850B6310-0x00000001850B63B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRewind { get => default; set {} } // 0x00000001850B6B10-0x00000001850B6BB0 0x00000001850B5650-0x00000001850B56F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x00000001850B5C30-0x00000001850B5CD0 0x00000001850B6890-0x00000001850B6930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24597
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24598
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 411
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityRsp() {} // 0x00000001850B7790-0x00000001850B77F0
	static QuestCreateEntityRsp() {} // 0x00000001850B76D0-0x00000001850B7790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityRsp Clone() => default; // 0x00000001850B6A20-0x00000001850B6B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestCreateEntityRsp ShallowCopy() => default; // 0x00000001850B6430-0x00000001850B64D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850B5910-0x00000001850B5990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850B6CD0-0x00000001850B6D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850B6D50-0x00000001850B6DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850B5990-0x00000001850B5AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850B5E80-0x00000001850B5F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestCreateEntityRsp other) => default; // 0x00000001850B5CD0-0x00000001850B5E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850B65C0-0x00000001850B6800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850B72C0-0x00000001850B76D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850B6ED0-0x00000001850B70E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850B5F50-0x00000001850B61D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestCreateEntityRsp other) {} // 0x00000001850B56F0-0x00000001850B5910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850B53A0-0x00000001850B5550
}

