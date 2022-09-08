/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingActivityDetailInfo : MessageBase, IMessage<BlessingActivityDetailInfo> // TypeDefIndex: 22116
{
	// Fields
	private static readonly MessageParser<BlessingActivityDetailInfo> _parser; // 0x00
	public const int IsActivatedFieldNumber = 1; // Metadata: 0x00B00D33
	private bool isActivated_; // 0x18
	public const int IsContentClosedFieldNumber = 2; // Metadata: 0x00B00D37
	private bool isContentClosed_; // 0x19
	public const int CurDayScanTypeFieldNumber = 3; // Metadata: 0x00B00D3B
	private uint curDayScanType_; // 0x1C
	public const int CurDayScanNumFieldNumber = 4; // Metadata: 0x00B00D3F
	private uint curDayScanNum_; // 0x20
	public const int PicNumMapFieldNumber = 5; // Metadata: 0x00B00D43
	private static readonly MapField<uint, uint> _map_picNumMap_codec; // 0x08
	private readonly MapField<uint, uint> picNumMap_; // 0x28
	public const int RedeemRewardNumFieldNumber = 6; // Metadata: 0x00B00D47
	private uint redeemRewardNum_; // 0x30
	public const int NextRefreshTimeFieldNumber = 7; // Metadata: 0x00B00D4B
	private uint nextRefreshTime_; // 0x34
	public const int ContentCloseTimeFieldNumber = 8; // Metadata: 0x00B00D4F
	private uint contentCloseTime_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingActivityDetailInfo> Parser { get => default; } // 0x0000000184B86540-0x0000000184B865D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B86190-0x0000000184B86220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B85D40-0x0000000184B85DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B84EA0-0x0000000184B84F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B86BB0-0x0000000184B86CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B867A0-0x0000000184B86800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B86220-0x0000000184B86310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B86AC0-0x0000000184B86B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B85E60-0x0000000184B85F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsActivated { get => default; set {} } // 0x0000000184B864A0-0x0000000184B86540 0x0000000184B84FA0-0x0000000184B85040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x0000000184B84F00-0x0000000184B84FA0 0x0000000184B85470-0x0000000184B85510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurDayScanType { get => default; set {} } // 0x0000000184B85260-0x0000000184B85300 0x0000000184B86700-0x0000000184B867A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurDayScanNum { get => default; set {} } // 0x0000000184B84E00-0x0000000184B84EA0 0x0000000184B85510-0x0000000184B855B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> PicNumMap { get => default; } // 0x0000000184B855B0-0x0000000184B85610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RedeemRewardNum { get => default; set {} } // 0x0000000184B85B60-0x0000000184B85C00 0x0000000184B85C00-0x0000000184B85CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x0000000184B86400-0x0000000184B864A0 0x0000000184B86CA0-0x0000000184B86D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x0000000184B86B10-0x0000000184B86BB0 0x0000000184B85CA0-0x0000000184B85D40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingActivityDetailInfo() {} // 0x0000000184B873A0-0x0000000184B87430
	static BlessingActivityDetailInfo() {} // 0x0000000184B87270-0x0000000184B873A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingActivityDetailInfo Clone() => default; // 0x0000000184B86310-0x0000000184B86400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingActivityDetailInfo ShallowCopy() => default; // 0x0000000184B85DC0-0x0000000184B85E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B85300-0x0000000184B85350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B86660-0x0000000184B866B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B866B0-0x0000000184B86700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B85350-0x0000000184B85470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B85800-0x0000000184B858D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingActivityDetailInfo other) => default; // 0x0000000184B85610-0x0000000184B85800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B85F50-0x0000000184B86190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B86D40-0x0000000184B87270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B86800-0x0000000184B86AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B858D0-0x0000000184B85B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingActivityDetailInfo other) {} // 0x0000000184B85040-0x0000000184B85260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B84BE0-0x0000000184B84E00
}

