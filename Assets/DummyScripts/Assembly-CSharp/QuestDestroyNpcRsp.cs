/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestDestroyNpcRsp : MessageBase, IMessage<QuestDestroyNpcRsp> // TypeDefIndex: 24626
{
	// Fields
	private static readonly MessageParser<QuestDestroyNpcRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06DEB
	private int retcode_; // 0x18
	public const int NpcIdFieldNumber = 2; // Metadata: 0x00B06DEF
	private uint npcId_; // 0x1C
	public const int ParentQuestIdFieldNumber = 3; // Metadata: 0x00B06DF3
	private uint parentQuestId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestDestroyNpcRsp> Parser { get => default; } // 0x00000001845D5240-0x00000001845D52D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845D4E90-0x00000001845D4F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845D4AB0-0x00000001845D4B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845D42B0-0x00000001845D4310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845D5610-0x00000001845D5700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845D5400-0x00000001845D5460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845D5060-0x00000001845D5150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845D55C0-0x00000001845D5610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845D4C70-0x00000001845D4D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001845D4A10-0x00000001845D4AB0 0x00000001845D4540-0x00000001845D45E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcId { get => default; set {} } // 0x00000001845D4FC0-0x00000001845D5060 0x00000001845D4B30-0x00000001845D4BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x00000001845D45E0-0x00000001845D4680 0x00000001845D4F20-0x00000001845D4FC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24627
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24628
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 422
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcRsp() {} // 0x00000001845D5A50-0x00000001845D5AB0
	static QuestDestroyNpcRsp() {} // 0x00000001845D5990-0x00000001845D5A50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcRsp Clone() => default; // 0x00000001845D5150-0x00000001845D5240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestDestroyNpcRsp ShallowCopy() => default; // 0x00000001845D4BD0-0x00000001845D4C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845D4470-0x00000001845D44C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D5360-0x00000001845D53B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845D53B0-0x00000001845D5400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845D44C0-0x00000001845D4540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845D47C0-0x00000001845D4890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestDestroyNpcRsp other) => default; // 0x00000001845D4680-0x00000001845D47C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845D4D60-0x00000001845D4E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845D5700-0x00000001845D5990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845D5460-0x00000001845D55C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845D4890-0x00000001845D4A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestDestroyNpcRsp other) {} // 0x00000001845D4310-0x00000001845D4470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845D41A0-0x00000001845D42B0
}

