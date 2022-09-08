/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionStartReq : MessageBase, IMessage<ExpeditionStartReq> // TypeDefIndex: 22167
{
	// Fields
	private static readonly MessageParser<ExpeditionStartReq> _parser; // 0x00
	public const int PathIdFieldNumber = 1; // Metadata: 0x00B00F43
	private uint pathId_; // 0x18
	public const int AvatarIdListFieldNumber = 2; // Metadata: 0x00B00F47
	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> avatarIdList_; // 0x20
	public const int AssistUidFieldNumber = 3; // Metadata: 0x00B00F4B
	private uint assistUid_; // 0x28
	public const int AssistAvatarIdFieldNumber = 4; // Metadata: 0x00B00F4F
	private uint assistAvatarId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionStartReq> Parser { get => default; } // 0x00000001818F65B0-0x00000001818F6640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818F62A0-0x00000001818F6330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818F5F30-0x00000001818F5FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818F5660-0x00000001818F56C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818F6B20-0x00000001818F6C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818F6810-0x00000001818F6870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818F6330-0x00000001818F6420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818F6AD0-0x00000001818F6B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818F6050-0x00000001818F6140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PathId { get => default; set {} } // 0x00000001818F5980-0x00000001818F5A20 0x00000001818F55C0-0x00000001818F5660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AvatarIdList { get => default; } // 0x00000001818F5ED0-0x00000001818F5F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistUid { get => default; set {} } // 0x00000001818F6A30-0x00000001818F6AD0 0x00000001818F6510-0x00000001818F65B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistAvatarId { get => default; set {} } // 0x00000001818F66D0-0x00000001818F6770 0x00000001818F5E30-0x00000001818F5ED0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22168
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22169
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2161
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartReq() {} // 0x00000001818F6FF0-0x00000001818F7080
	static ExpeditionStartReq() {} // 0x00000001818F6F10-0x00000001818F6FF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartReq Clone() => default; // 0x00000001818F6420-0x00000001818F6510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartReq ShallowCopy() => default; // 0x00000001818F5FB0-0x00000001818F6050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818F5840-0x00000001818F5890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818F6770-0x00000001818F67C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818F67C0-0x00000001818F6810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818F5890-0x00000001818F5980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818F5A20-0x00000001818F5AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionStartReq other) => default; // 0x00000001818F5AF0-0x00000001818F5C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818F6140-0x00000001818F62A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818F6C10-0x00000001818F6F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818F6870-0x00000001818F6A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818F5C50-0x00000001818F5E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionStartReq other) {} // 0x00000001818F56C0-0x00000001818F5840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818F5420-0x00000001818F55C0
}

