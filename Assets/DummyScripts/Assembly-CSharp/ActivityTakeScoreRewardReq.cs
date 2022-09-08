/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTakeScoreRewardReq : MessageBase, IMessage<ActivityTakeScoreRewardReq> // TypeDefIndex: 22360
{
	// Fields
	private static readonly MessageParser<ActivityTakeScoreRewardReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B01687
	private uint activityId_; // 0x18
	public const int RewardConfigIdFieldNumber = 2; // Metadata: 0x00B0168B
	private uint rewardConfigId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityTakeScoreRewardReq> Parser { get => default; } // 0x00000001816FF850-0x00000001816FF8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816FF5E0-0x00000001816FF670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001816FF2D0-0x00000001816FF350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816FECC0-0x00000001816FED20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816FFDC0-0x00000001816FFEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816FFBF0-0x00000001816FFC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816FF670-0x00000001816FF760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001816FFD70-0x00000001816FFDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816FF3F0-0x00000001816FF4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001816FFB50-0x00000001816FFBF0 0x00000001816FED20-0x00000001816FEDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardConfigId { get => default; set {} } // 0x00000001816FFAB0-0x00000001816FFB50 0x00000001816FFA10-0x00000001816FFAB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22361
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22362
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 8058
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardReq() {} // 0x0000000181700170-0x00000001817001D0
	static ActivityTakeScoreRewardReq() {} // 0x00000001817000B0-0x0000000181700170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardReq Clone() => default; // 0x00000001816FF760-0x00000001816FF850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardReq ShallowCopy() => default; // 0x00000001816FF350-0x00000001816FF3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001816FEEF0-0x00000001816FEF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816FF970-0x00000001816FF9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816FF9C0-0x00000001816FFA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001816FEF40-0x00000001816FEFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816FEFB0-0x00000001816FF080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityTakeScoreRewardReq other) => default; // 0x00000001816FF080-0x00000001816FF1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816FF4E0-0x00000001816FF5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001816FFEB0-0x00000001817000B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001816FFC50-0x00000001816FFD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816FF1A0-0x00000001816FF2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityTakeScoreRewardReq other) {} // 0x00000001816FEDC0-0x00000001816FEEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816FEBC0-0x00000001816FECC0
}

