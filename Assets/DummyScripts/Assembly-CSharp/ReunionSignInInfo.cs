/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionSignInInfo : MessageBase, IMessage<ReunionSignInInfo> // TypeDefIndex: 24802
{
	// Fields
	private static readonly MessageParser<ReunionSignInInfo> _parser; // 0x00
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B0744F
	private uint configId_; // 0x18
	public const int SignInCountFieldNumber = 2; // Metadata: 0x00B07453
	private uint signInCount_; // 0x1C
	public const int LastSignInTimeFieldNumber = 3; // Metadata: 0x00B07457
	private uint lastSignInTime_; // 0x20
	public const int RewardDayListFieldNumber = 4; // Metadata: 0x00B0745B
	private static readonly FieldCodec<uint> _repeated_rewardDayList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> rewardDayList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionSignInInfo> Parser { get => default; } // 0x00000001843A0EF0-0x00000001843A0F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843A0AA0-0x00000001843A0B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843A0690-0x00000001843A0710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018439FED0-0x000000018439FF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843A13B0-0x00000001843A14A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843A10B0-0x00000001843A1110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843A0D10-0x00000001843A0E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843A12C0-0x00000001843A1310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843A07B0-0x00000001843A08A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x00000001843A0C70-0x00000001843A0D10 0x000000018439FF30-0x000000018439FFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignInCount { get => default; set {} } // 0x00000001843A0A00-0x00000001843A0AA0 0x00000001843A0B30-0x00000001843A0BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastSignInTime { get => default; set {} } // 0x00000001843A1310-0x00000001843A13B0 0x00000001843A0BD0-0x00000001843A0C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RewardDayList { get => default; } // 0x00000001843A14A0-0x00000001843A1500 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionSignInInfo() {} // 0x00000001843A18E0-0x00000001843A1970
	static ReunionSignInInfo() {} // 0x00000001843A1800-0x00000001843A18E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionSignInInfo Clone() => default; // 0x00000001843A0E00-0x00000001843A0EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionSignInInfo ShallowCopy() => default; // 0x00000001843A0710-0x00000001843A07B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843A0150-0x00000001843A01A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843A1010-0x00000001843A1060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843A1060-0x00000001843A10B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843A01A0-0x00000001843A0280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843A0280-0x00000001843A0350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionSignInInfo other) => default; // 0x00000001843A0350-0x00000001843A04B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843A08A0-0x00000001843A0A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843A1500-0x00000001843A1800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843A1110-0x00000001843A12C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843A04B0-0x00000001843A0690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionSignInInfo other) {} // 0x000000018439FFD0-0x00000001843A0150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018439FD30-0x000000018439FED0
}

