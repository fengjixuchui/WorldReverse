/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarActivityRewardDetailInfo : MessageBase, IMessage<TrialAvatarActivityRewardDetailInfo> // TypeDefIndex: 21966
{
	// Fields
	private static readonly MessageParser<TrialAvatarActivityRewardDetailInfo> _parser; // 0x00
	public const int TrialAvatarIndexIdFieldNumber = 1; // Metadata: 0x00B0076B
	private uint trialAvatarIndexId_; // 0x18
	public const int PassedDungeonFieldNumber = 2; // Metadata: 0x00B0076F
	private bool passedDungeon_; // 0x1C
	public const int ReceivedRewardFieldNumber = 3; // Metadata: 0x00B00773
	private bool receivedReward_; // 0x1D

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarActivityRewardDetailInfo> Parser { get => default; } // 0x0000000182A9C500-0x0000000182A9C590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A9C150-0x0000000182A9C1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A9BE00-0x0000000182A9BE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A9B710-0x0000000182A9B770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A9CA10-0x0000000182A9CB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A9C800-0x0000000182A9C860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A9C320-0x0000000182A9C410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A9C9C0-0x0000000182A9CA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A9BF20-0x0000000182A9C010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x0000000182A9C280-0x0000000182A9C320 0x0000000182A9C760-0x0000000182A9C800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool PassedDungeon { get => default; set {} } // 0x0000000182A9BA40-0x0000000182A9BAE0 0x0000000182A9C1E0-0x0000000182A9C280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool ReceivedReward { get => default; set {} } // 0x0000000182A9C6C0-0x0000000182A9C760 0x0000000182A9B770-0x0000000182A9B810

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityRewardDetailInfo() {} // 0x0000000182A9CE50-0x0000000182A9CEB0
	static TrialAvatarActivityRewardDetailInfo() {} // 0x0000000182A9CD90-0x0000000182A9CE50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityRewardDetailInfo Clone() => default; // 0x0000000182A9C410-0x0000000182A9C500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityRewardDetailInfo ShallowCopy() => default; // 0x0000000182A9BE80-0x0000000182A9BF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A9B970-0x0000000182A9B9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A9C620-0x0000000182A9C670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A9C670-0x0000000182A9C6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A9B9C0-0x0000000182A9BA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A9BC20-0x0000000182A9BCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarActivityRewardDetailInfo other) => default; // 0x0000000182A9BAE0-0x0000000182A9BC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A9C010-0x0000000182A9C150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A9CB00-0x0000000182A9CD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A9C860-0x0000000182A9C9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A9BCF0-0x0000000182A9BE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarActivityRewardDetailInfo other) {} // 0x0000000182A9B810-0x0000000182A9B970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A9B600-0x0000000182A9B710
}

