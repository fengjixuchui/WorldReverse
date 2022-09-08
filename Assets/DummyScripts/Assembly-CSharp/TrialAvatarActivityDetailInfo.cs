/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarActivityDetailInfo : MessageBase, IMessage<TrialAvatarActivityDetailInfo> // TypeDefIndex: 21967
{
	// Fields
	private static readonly MessageParser<TrialAvatarActivityDetailInfo> _parser; // 0x00
	public const int RewardInfoListFieldNumber = 1; // Metadata: 0x00B00777
	private static readonly FieldCodec<TrialAvatarActivityRewardDetailInfo> _repeated_rewardInfoList_codec; // 0x08
	private readonly RepeatedMessageField<TrialAvatarActivityRewardDetailInfo> rewardInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarActivityDetailInfo> Parser { get => default; } // 0x0000000182106C60-0x0000000182106CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821069F0-0x0000000182106A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182106720-0x00000001821067A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182106140-0x00000001821061A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182107050-0x0000000182107140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182106EA0-0x0000000182106F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182106A80-0x0000000182106B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182107000-0x0000000182107050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182106840-0x0000000182106930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TrialAvatarActivityRewardDetailInfo> RewardInfoList { get => default; } // 0x00000001821063F0-0x0000000182106450 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityDetailInfo() {} // 0x00000001821073A0-0x0000000182107430
	static TrialAvatarActivityDetailInfo() {} // 0x0000000182107290-0x00000001821073A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityDetailInfo Clone() => default; // 0x0000000182106B70-0x0000000182106C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityDetailInfo ShallowCopy() => default; // 0x00000001821067A0-0x0000000182106840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821062D0-0x0000000182106320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182106D80-0x0000000182106E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182106E10-0x0000000182106EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182106320-0x00000001821063F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182106450-0x0000000182106520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarActivityDetailInfo other) => default; // 0x0000000182106520-0x0000000182106630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182106930-0x00000001821069F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182107140-0x0000000182107290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182106F00-0x0000000182107000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182106630-0x0000000182106720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarActivityDetailInfo other) {} // 0x00000001821061A0-0x00000001821062D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182106010-0x0000000182106140
}

