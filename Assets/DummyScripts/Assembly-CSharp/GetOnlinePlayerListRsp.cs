/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetOnlinePlayerListRsp : MessageBase, IMessage<GetOnlinePlayerListRsp> // TypeDefIndex: 23974
{
	// Fields
	private static readonly MessageParser<GetOnlinePlayerListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0543F
	private int retcode_; // 0x18
	public const int PlayerInfoListFieldNumber = 2; // Metadata: 0x00B05443
	private static readonly FieldCodec<OnlinePlayerInfo> _repeated_playerInfoList_codec; // 0x08
	private readonly RepeatedMessageField<OnlinePlayerInfo> playerInfoList_; // 0x20
	public const int ParamFieldNumber = 3; // Metadata: 0x00B05447
	private uint param_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetOnlinePlayerListRsp> Parser { get => default; } // 0x00000001835893B0-0x0000000183589440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183589140-0x00000001835891D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183588E00-0x0000000183588E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835885E0-0x0000000183588640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835899C0-0x0000000183589AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835895F0-0x0000000183589650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835891D0-0x00000001835892C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183589970-0x00000001835899C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183588F20-0x0000000183589010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183588D60-0x0000000183588E00 0x0000000183588910-0x00000001835889B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OnlinePlayerInfo> PlayerInfoList { get => default; } // 0x0000000183589910-0x0000000183589970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000183589650-0x00000001835896F0 0x00000001835896F0-0x0000000183589790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23975
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23976
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 9
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerListRsp() {} // 0x0000000183589E30-0x0000000183589EC0
	static GetOnlinePlayerListRsp() {} // 0x0000000183589D20-0x0000000183589E30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerListRsp Clone() => default; // 0x00000001835892C0-0x00000001835893B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerListRsp ShallowCopy() => default; // 0x0000000183588E80-0x0000000183588F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835887D0-0x0000000183588820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835894D0-0x0000000183589560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183589560-0x00000001835895F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183588820-0x0000000183588910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835889B0-0x0000000183588A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetOnlinePlayerListRsp other) => default; // 0x0000000183588A80-0x0000000183588BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183589010-0x0000000183589140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183589AB0-0x0000000183589D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183589790-0x0000000183589910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183588BD0-0x0000000183588D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetOnlinePlayerListRsp other) {} // 0x0000000183588640-0x00000001835887D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183588460-0x00000001835885E0
}

