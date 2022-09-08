/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusCardInfo : MessageBase, IMessage<InBattleMechanicusCardInfo> // TypeDefIndex: 24109
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusCardInfo> _parser; // 0x00
	public const int CardIdFieldNumber = 1; // Metadata: 0x00B0595B
	private uint cardId_; // 0x18
	public const int CostPointsFieldNumber = 2; // Metadata: 0x00B0595F
	private uint costPoints_; // 0x1C
	public const int RandEffectIdFieldNumber = 3; // Metadata: 0x00B05963
	private uint randEffectId_; // 0x20
	public const int BeginRoundFieldNumber = 4; // Metadata: 0x00B05967
	private uint beginRound_; // 0x24
	public const int EndRoundFieldNumber = 5; // Metadata: 0x00B0596B
	private uint endRound_; // 0x28
	public const int ChallengeStateFieldNumber = 6; // Metadata: 0x00B0596F
	private InBattleMechanicusCardChallengeState challengeState_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusCardInfo> Parser { get => default; } // 0x0000000182455970-0x0000000182455A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182455480-0x0000000182455510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182454F30-0x0000000182454FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824544C0-0x0000000182454520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182455F40-0x0000000182456030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182455C70-0x0000000182455CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824556F0-0x00000001824557E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182455EF0-0x0000000182455F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182455050-0x0000000182455140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardId { get => default; set {} } // 0x00000001824553E0-0x0000000182455480 0x0000000182454930-0x00000001824549D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostPoints { get => default; set {} } // 0x00000001824555B0-0x0000000182455650 0x0000000182455510-0x00000001824555B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RandEffectId { get => default; set {} } // 0x0000000182454890-0x0000000182454930 0x0000000182455BD0-0x0000000182455C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginRound { get => default; set {} } // 0x00000001824558D0-0x0000000182455970 0x0000000182455B30-0x0000000182455BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndRound { get => default; set {} } // 0x0000000182455650-0x00000001824556F0 0x0000000182455340-0x00000001824553E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardChallengeState ChallengeState { get => default; set {} } // 0x00000001824546F0-0x0000000182454790 0x0000000182454C30-0x0000000182454CD0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardInfo() {} // 0x0000000182456520-0x0000000182456590
	static InBattleMechanicusCardInfo() {} // 0x0000000182456460-0x0000000182456520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardInfo Clone() => default; // 0x00000001824557E0-0x00000001824558D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardInfo ShallowCopy() => default; // 0x0000000182454FB0-0x0000000182455050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182454790-0x00000001824547E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182455A90-0x0000000182455AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182455AE0-0x0000000182455B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824547E0-0x0000000182454890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182454B60-0x0000000182454C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusCardInfo other) => default; // 0x00000001824549D0-0x0000000182454B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182455140-0x0000000182455340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182456030-0x0000000182456460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182455CD0-0x0000000182455EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182454CD0-0x0000000182454F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusCardInfo other) {} // 0x0000000182454520-0x00000001824546F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182454360-0x00000001824544C0
}

