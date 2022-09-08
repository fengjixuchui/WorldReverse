/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerFriendListRsp : MessageBase, IMessage<GetPlayerFriendListRsp> // TypeDefIndex: 25537
{
	// Fields
	private static readonly MessageParser<GetPlayerFriendListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09067
	private int retcode_; // 0x18
	public const int FriendListFieldNumber = 2; // Metadata: 0x00B0906B
	private static readonly FieldCodec<FriendBrief> _repeated_friendList_codec; // 0x08
	private readonly RepeatedMessageField<FriendBrief> friendList_; // 0x20
	public const int AskFriendListFieldNumber = 3; // Metadata: 0x00B0906F
	private static readonly FieldCodec<FriendBrief> _repeated_askFriendList_codec; // 0x10
	private readonly RepeatedMessageField<FriendBrief> askFriendList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerFriendListRsp> Parser { get => default; } // 0x000000018301F160-0x000000018301F1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018301EEF0-0x000000018301EF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018301EBC0-0x000000018301EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018301E370-0x000000018301E3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018301F640-0x000000018301F730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018301F420-0x000000018301F480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018301EF80-0x000000018301F070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018301F5F0-0x000000018301F640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018301ECE0-0x000000018301EDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018301EB20-0x000000018301EBC0 0x000000018301E6E0-0x000000018301E780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FriendBrief> FriendList { get => default; } // 0x000000018301F730-0x000000018301F790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FriendBrief> AskFriendList { get => default; } // 0x000000018301F1F0-0x000000018301F250 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25538
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25539
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4002
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerFriendListRsp() {} // 0x000000018301FB30-0x000000018301FCF0
	static GetPlayerFriendListRsp() {} // 0x000000018301F9F0-0x000000018301FB30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerFriendListRsp Clone() => default; // 0x000000018301F070-0x000000018301F160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerFriendListRsp ShallowCopy() => default; // 0x000000018301EC40-0x000000018301ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018301E560-0x000000018301E5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018301F2E0-0x000000018301F380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018301F380-0x000000018301F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018301E5B0-0x000000018301E6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018301E8D0-0x000000018301E9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerFriendListRsp other) => default; // 0x000000018301E780-0x000000018301E8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018301EDD0-0x000000018301EEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018301F790-0x000000018301F9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018301F480-0x000000018301F5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018301E9A0-0x000000018301EB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerFriendListRsp other) {} // 0x000000018301E3D0-0x000000018301E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018301E1A0-0x000000018301E370
}

