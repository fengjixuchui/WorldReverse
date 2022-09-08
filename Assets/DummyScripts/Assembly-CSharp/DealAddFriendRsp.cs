/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DealAddFriendRsp : MessageBase, IMessage<DealAddFriendRsp> // TypeDefIndex: 25549
{
	// Fields
	private static readonly MessageParser<DealAddFriendRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B090DB
	private int retcode_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B090DF
	private uint targetUid_; // 0x1C
	public const int DealAddFriendResultFieldNumber = 3; // Metadata: 0x00B090E3
	private DealAddFriendResultType dealAddFriendResult_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DealAddFriendRsp> Parser { get => default; } // 0x0000000182E2C5B0-0x0000000182E2C640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E2C200-0x0000000182E2C290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E2BDD0-0x0000000182E2BE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E2B5D0-0x0000000182E2B630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E2C980-0x0000000182E2CA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E2C770-0x0000000182E2C7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E2C290-0x0000000182E2C380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E2C930-0x0000000182E2C980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E2BEF0-0x0000000182E2BFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E2BD30-0x0000000182E2BDD0 0x0000000182E2B860-0x0000000182E2B900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182E2C160-0x0000000182E2C200 0x0000000182E2BC90-0x0000000182E2BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendResultType DealAddFriendResult { get => default; set {} } // 0x0000000182E2C470-0x0000000182E2C510 0x0000000182E2C510-0x0000000182E2C5B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25550
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25551
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4008
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendRsp() {} // 0x0000000182E2CDC0-0x0000000182E2CE30
	static DealAddFriendRsp() {} // 0x0000000182E2CD00-0x0000000182E2CDC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendRsp Clone() => default; // 0x0000000182E2C380-0x0000000182E2C470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DealAddFriendRsp ShallowCopy() => default; // 0x0000000182E2BE50-0x0000000182E2BEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E2B790-0x0000000182E2B7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E2C6D0-0x0000000182E2C720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E2C720-0x0000000182E2C770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E2B7E0-0x0000000182E2B860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E2B900-0x0000000182E2B9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DealAddFriendRsp other) => default; // 0x0000000182E2B9D0-0x0000000182E2BB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E2BFE0-0x0000000182E2C160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E2CA70-0x0000000182E2CD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E2C7D0-0x0000000182E2C930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E2BB10-0x0000000182E2BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DealAddFriendRsp other) {} // 0x0000000182E2B630-0x0000000182E2B790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E2B4C0-0x0000000182E2B5D0
}

