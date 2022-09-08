/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BalloonSettleInfo : MessageBase, IMessage<BalloonSettleInfo> // TypeDefIndex: 23247
{
	// Fields
	private static readonly MessageParser<BalloonSettleInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B03947
	private uint uid_; // 0x18
	public const int ShootCountFieldNumber = 2; // Metadata: 0x00B0394B
	private uint shootCount_; // 0x1C
	public const int MaxComboFieldNumber = 3; // Metadata: 0x00B0394F
	private uint maxCombo_; // 0x20
	public const int FinalScoreFieldNumber = 4; // Metadata: 0x00B03953
	private uint finalScore_; // 0x24
	public const int PlayerInfoFieldNumber = 5; // Metadata: 0x00B03957
	private OnlinePlayerInfo playerInfo_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BalloonSettleInfo> Parser { get => default; } // 0x00000001831ED760-0x00000001831ED7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831ED310-0x00000001831ED3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831ECE50-0x00000001831ECED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831EC410-0x00000001831EC470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831EDDE0-0x00000001831EDED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831EDAC0-0x00000001831EDB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831ED440-0x00000001831ED530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831EDD90-0x00000001831EDDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831ED010-0x00000001831ED100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001831ECDB0-0x00000001831ECE50 0x00000001831ED3A0-0x00000001831ED440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShootCount { get => default; set {} } // 0x00000001831ECF70-0x00000001831ED010 0x00000001831EDB20-0x00000001831EDBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxCombo { get => default; set {} } // 0x00000001831ED620-0x00000001831ED6C0 0x00000001831ED6C0-0x00000001831ED760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinalScore { get => default; set {} } // 0x00000001831EDED0-0x00000001831EDF70 0x00000001831ED900-0x00000001831ED9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo PlayerInfo { get => default; set {} } // 0x00000001831EC840-0x00000001831EC8E0 0x00000001831EDA20-0x00000001831EDAC0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonSettleInfo() {} // 0x00000001831EE3C0-0x00000001831EE420
	static BalloonSettleInfo() {} // 0x00000001831EE300-0x00000001831EE3C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonSettleInfo Clone() => default; // 0x00000001831ED530-0x00000001831ED620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BalloonSettleInfo ShallowCopy() => default; // 0x00000001831ECED0-0x00000001831ECF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831EC660-0x00000001831EC6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831ED880-0x00000001831ED900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831ED9A0-0x00000001831EDA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831EC6E0-0x00000001831EC840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831ECA70-0x00000001831ECB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BalloonSettleInfo other) => default; // 0x00000001831EC8E0-0x00000001831ECA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831ED100-0x00000001831ED310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831EDF70-0x00000001831EE300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831EDBC0-0x00000001831EDD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831ECB40-0x00000001831ECDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BalloonSettleInfo other) {} // 0x00000001831EC470-0x00000001831EC660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831EC270-0x00000001831EC410
}

