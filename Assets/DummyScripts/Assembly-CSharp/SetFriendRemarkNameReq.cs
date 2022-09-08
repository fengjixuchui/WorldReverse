/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetFriendRemarkNameReq : MessageBase, IMessage<SetFriendRemarkNameReq> // TypeDefIndex: 25654
{
	// Fields
	private static readonly MessageParser<SetFriendRemarkNameReq> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0942F
	private uint uid_; // 0x18
	public const int RemarkNameFieldNumber = 2; // Metadata: 0x00B09433
	private string remarkName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetFriendRemarkNameReq> Parser { get => default; } // 0x000000018468FF50-0x000000018468FFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018468FBA0-0x000000018468FC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018468F860-0x000000018468F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018468F1D0-0x000000018468F230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846903B0-0x00000001846904A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184690110-0x0000000184690170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018468FD70-0x000000018468FE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184690360-0x00000001846903B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018468F980-0x000000018468FA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x000000018468F7C0-0x000000018468F860 0x000000018468FC30-0x000000018468FCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x000000018468FCD0-0x000000018468FD70 0x0000000184690170-0x0000000184690220

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25655
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25656
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4043
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameReq() {} // 0x0000000184690740-0x00000001846907B0
	static SetFriendRemarkNameReq() {} // 0x0000000184690680-0x0000000184690740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameReq Clone() => default; // 0x000000018468FE60-0x000000018468FF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameReq ShallowCopy() => default; // 0x000000018468F8E0-0x000000018468F980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018468F380-0x000000018468F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184690070-0x00000001846900C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846900C0-0x0000000184690110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018468F3D0-0x000000018468F450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018468F5A0-0x000000018468F670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetFriendRemarkNameReq other) => default; // 0x000000018468F450-0x000000018468F5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018468FA70-0x000000018468FBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846904A0-0x0000000184690680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184690220-0x0000000184690360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018468F670-0x000000018468F7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetFriendRemarkNameReq other) {} // 0x000000018468F230-0x000000018468F380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018468F0D0-0x000000018468F1D0
}

