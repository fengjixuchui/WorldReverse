/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabLoopDungeonResultInfo : MessageBase, IMessage<ChannellerSlabLoopDungeonResultInfo> // TypeDefIndex: 22316
{
	// Fields
	private static readonly MessageParser<ChannellerSlabLoopDungeonResultInfo> _parser; // 0x00
	public const int DungeonIndexFieldNumber = 1; // Metadata: 0x00B0151B
	private uint dungeonIndex_; // 0x18
	public const int IsSuccessFieldNumber = 2; // Metadata: 0x00B0151F
	private bool isSuccess_; // 0x1C
	public const int ChallengeScoreFieldNumber = 3; // Metadata: 0x00B01523
	private uint challengeScore_; // 0x20
	public const int ChallengeMaxScoreFieldNumber = 4; // Metadata: 0x00B01527
	private uint challengeMaxScore_; // 0x24
	public const int IsInTimeLimitFieldNumber = 5; // Metadata: 0x00B0152B
	private bool isInTimeLimit_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabLoopDungeonResultInfo> Parser { get => default; } // 0x00000001846B2450-0x00000001846B24E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846B2000-0x00000001846B2090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001846B1BC0-0x00000001846B1C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846B1440-0x00000001846B14A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846B2BC0-0x00000001846B2CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846B27F0-0x00000001846B2850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846B2130-0x00000001846B2220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846B2AD0-0x00000001846B2B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846B1CE0-0x00000001846B1DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonIndex { get => default; set {} } // 0x00000001846B2310-0x00000001846B23B0 0x00000001846B1F60-0x00000001846B2000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x00000001846B2750-0x00000001846B27F0 0x00000001846B14A0-0x00000001846B1540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeScore { get => default; set {} } // 0x00000001846B26B0-0x00000001846B2750 0x00000001846B2A30-0x00000001846B2AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeMaxScore { get => default; set {} } // 0x00000001846B2090-0x00000001846B2130 0x00000001846B2570-0x00000001846B2610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInTimeLimit { get => default; set {} } // 0x00000001846B2B20-0x00000001846B2BC0 0x00000001846B23B0-0x00000001846B2450

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonResultInfo() {} // 0x00000001846B3110-0x00000001846B3170
	static ChannellerSlabLoopDungeonResultInfo() {} // 0x00000001846B3050-0x00000001846B3110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonResultInfo Clone() => default; // 0x00000001846B2220-0x00000001846B2310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonResultInfo ShallowCopy() => default; // 0x00000001846B1C40-0x00000001846B1CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001846B16F0-0x00000001846B1740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846B2610-0x00000001846B2660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846B2660-0x00000001846B26B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846B1740-0x00000001846B17E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846B1950-0x00000001846B1A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabLoopDungeonResultInfo other) => default; // 0x00000001846B17E0-0x00000001846B1950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846B1DD0-0x00000001846B1F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846B2CB0-0x00000001846B3050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846B2850-0x00000001846B2A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001846B1A20-0x00000001846B1BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabLoopDungeonResultInfo other) {} // 0x00000001846B1540-0x00000001846B16F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846B12F0-0x00000001846B1440
}

