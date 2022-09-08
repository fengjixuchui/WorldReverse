/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeStartReq : MessageBase, IMessage<ForgeStartReq> // TypeDefIndex: 23712
{
	// Fields
	private static readonly MessageParser<ForgeStartReq> _parser; // 0x00
	public const int ForgeIdFieldNumber = 1; // Metadata: 0x00B04AAB
	private uint forgeId_; // 0x18
	public const int ForgeCountFieldNumber = 2; // Metadata: 0x00B04AAF
	private uint forgeCount_; // 0x1C
	public const int AvatarIdFieldNumber = 3; // Metadata: 0x00B04AB3
	private uint avatarId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeStartReq> Parser { get => default; } // 0x00000001840BBA50-0x00000001840BBAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840BB7E0-0x00000001840BB870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840BB4A0-0x00000001840BB520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840BAC00-0x00000001840BAC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001840BBEC0-0x00000001840BBFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001840BBCB0-0x00000001840BBD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840BB870-0x00000001840BB960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840BBE70-0x00000001840BBEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840BB5C0-0x00000001840BB6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForgeId { get => default; set {} } // 0x00000001840BBB70-0x00000001840BBC10 0x00000001840BBFB0-0x00000001840BC050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForgeCount { get => default; set {} } // 0x00000001840BAE90-0x00000001840BAF30 0x00000001840BAF30-0x00000001840BAFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001840BB360-0x00000001840BB400 0x00000001840BB400-0x00000001840BB4A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23713
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23714
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 639
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeStartReq() {} // 0x00000001840BC3A0-0x00000001840BC400
	static ForgeStartReq() {} // 0x00000001840BC2E0-0x00000001840BC3A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeStartReq Clone() => default; // 0x00000001840BB960-0x00000001840BBA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeStartReq ShallowCopy() => default; // 0x00000001840BB520-0x00000001840BB5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001840BADC0-0x00000001840BAE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840BBC10-0x00000001840BBC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840BBC60-0x00000001840BBCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840BAE10-0x00000001840BAE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001840BAFD0-0x00000001840BB0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeStartReq other) => default; // 0x00000001840BB0A0-0x00000001840BB1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840BB6B0-0x00000001840BB7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001840BC050-0x00000001840BC2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001840BBD10-0x00000001840BBE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840BB1E0-0x00000001840BB360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeStartReq other) {} // 0x00000001840BAC60-0x00000001840BADC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001840BAAF0-0x00000001840BAC00
}

