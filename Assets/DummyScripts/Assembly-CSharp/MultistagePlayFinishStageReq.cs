/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayFinishStageReq : MessageBase, IMessage<MultistagePlayFinishStageReq> // TypeDefIndex: 24117
{
	// Fields
	private static readonly MessageParser<MultistagePlayFinishStageReq> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05A17
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05A1B
	private uint groupId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistagePlayFinishStageReq> Parser { get => default; } // 0x000000018473E280-0x000000018473E310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018473DED0-0x000000018473DF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018473DBC0-0x000000018473DC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018473D510-0x000000018473D570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018473E610-0x000000018473E700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018473E440-0x000000018473E4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018473E000-0x000000018473E0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018473E5C0-0x000000018473E610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018473DCE0-0x000000018473DDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x000000018473DA80-0x000000018473DB20 0x000000018473DF60-0x000000018473E000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x000000018473E0F0-0x000000018473E190 0x000000018473DB20-0x000000018473DBC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24118
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24119
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5302
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageReq() {} // 0x000000018473E9C0-0x000000018473EA20
	static MultistagePlayFinishStageReq() {} // 0x000000018473E900-0x000000018473E9C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageReq Clone() => default; // 0x000000018473E190-0x000000018473E280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageReq ShallowCopy() => default; // 0x000000018473DC40-0x000000018473DCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018473D6A0-0x000000018473D6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018473E3A0-0x000000018473E3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018473E3F0-0x000000018473E440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018473D6F0-0x000000018473D760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018473D760-0x000000018473D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistagePlayFinishStageReq other) => default; // 0x000000018473D830-0x000000018473D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018473DDD0-0x000000018473DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018473E700-0x000000018473E900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018473E4A0-0x000000018473E5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018473D950-0x000000018473DA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistagePlayFinishStageReq other) {} // 0x000000018473D570-0x000000018473D6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018473D410-0x000000018473D510
}

