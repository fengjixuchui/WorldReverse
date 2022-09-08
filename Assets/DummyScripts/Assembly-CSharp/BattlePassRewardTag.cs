/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassRewardTag : MessageBase, IMessage<BattlePassRewardTag> // TypeDefIndex: 22542
{
	// Fields
	private static readonly MessageParser<BattlePassRewardTag> _parser; // 0x00
	public const int UnlockStatusFieldNumber = 1; // Metadata: 0x00B01D2F
	private BattlePassUnlockStatus unlockStatus_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B01D33
	private uint level_; // 0x1C
	public const int RewardIdFieldNumber = 3; // Metadata: 0x00B01D37
	private uint rewardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassRewardTag> Parser { get => default; } // 0x0000000181F0A380-0x0000000181F0A410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F0A070-0x0000000181F0A100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F09C50-0x0000000181F09CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F094F0-0x0000000181F09550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F0A7F0-0x0000000181F0A8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F0A5E0-0x0000000181F0A640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F0A100-0x0000000181F0A1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F0A7A0-0x0000000181F0A7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F09E10-0x0000000181F09F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassUnlockStatus UnlockStatus { get => default; set {} } // 0x0000000181F09450-0x0000000181F094F0 0x0000000181F09820-0x0000000181F098C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000181F096B0-0x0000000181F09750 0x0000000181F09D70-0x0000000181F09E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000181F0A540-0x0000000181F0A5E0 0x0000000181F0A2E0-0x0000000181F0A380

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTag() {} // 0x0000000181F0AC30-0x0000000181F0ACA0
	static BattlePassRewardTag() {} // 0x0000000181F0AB70-0x0000000181F0AC30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTag Clone() => default; // 0x0000000181F0A1F0-0x0000000181F0A2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassRewardTag ShallowCopy() => default; // 0x0000000181F09CD0-0x0000000181F09D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F09750-0x0000000181F097A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F0A4A0-0x0000000181F0A4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F0A4F0-0x0000000181F0A540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F097A0-0x0000000181F09820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F09A00-0x0000000181F09AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassRewardTag other) => default; // 0x0000000181F098C0-0x0000000181F09A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F09F00-0x0000000181F0A070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F0A8E0-0x0000000181F0AB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F0A640-0x0000000181F0A7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F09AD0-0x0000000181F09C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassRewardTag other) {} // 0x0000000181F09550-0x0000000181F096B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F09340-0x0000000181F09450
}

