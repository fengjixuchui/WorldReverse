/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterActivityDetailInfo : MessageBase, IMessage<AsterActivityDetailInfo> // TypeDefIndex: 22003
{
	// Fields
	private static readonly MessageParser<AsterActivityDetailInfo> _parser; // 0x00
	public const int AsterLittleFieldNumber = 1; // Metadata: 0x00B008C7
	private AsterLittleDetailInfo asterLittle_; // 0x18
	public const int AsterMidFieldNumber = 2; // Metadata: 0x00B008CB
	private AsterMidDetailInfo asterMid_; // 0x20
	public const int AsterLargeFieldNumber = 3; // Metadata: 0x00B008CF
	private AsterLargeDetailInfo asterLarge_; // 0x28
	public const int AsterProgressFieldNumber = 5; // Metadata: 0x00B008D3
	private AsterProgressDetailInfo asterProgress_; // 0x30
	public const int AsterCreditFieldNumber = 6; // Metadata: 0x00B008D7
	private uint asterCredit_; // 0x38
	public const int AsterTokenFieldNumber = 7; // Metadata: 0x00B008DB
	private uint asterToken_; // 0x3C
	public const int IsSpecialRewardTakenFieldNumber = 8; // Metadata: 0x00B008DF
	private bool isSpecialRewardTaken_; // 0x40
	public const int IsContentClosedFieldNumber = 9; // Metadata: 0x00B008E3
	private bool isContentClosed_; // 0x41
	public const int ContentCloseTimeFieldNumber = 10; // Metadata: 0x00B008E7
	private uint contentCloseTime_; // 0x44

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterActivityDetailInfo> Parser { get => default; } // 0x00000001851305A0-0x0000000185130630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185130150-0x00000001851301E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018512FB30-0x000000018512FBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018512E560-0x000000018512E5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185130D70-0x0000000185130E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851308C0-0x0000000185130920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851303C0-0x00000001851304B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185130C80-0x0000000185130CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018512FC50-0x000000018512FD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleDetailInfo AsterLittle { get => default; set {} } // 0x0000000185130E60-0x0000000185130F00 0x000000018512F0B0-0x000000018512F150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidDetailInfo AsterMid { get => default; set {} } // 0x000000018512EB10-0x000000018512EBB0 0x000000018512F290-0x000000018512F330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLargeDetailInfo AsterLarge { get => default; set {} } // 0x0000000185130F00-0x0000000185130FA0 0x0000000185130820-0x00000001851308C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressDetailInfo AsterProgress { get => default; set {} } // 0x00000001851301E0-0x0000000185130280 0x0000000185130920-0x00000001851309C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AsterCredit { get => default; set {} } // 0x000000018512E660-0x000000018512E700 0x000000018512F150-0x000000018512F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AsterToken { get => default; set {} } // 0x000000018512E700-0x000000018512E7A0 0x000000018512F010-0x000000018512F0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSpecialRewardTaken { get => default; set {} } // 0x0000000185130320-0x00000001851303C0 0x0000000185130280-0x0000000185130320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x000000018512E5C0-0x000000018512E660 0x000000018512F1F0-0x000000018512F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x0000000185130CD0-0x0000000185130D70 0x000000018512FA90-0x000000018512FB30

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterActivityDetailInfo() {} // 0x00000001851315D0-0x0000000185131630
	static AsterActivityDetailInfo() {} // 0x0000000185131510-0x00000001851315D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterActivityDetailInfo Clone() => default; // 0x00000001851304B0-0x00000001851305A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterActivityDetailInfo ShallowCopy() => default; // 0x000000018512FBB0-0x000000018512FC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018512EBB0-0x000000018512EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851306C0-0x0000000185130770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185130770-0x0000000185130820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018512EC70-0x000000018512F010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018512F560-0x000000018512F630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterActivityDetailInfo other) => default; // 0x000000018512F330-0x000000018512F560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018512FD40-0x0000000185130150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185130FA0-0x0000000185131510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851309C0-0x0000000185130C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018512F630-0x000000018512FA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterActivityDetailInfo other) {} // 0x000000018512E7A0-0x000000018512EB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018512E2C0-0x000000018512E560
}

