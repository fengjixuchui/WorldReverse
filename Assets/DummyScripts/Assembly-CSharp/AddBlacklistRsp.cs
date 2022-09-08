/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddBlacklistRsp : MessageBase, IMessage<AddBlacklistRsp> // TypeDefIndex: 25609
{
	// Fields
	private static readonly MessageParser<AddBlacklistRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B092C3
	private int retcode_; // 0x18
	public const int TargetFriendBriefFieldNumber = 2; // Metadata: 0x00B092C7
	private FriendBrief targetFriendBrief_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddBlacklistRsp> Parser { get => default; } // 0x0000000183E1F0B0-0x0000000183E1F140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E1EDA0-0x0000000183E1EE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E1EA10-0x0000000183E1EA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E1E100-0x0000000183E1E160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E1F4A0-0x0000000183E1F590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E1F2D0-0x0000000183E1F330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E1EE30-0x0000000183E1EF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E1F450-0x0000000183E1F4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E1EB30-0x0000000183E1EC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183E1E970-0x0000000183E1EA10 0x0000000183E1E530-0x0000000183E1E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief TargetFriendBrief { get => default; set {} } // 0x0000000183E1E160-0x0000000183E1E200 0x0000000183E1F010-0x0000000183E1F0B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25610
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25611
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4028
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddBlacklistRsp() {} // 0x0000000183E1F830-0x0000000183E1F890
	static AddBlacklistRsp() {} // 0x0000000183E1F770-0x0000000183E1F830

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddBlacklistRsp Clone() => default; // 0x0000000183E1EF20-0x0000000183E1F010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddBlacklistRsp ShallowCopy() => default; // 0x0000000183E1EA90-0x0000000183E1EB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E1E380-0x0000000183E1E400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E1F1D0-0x0000000183E1F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E1F250-0x0000000183E1F2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E1E400-0x0000000183E1E530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E1E5D0-0x0000000183E1E6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddBlacklistRsp other) => default; // 0x0000000183E1E6A0-0x0000000183E1E7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E1EC20-0x0000000183E1EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E1F590-0x0000000183E1F770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E1F330-0x0000000183E1F450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E1E7D0-0x0000000183E1E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddBlacklistRsp other) {} // 0x0000000183E1E200-0x0000000183E1E380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E1DFC0-0x0000000183E1E100
}

