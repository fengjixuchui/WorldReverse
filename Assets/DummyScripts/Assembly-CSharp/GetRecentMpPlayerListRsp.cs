/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetRecentMpPlayerListRsp : MessageBase, IMessage<GetRecentMpPlayerListRsp> // TypeDefIndex: 25624
{
	// Fields
	private static readonly MessageParser<GetRecentMpPlayerListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09333
	private int retcode_; // 0x18
	public const int RecentMpPlayerBriefListFieldNumber = 2; // Metadata: 0x00B09337
	private static readonly FieldCodec<FriendBrief> _repeated_recentMpPlayerBriefList_codec; // 0x08
	private readonly RepeatedMessageField<FriendBrief> recentMpPlayerBriefList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetRecentMpPlayerListRsp> Parser { get => default; } // 0x000000018549B5A0-0x000000018549B630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018549B330-0x000000018549B3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018549B020-0x000000018549B0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018549A850-0x000000018549A8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018549B9D0-0x000000018549BAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018549B7E0-0x000000018549B840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018549B3C0-0x000000018549B4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018549B980-0x000000018549B9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018549B140-0x000000018549B230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018549AF80-0x000000018549B020 0x000000018549ABA0-0x000000018549AC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FriendBrief> RecentMpPlayerBriefList { get => default; } // 0x000000018549AA60-0x000000018549AAC0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25625
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25626
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4033
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetRecentMpPlayerListRsp() {} // 0x000000018549BDB0-0x000000018549BE40
	static GetRecentMpPlayerListRsp() {} // 0x000000018549BCA0-0x000000018549BDB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetRecentMpPlayerListRsp Clone() => default; // 0x000000018549B4B0-0x000000018549B5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetRecentMpPlayerListRsp ShallowCopy() => default; // 0x000000018549B0A0-0x000000018549B140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018549AA10-0x000000018549AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018549B6C0-0x000000018549B750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018549B750-0x000000018549B7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018549AAC0-0x000000018549ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018549AC40-0x000000018549AD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetRecentMpPlayerListRsp other) => default; // 0x000000018549AD10-0x000000018549AE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018549B230-0x000000018549B330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018549BAC0-0x000000018549BCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018549B840-0x000000018549B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018549AE40-0x000000018549AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetRecentMpPlayerListRsp other) {} // 0x000000018549A8B0-0x000000018549AA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018549A6F0-0x000000018549A850
}

