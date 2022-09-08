/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTakeScoreRewardRsp : MessageBase, IMessage<ActivityTakeScoreRewardRsp> // TypeDefIndex: 22363
{
	// Fields
	private static readonly MessageParser<ActivityTakeScoreRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B016A3
	private int retcode_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B016A7
	private uint activityId_; // 0x1C
	public const int RewardConfigIdFieldNumber = 3; // Metadata: 0x00B016AB
	private uint rewardConfigId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityTakeScoreRewardRsp> Parser { get => default; } // 0x00000001847DE5E0-0x00000001847DE670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001847DE370-0x00000001847DE400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001847DE030-0x00000001847DE0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001847DD830-0x00000001847DD890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001847DEB90-0x00000001847DEC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001847DE980-0x00000001847DE9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001847DE400-0x00000001847DE4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001847DEB40-0x00000001847DEB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001847DE150-0x00000001847DE240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001847DDF90-0x00000001847DE030 0x00000001847DDB60-0x00000001847DDC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001847DE8E0-0x00000001847DE980 0x00000001847DD890-0x00000001847DD930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardConfigId { get => default; set {} } // 0x00000001847DE840-0x00000001847DE8E0 0x00000001847DE7A0-0x00000001847DE840

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22364
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22365
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8059
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardRsp() {} // 0x00000001847DEFD0-0x00000001847DF030
	static ActivityTakeScoreRewardRsp() {} // 0x00000001847DEF10-0x00000001847DEFD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardRsp Clone() => default; // 0x00000001847DE4F0-0x00000001847DE5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeScoreRewardRsp ShallowCopy() => default; // 0x00000001847DE0B0-0x00000001847DE150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001847DDA90-0x00000001847DDAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847DE700-0x00000001847DE750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847DE750-0x00000001847DE7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001847DDAE0-0x00000001847DDB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001847DDC00-0x00000001847DDCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityTakeScoreRewardRsp other) => default; // 0x00000001847DDCD0-0x00000001847DDE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001847DE240-0x00000001847DE370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001847DEC80-0x00000001847DEF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001847DE9E0-0x00000001847DEB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847DDE10-0x00000001847DDF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityTakeScoreRewardRsp other) {} // 0x00000001847DD930-0x00000001847DDA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001847DD720-0x00000001847DD830
}

