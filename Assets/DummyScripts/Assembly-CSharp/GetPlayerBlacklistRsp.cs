/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerBlacklistRsp : MessageBase, IMessage<GetPlayerBlacklistRsp> // TypeDefIndex: 25645
{
	// Fields
	private static readonly MessageParser<GetPlayerBlacklistRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B093D3
	private int retcode_; // 0x18
	public const int BlacklistFieldNumber = 2; // Metadata: 0x00B093D7
	private static readonly FieldCodec<FriendBrief> _repeated_blacklist_codec; // 0x08
	private readonly RepeatedMessageField<FriendBrief> blacklist_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerBlacklistRsp> Parser { get => default; } // 0x00000001830E9B10-0x00000001830E9BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830E98A0-0x00000001830E9930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830E9590-0x00000001830E9610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830E8E20-0x00000001830E8E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830E9F40-0x00000001830EA030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830E9D50-0x00000001830E9DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830E9930-0x00000001830E9A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830E9EF0-0x00000001830E9F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830E96B0-0x00000001830E97A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001830E94F0-0x00000001830E9590 0x00000001830E9110-0x00000001830E91B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FriendBrief> Blacklist { get => default; } // 0x00000001830E8DC0-0x00000001830E8E20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25646
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25647
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4040
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerBlacklistRsp() {} // 0x00000001830EA320-0x00000001830EA3B0
	static GetPlayerBlacklistRsp() {} // 0x00000001830EA210-0x00000001830EA320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerBlacklistRsp Clone() => default; // 0x00000001830E9A20-0x00000001830E9B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerBlacklistRsp ShallowCopy() => default; // 0x00000001830E9610-0x00000001830E96B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830E8FE0-0x00000001830E9030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830E9C30-0x00000001830E9CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830E9CC0-0x00000001830E9D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830E9030-0x00000001830E9110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830E92E0-0x00000001830E93B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerBlacklistRsp other) => default; // 0x00000001830E91B0-0x00000001830E92E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830E97A0-0x00000001830E98A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830EA030-0x00000001830EA210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830E9DB0-0x00000001830E9EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830E93B0-0x00000001830E94F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerBlacklistRsp other) {} // 0x00000001830E8E80-0x00000001830E8FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830E8C60-0x00000001830E8DC0
}

