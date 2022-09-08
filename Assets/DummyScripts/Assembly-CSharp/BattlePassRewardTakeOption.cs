/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassRewardTakeOption : MessageBase, IMessage<BattlePassRewardTakeOption> // TypeDefIndex: 22557
{
	// Fields
	private static readonly MessageParser<BattlePassRewardTakeOption> _parser; // 0x00
	public const int TagFieldNumber = 1; // Metadata: 0x00B01DD3
	private BattlePassRewardTag tag_; // 0x18
	public const int OptionIdxFieldNumber = 2; // Metadata: 0x00B01DD7
	private uint optionIdx_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassRewardTakeOption> Parser { get => default; } // 0x0000000182FC1E40-0x0000000182FC1ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FC1BD0-0x0000000182FC1C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FC1840-0x0000000182FC18C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FC0FC0-0x0000000182FC1020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FC2370-0x0000000182FC2460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FC2100-0x0000000182FC2160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FC1C60-0x0000000182FC1D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FC2320-0x0000000182FC2370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FC1960-0x0000000182FC1A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTag Tag { get => default; set {} } // 0x0000000182FC1020-0x0000000182FC10C0 0x0000000182FC2060-0x0000000182FC2100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OptionIdx { get => default; set {} } // 0x0000000182FC1250-0x0000000182FC12F0 0x0000000182FC2280-0x0000000182FC2320

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTakeOption() {} // 0x0000000182FC2700-0x0000000182FC2760
	static BattlePassRewardTakeOption() {} // 0x0000000182FC2640-0x0000000182FC2700

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTakeOption Clone() => default; // 0x0000000182FC1D50-0x0000000182FC1E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTakeOption ShallowCopy() => default; // 0x0000000182FC18C0-0x0000000182FC1960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FC12F0-0x0000000182FC1370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC1F60-0x0000000182FC1FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC1FE0-0x0000000182FC2060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FC1370-0x0000000182FC14A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FC15D0-0x0000000182FC16A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassRewardTakeOption other) => default; // 0x0000000182FC14A0-0x0000000182FC15D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FC1A50-0x0000000182FC1BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FC2460-0x0000000182FC2640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FC2160-0x0000000182FC2280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FC16A0-0x0000000182FC1840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassRewardTakeOption other) {} // 0x0000000182FC10C0-0x0000000182FC1250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FC0E90-0x0000000182FC0FC0
}

