/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairBossSettleInfo : MessageBase, IMessage<FleurFairBossSettleInfo> // TypeDefIndex: 24168
{
	// Fields
	private static readonly MessageParser<FleurFairBossSettleInfo> _parser; // 0x00
	public const int IsSuccessFieldNumber = 1; // Metadata: 0x00B05C23
	private bool isSuccess_; // 0x18
	public const int CostTimeFieldNumber = 2; // Metadata: 0x00B05C27
	private uint costTime_; // 0x1C
	public const int EnergyFieldNumber = 3; // Metadata: 0x00B05C2B
	private uint energy_; // 0x20
	public const int StatInfoListFieldNumber = 4; // Metadata: 0x00B05C2F
	private static readonly FieldCodec<FleurFairPlayerStatInfo> _repeated_statInfoList_codec; // 0x08
	private readonly RepeatedMessageField<FleurFairPlayerStatInfo> statInfoList_; // 0x28
	public const int RewardTokenNumFieldNumber = 5; // Metadata: 0x00B05C33
	private uint rewardTokenNum_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairBossSettleInfo> Parser { get => default; } // 0x00000001823A45B0-0x00000001823A4640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823A4340-0x00000001823A43D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823A3E70-0x00000001823A3EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823A33A0-0x00000001823A3400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823A4BE0-0x00000001823A4CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823A4930-0x00000001823A4990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823A43D0-0x00000001823A44C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823A4B90-0x00000001823A4BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823A4030-0x00000001823A4120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x00000001823A4890-0x00000001823A4930 0x00000001823A3460-0x00000001823A3500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostTime { get => default; set {} } // 0x00000001823A46D0-0x00000001823A4770 0x00000001823A3500-0x00000001823A35A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Energy { get => default; set {} } // 0x00000001823A42A0-0x00000001823A4340 0x00000001823A3980-0x00000001823A3A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FleurFairPlayerStatInfo> StatInfoList { get => default; } // 0x00000001823A3400-0x00000001823A3460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardTokenNum { get => default; set {} } // 0x00000001823A3F90-0x00000001823A4030 0x00000001823A38E0-0x00000001823A3980

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBossSettleInfo() {} // 0x00000001823A5170-0x00000001823A5200
	static FleurFairBossSettleInfo() {} // 0x00000001823A5060-0x00000001823A5170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBossSettleInfo Clone() => default; // 0x00000001823A44C0-0x00000001823A45B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBossSettleInfo ShallowCopy() => default; // 0x00000001823A3EF0-0x00000001823A3F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823A3780-0x00000001823A37D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823A4770-0x00000001823A4800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823A4800-0x00000001823A4890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823A37D0-0x00000001823A38E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823A3A20-0x00000001823A3AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairBossSettleInfo other) => default; // 0x00000001823A3AF0-0x00000001823A3C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823A4120-0x00000001823A42A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823A4CD0-0x00000001823A5060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823A4990-0x00000001823A4B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823A3C80-0x00000001823A3E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairBossSettleInfo other) {} // 0x00000001823A35A0-0x00000001823A3780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823A31E0-0x00000001823A33A0
}

