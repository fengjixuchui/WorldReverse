/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeGetOnlineStatusRsp : MessageBase, IMessage<HomeGetOnlineStatusRsp> // TypeDefIndex: 23397
{
	// Fields
	private static readonly MessageParser<HomeGetOnlineStatusRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03EF3
	private int retcode_; // 0x18
	public const int PlayerInfoListFieldNumber = 3; // Metadata: 0x00B03EF7
	private static readonly FieldCodec<OnlinePlayerInfo> _repeated_playerInfoList_codec; // 0x08
	private readonly RepeatedMessageField<OnlinePlayerInfo> playerInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeGetOnlineStatusRsp> Parser { get => default; } // 0x0000000182B80850-0x0000000182B808E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B805E0-0x0000000182B80670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B802D0-0x0000000182B80350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B7FB60-0x0000000182B7FBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B80CE0-0x0000000182B80DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B80A90-0x0000000182B80AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B80670-0x0000000182B80760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B80C90-0x0000000182B80CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B803F0-0x0000000182B804E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182B80230-0x0000000182B802D0 0x0000000182B7FE50-0x0000000182B7FEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OnlinePlayerInfo> PlayerInfoList { get => default; } // 0x0000000182B80C30-0x0000000182B80C90 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23398
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23399
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4486
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetOnlineStatusRsp() {} // 0x0000000182B810C0-0x0000000182B81190
	static HomeGetOnlineStatusRsp() {} // 0x0000000182B80FB0-0x0000000182B810C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetOnlineStatusRsp Clone() => default; // 0x0000000182B80760-0x0000000182B80850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetOnlineStatusRsp ShallowCopy() => default; // 0x0000000182B80350-0x0000000182B803F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B7FD20-0x0000000182B7FD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B80970-0x0000000182B80A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B80A00-0x0000000182B80A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B7FD70-0x0000000182B7FE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B80020-0x0000000182B800F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeGetOnlineStatusRsp other) => default; // 0x0000000182B7FEF0-0x0000000182B80020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B804E0-0x0000000182B805E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B80DD0-0x0000000182B80FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B80AF0-0x0000000182B80C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B800F0-0x0000000182B80230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeGetOnlineStatusRsp other) {} // 0x0000000182B7FBC0-0x0000000182B7FD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B7FA00-0x0000000182B7FB60
}

