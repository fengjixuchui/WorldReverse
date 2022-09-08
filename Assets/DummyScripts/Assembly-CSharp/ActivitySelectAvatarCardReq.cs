/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySelectAvatarCardReq : MessageBase, IMessage<ActivitySelectAvatarCardReq> // TypeDefIndex: 21883
{
	// Fields
	private static readonly MessageParser<ActivitySelectAvatarCardReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B00427
	private uint activityId_; // 0x18
	public const int RewardIdFieldNumber = 2; // Metadata: 0x00B0042B
	private uint rewardId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivitySelectAvatarCardReq> Parser { get => default; } // 0x0000000183ED2BC0-0x0000000183ED2C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ED28B0-0x0000000183ED2940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ED25A0-0x0000000183ED2620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ED1F90-0x0000000183ED1FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183ED3090-0x0000000183ED3180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183ED2EC0-0x0000000183ED2F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ED2940-0x0000000183ED2A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183ED3040-0x0000000183ED3090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ED26C0-0x0000000183ED27B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183ED2E20-0x0000000183ED2EC0 0x0000000183ED1FF0-0x0000000183ED2090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000183ED2D80-0x0000000183ED2E20 0x0000000183ED2B20-0x0000000183ED2BC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21884
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21885
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2011
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardReq() {} // 0x0000000183ED3440-0x0000000183ED34A0
	static ActivitySelectAvatarCardReq() {} // 0x0000000183ED3380-0x0000000183ED3440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardReq Clone() => default; // 0x0000000183ED2A30-0x0000000183ED2B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardReq ShallowCopy() => default; // 0x0000000183ED2620-0x0000000183ED26C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ED21C0-0x0000000183ED2210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ED2CE0-0x0000000183ED2D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ED2D30-0x0000000183ED2D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ED2210-0x0000000183ED2280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ED2280-0x0000000183ED2350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivitySelectAvatarCardReq other) => default; // 0x0000000183ED2350-0x0000000183ED2470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ED27B0-0x0000000183ED28B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183ED3180-0x0000000183ED3380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183ED2F20-0x0000000183ED3040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ED2470-0x0000000183ED25A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivitySelectAvatarCardReq other) {} // 0x0000000183ED2090-0x0000000183ED21C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ED1E90-0x0000000183ED1F90
}

