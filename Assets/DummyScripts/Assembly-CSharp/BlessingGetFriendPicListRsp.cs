/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingGetFriendPicListRsp : MessageBase, IMessage<BlessingGetFriendPicListRsp> // TypeDefIndex: 22134
{
	// Fields
	private static readonly MessageParser<BlessingGetFriendPicListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00DFF
	private int retcode_; // 0x18
	public const int FriendPicDataListFieldNumber = 2; // Metadata: 0x00B00E03
	private static readonly FieldCodec<BlessingFriendPicData> _repeated_friendPicDataList_codec; // 0x08
	private readonly RepeatedMessageField<BlessingFriendPicData> friendPicDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingGetFriendPicListRsp> Parser { get => default; } // 0x0000000181585F30-0x0000000181585FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181585C60-0x0000000181585CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181585950-0x00000001815859D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815851E0-0x0000000181585240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181586360-0x0000000181586450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181586170-0x00000001815861D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181585CF0-0x0000000181585DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181586310-0x0000000181586360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181585A70-0x0000000181585B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001815858B0-0x0000000181585950 0x00000001815854D0-0x0000000181585570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BlessingFriendPicData> FriendPicDataList { get => default; } // 0x0000000181585ED0-0x0000000181585F30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22135
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22136
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2146
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetFriendPicListRsp() {} // 0x0000000181586740-0x00000001815867D0
	static BlessingGetFriendPicListRsp() {} // 0x0000000181586630-0x0000000181586740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetFriendPicListRsp Clone() => default; // 0x0000000181585DE0-0x0000000181585ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGetFriendPicListRsp ShallowCopy() => default; // 0x00000001815859D0-0x0000000181585A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815853A0-0x00000001815853F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181586050-0x00000001815860E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815860E0-0x0000000181586170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815853F0-0x00000001815854D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815856A0-0x0000000181585770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingGetFriendPicListRsp other) => default; // 0x0000000181585570-0x00000001815856A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181585B60-0x0000000181585C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181586450-0x0000000181586630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815861D0-0x0000000181586310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181585770-0x00000001815858B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingGetFriendPicListRsp other) {} // 0x0000000181585240-0x00000001815853A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181585080-0x00000001815851E0
}

