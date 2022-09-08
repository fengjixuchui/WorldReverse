/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GrantRewardNotify : MessageBase, IMessage<GrantRewardNotify> // TypeDefIndex: 23681
{
	// Fields
	private static readonly MessageParser<GrantRewardNotify> _parser; // 0x00
	public const int RewardFieldNumber = 1; // Metadata: 0x00B04967
	private Reward reward_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GrantRewardNotify> Parser { get => default; } // 0x00000001831AA200-0x00000001831AA290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831A9EF0-0x00000001831A9F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831A9AF0-0x00000001831A9B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831A9460-0x00000001831A94C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831AA5B0-0x00000001831AA6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831AA420-0x00000001831AA480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831AA020-0x00000001831AA110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831AA560-0x00000001831AA5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831A9C10-0x00000001831A9D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reward Reward { get => default; set {} } // 0x00000001831A9E50-0x00000001831A9EF0 0x00000001831A9F80-0x00000001831AA020

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23682
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23683
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 629
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GrantRewardNotify() {} // 0x00000001831AA8B0-0x00000001831AA910
	static GrantRewardNotify() {} // 0x00000001831AA7F0-0x00000001831AA8B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GrantRewardNotify Clone() => default; // 0x00000001831AA110-0x00000001831AA200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GrantRewardNotify ShallowCopy() => default; // 0x00000001831A9B70-0x00000001831A9C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831A9620-0x00000001831A96A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831AA320-0x00000001831AA3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831AA3A0-0x00000001831AA420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831A96A0-0x00000001831A97C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831A97C0-0x00000001831A9890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GrantRewardNotify other) => default; // 0x00000001831A9890-0x00000001831A99A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831A9D00-0x00000001831A9E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831AA6A0-0x00000001831AA7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831AA480-0x00000001831AA560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831A99A0-0x00000001831A9AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GrantRewardNotify other) {} // 0x00000001831A94C0-0x00000001831A9620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831A9350-0x00000001831A9460
}

