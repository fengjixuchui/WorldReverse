/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapActivityDetailInfo : MessageBase, IMessage<TreasureMapActivityDetailInfo> // TypeDefIndex: 22097
{
	// Fields
	private static readonly MessageParser<TreasureMapActivityDetailInfo> _parser; // 0x00
	public const int RegionInfoListFieldNumber = 1; // Metadata: 0x00B00CA3
	private static readonly FieldCodec<TreasureMapRegionInfo> _repeated_regionInfoList_codec; // 0x08
	private readonly RepeatedMessageField<TreasureMapRegionInfo> regionInfoList_; // 0x18
	public const int ActiveRegionIndexFieldNumber = 2; // Metadata: 0x00B00CA7
	private uint activeRegionIndex_; // 0x20
	public const int TreasureCloseTimeFieldNumber = 3; // Metadata: 0x00B00CAB
	private uint treasureCloseTime_; // 0x24
	public const int PreviewRewardIdFieldNumber = 4; // Metadata: 0x00B00CAF
	private uint previewRewardId_; // 0x28
	public const int MinOpenPlayerLevelFieldNumber = 5; // Metadata: 0x00B00CB3
	private uint minOpenPlayerLevel_; // 0x2C
	public const int CurrencyNumFieldNumber = 6; // Metadata: 0x00B00CB7
	private uint currencyNum_; // 0x30
	public const int BonusChallengeListFieldNumber = 7; // Metadata: 0x00B00CBB
	private static readonly FieldCodec<TreasureMapBonusChallengeInfo> _repeated_bonusChallengeList_codec; // 0x10
	private readonly RepeatedMessageField<TreasureMapBonusChallengeInfo> bonusChallengeList_; // 0x38
	public const int IsMpChallengeTouchedFieldNumber = 8; // Metadata: 0x00B00CBF
	private bool isMpChallengeTouched_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapActivityDetailInfo> Parser { get => default; } // 0x00000001821BF720-0x00000001821BF7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821BF230-0x00000001821BF2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821BED80-0x00000001821BEE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821BE020-0x00000001821BE080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821BFEE0-0x00000001821BFFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821BFAC0-0x00000001821BFB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821BF360-0x00000001821BF450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821BFE90-0x00000001821BFEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821BEEA0-0x00000001821BEF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TreasureMapRegionInfo> RegionInfoList { get => default; } // 0x00000001821BE490-0x00000001821BE4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActiveRegionIndex { get => default; set {} } // 0x00000001821BECE0-0x00000001821BED80 0x00000001821BE180-0x00000001821BE220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TreasureCloseTime { get => default; set {} } // 0x00000001821BFB20-0x00000001821BFBC0 0x00000001821BF540-0x00000001821BF5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreviewRewardId { get => default; set {} } // 0x00000001821BF680-0x00000001821BF720 0x00000001821BE6B0-0x00000001821BE750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinOpenPlayerLevel { get => default; set {} } // 0x00000001821BF7B0-0x00000001821BF850 0x00000001821BF8E0-0x00000001821BF980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrencyNum { get => default; set {} } // 0x00000001821BE0E0-0x00000001821BE180 0x00000001821BF190-0x00000001821BF230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TreasureMapBonusChallengeInfo> BonusChallengeList { get => default; } // 0x00000001821BE080-0x00000001821BE0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMpChallengeTouched { get => default; set {} } // 0x00000001821BF2C0-0x00000001821BF360 0x00000001821BF5E0-0x00000001821BF680

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapActivityDetailInfo() {} // 0x00000001821C0640-0x00000001821C06F0
	static TreasureMapActivityDetailInfo() {} // 0x00000001821C04E0-0x00000001821C0640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapActivityDetailInfo Clone() => default; // 0x00000001821BF450-0x00000001821BF540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapActivityDetailInfo ShallowCopy() => default; // 0x00000001821BEE00-0x00000001821BEEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821BE4F0-0x00000001821BE540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821BF980-0x00000001821BFA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821BFA20-0x00000001821BFAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821BE540-0x00000001821BE6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821BE750-0x00000001821BE820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapActivityDetailInfo other) => default; // 0x00000001821BE820-0x00000001821BEA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821BEF90-0x00000001821BF190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821BFFD0-0x00000001821C04E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821BFBC0-0x00000001821BFE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821BEA10-0x00000001821BECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapActivityDetailInfo other) {} // 0x00000001821BE220-0x00000001821BE490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821BDDB0-0x00000001821BE020
}

