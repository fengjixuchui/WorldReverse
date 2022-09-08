/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftOwnerStartInviteRsp : MessageBase, IMessage<DraftOwnerStartInviteRsp> // TypeDefIndex: 22767
{
	// Fields
	private static readonly MessageParser<DraftOwnerStartInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02527
	private int retcode_; // 0x18
	public const int DraftIdFieldNumber = 2; // Metadata: 0x00B0252B
	private uint draftId_; // 0x1C
	public const int WrongUidFieldNumber = 3; // Metadata: 0x00B0252F
	private uint wrongUid_; // 0x20
	public const int InviteFailInfoListFieldNumber = 4; // Metadata: 0x00B02533
	private static readonly FieldCodec<DraftInviteFailInfo> _repeated_inviteFailInfoList_codec; // 0x08
	private readonly RepeatedMessageField<DraftInviteFailInfo> inviteFailInfoList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftOwnerStartInviteRsp> Parser { get => default; } // 0x0000000184CF85D0-0x0000000184CF8660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CF8360-0x0000000184CF83F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CF7FF0-0x0000000184CF8070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CF7590-0x0000000184CF75F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CF8BB0-0x0000000184CF8CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CF8950-0x0000000184CF89B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CF83F0-0x0000000184CF84E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CF8B60-0x0000000184CF8BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CF8110-0x0000000184CF8200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184CF7F50-0x0000000184CF7FF0 0x0000000184CF79F0-0x0000000184CF7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DraftId { get => default; set {} } // 0x0000000184CF7A90-0x0000000184CF7B30 0x0000000184CF8780-0x0000000184CF8820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WrongUid { get => default; set {} } // 0x0000000184CF7800-0x0000000184CF78A0 0x0000000184CF88B0-0x0000000184CF8950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DraftInviteFailInfo> InviteFailInfoList { get => default; } // 0x0000000184CF75F0-0x0000000184CF7650 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22768
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22769
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5404
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerStartInviteRsp() {} // 0x0000000184CF90B0-0x0000000184CF9140
	static DraftOwnerStartInviteRsp() {} // 0x0000000184CF8FA0-0x0000000184CF90B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerStartInviteRsp Clone() => default; // 0x0000000184CF84E0-0x0000000184CF85D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftOwnerStartInviteRsp ShallowCopy() => default; // 0x0000000184CF8070-0x0000000184CF8110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CF78A0-0x0000000184CF78F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CF86F0-0x0000000184CF8780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CF8820-0x0000000184CF88B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CF78F0-0x0000000184CF79F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CF7CA0-0x0000000184CF7D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftOwnerStartInviteRsp other) => default; // 0x0000000184CF7B30-0x0000000184CF7CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CF8200-0x0000000184CF8360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CF8CA0-0x0000000184CF8FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CF89B0-0x0000000184CF8B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CF7D70-0x0000000184CF7F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftOwnerStartInviteRsp other) {} // 0x0000000184CF7650-0x0000000184CF7800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CF73F0-0x0000000184CF7590
}

