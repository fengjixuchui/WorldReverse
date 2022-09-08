/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcTalkRsp : MessageBase, IMessage<NpcTalkRsp> // TypeDefIndex: 24204
{
	// Fields
	private static readonly MessageParser<NpcTalkRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05D7F
	private int retcode_; // 0x18
	public const int NpcEntityIdFieldNumber = 2; // Metadata: 0x00B05D83
	private uint npcEntityId_; // 0x1C
	public const int CurTalkIdFieldNumber = 4; // Metadata: 0x00B05D87
	private uint curTalkId_; // 0x20
	public const int EntityIdFieldNumber = 5; // Metadata: 0x00B05D8B
	private uint entityId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<NpcTalkRsp> Parser { get => default; } // 0x0000000183FCF930-0x0000000183FCF9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FCF6C0-0x0000000183FCF750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FCF350-0x0000000183FCF3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FCEA20-0x0000000183FCEA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FCFDE0-0x0000000183FCFED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FCFB90-0x0000000183FCFBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FCF750-0x0000000183FCF840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FCFD90-0x0000000183FCFDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FCF470-0x0000000183FCF560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183FCF2B0-0x0000000183FCF350 0x0000000183FCECE0-0x0000000183FCED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcEntityId { get => default; set {} } // 0x0000000183FCFF70-0x0000000183FD0010 0x0000000183FCED80-0x0000000183FCEE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurTalkId { get => default; set {} } // 0x0000000183FCF210-0x0000000183FCF2B0 0x0000000183FD0010-0x0000000183FD00B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183FCFAF0-0x0000000183FCFB90 0x0000000183FCFED0-0x0000000183FCFF70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24205
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24206
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 502
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkRsp() {} // 0x0000000183FD0490-0x0000000183FD04F0
	static NpcTalkRsp() {} // 0x0000000183FD03D0-0x0000000183FD0490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkRsp Clone() => default; // 0x0000000183FCF840-0x0000000183FCF930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkRsp ShallowCopy() => default; // 0x0000000183FCF3D0-0x0000000183FCF470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FCEC00-0x0000000183FCEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCFA50-0x0000000183FCFAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCFAA0-0x0000000183FCFAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FCEC50-0x0000000183FCECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FCEF70-0x0000000183FCF040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(NpcTalkRsp other) => default; // 0x0000000183FCEE20-0x0000000183FCEF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FCF560-0x0000000183FCF6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FD00B0-0x0000000183FD03D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FCFBF0-0x0000000183FCFD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FCF040-0x0000000183FCF210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(NpcTalkRsp other) {} // 0x0000000183FCEA80-0x0000000183FCEC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FCE8F0-0x0000000183FCEA20
}

