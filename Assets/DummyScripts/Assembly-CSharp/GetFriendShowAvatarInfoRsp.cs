/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetFriendShowAvatarInfoRsp : MessageBase, IMessage<GetFriendShowAvatarInfoRsp> // TypeDefIndex: 25669
{
	// Fields
	private static readonly MessageParser<GetFriendShowAvatarInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B094B7
	private int retcode_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B094BB
	private uint uid_; // 0x1C
	public const int ShowAvatarInfoListFieldNumber = 3; // Metadata: 0x00B094BF
	private static readonly FieldCodec<ShowAvatarInfo> _repeated_showAvatarInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ShowAvatarInfo> showAvatarInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetFriendShowAvatarInfoRsp> Parser { get => default; } // 0x0000000184827580-0x0000000184827610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184827270-0x0000000184827300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184826F30-0x0000000184826FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184826610-0x0000000184826670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848279E0-0x0000000184827AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848277C0-0x0000000184827820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848273A0-0x0000000184827490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184827990-0x00000001848279E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184827050-0x0000000184827140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184826DF0-0x0000000184826E90 0x00000001848269A0-0x0000000184826A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184826E90-0x0000000184826F30 0x0000000184827300-0x00000001848273A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShowAvatarInfo> ShowAvatarInfoList { get => default; } // 0x0000000184826670-0x00000001848266D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25670
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25671
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4048
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowAvatarInfoRsp() {} // 0x0000000184827E50-0x0000000184827EE0
	static GetFriendShowAvatarInfoRsp() {} // 0x0000000184827D40-0x0000000184827E50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowAvatarInfoRsp Clone() => default; // 0x0000000184827490-0x0000000184827580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowAvatarInfoRsp ShallowCopy() => default; // 0x0000000184826FB0-0x0000000184827050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184826860-0x00000001848268B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848276A0-0x0000000184827730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184827730-0x00000001848277C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848268B0-0x00000001848269A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184826B90-0x0000000184826C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetFriendShowAvatarInfoRsp other) => default; // 0x0000000184826A40-0x0000000184826B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184827140-0x0000000184827270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184827AD0-0x0000000184827D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184827820-0x0000000184827990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184826C60-0x0000000184826DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetFriendShowAvatarInfoRsp other) {} // 0x00000001848266D0-0x0000000184826860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184826490-0x0000000184826610
}

