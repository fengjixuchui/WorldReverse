/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcTalkReq : MessageBase, IMessage<NpcTalkReq> // TypeDefIndex: 24201
{
	// Fields
	private static readonly MessageParser<NpcTalkReq> _parser; // 0x00
	public const int NpcEntityIdFieldNumber = 1; // Metadata: 0x00B05D5F
	private uint npcEntityId_; // 0x18
	public const int TalkIdFieldNumber = 3; // Metadata: 0x00B05D63
	private uint talkId_; // 0x1C
	public const int EntityIdFieldNumber = 4; // Metadata: 0x00B05D67
	private uint entityId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<NpcTalkReq> Parser { get => default; } // 0x0000000183EE4F50-0x0000000183EE4FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EE4CE0-0x0000000183EE4D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EE49A0-0x0000000183EE4A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EE42E0-0x0000000183EE4340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EE53C0-0x0000000183EE54B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EE51B0-0x0000000183EE5210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EE4D70-0x0000000183EE4E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EE5370-0x0000000183EE53C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EE4AC0-0x0000000183EE4BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcEntityId { get => default; set {} } // 0x0000000183EE5550-0x0000000183EE55F0 0x0000000183EE4570-0x0000000183EE4610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalkId { get => default; set {} } // 0x0000000183EE4090-0x0000000183EE4130 0x0000000183EE4240-0x0000000183EE42E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183EE5110-0x0000000183EE51B0 0x0000000183EE54B0-0x0000000183EE5550

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24202
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24203
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 501
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkReq() {} // 0x0000000183EE5940-0x0000000183EE6320
	static NpcTalkReq() {} // 0x0000000183EE5880-0x0000000183EE5940

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkReq Clone() => default; // 0x0000000183EE4E60-0x0000000183EE4F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcTalkReq ShallowCopy() => default; // 0x0000000183EE4A20-0x0000000183EE4AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EE44A0-0x0000000183EE44F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EE5070-0x0000000183EE50C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EE50C0-0x0000000183EE5110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EE44F0-0x0000000183EE4570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EE4610-0x0000000183EE46E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(NpcTalkReq other) => default; // 0x0000000183EE46E0-0x0000000183EE4820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EE4BB0-0x0000000183EE4CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EE55F0-0x0000000183EE5880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EE5210-0x0000000183EE5370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EE4820-0x0000000183EE49A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(NpcTalkReq other) {} // 0x0000000183EE4340-0x0000000183EE44A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EE4130-0x0000000183EE4240
}

