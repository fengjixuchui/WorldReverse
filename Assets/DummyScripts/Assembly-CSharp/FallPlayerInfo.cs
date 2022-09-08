/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FallPlayerInfo : MessageBase, IMessage<FallPlayerInfo> // TypeDefIndex: 23260
{
	// Fields
	private static readonly MessageParser<FallPlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B039E3
	private uint uid_; // 0x18
	public const int CurScoreFieldNumber = 2; // Metadata: 0x00B039E7
	private uint curScore_; // 0x1C
	public const int BallCatchCountMapFieldNumber = 3; // Metadata: 0x00B039EB
	private static readonly MapField<uint, uint> _map_ballCatchCountMap_codec; // 0x08
	private readonly MapField<uint, uint> ballCatchCountMap_; // 0x20
	public const int IsGroundFieldNumber = 4; // Metadata: 0x00B039EF
	private bool isGround_; // 0x28
	public const int TimeCostFieldNumber = 5; // Metadata: 0x00B039F3
	private uint timeCost_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FallPlayerInfo> Parser { get => default; } // 0x00000001822633A0-0x0000000182263430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182262EB0-0x0000000182262F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182262A30-0x0000000182262AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182262190-0x00000001822621F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182263950-0x0000000182263A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182263600-0x0000000182263660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182263120-0x0000000182263210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182263860-0x00000001822638B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182262BF0-0x0000000182262CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000182262990-0x0000000182262A30 0x0000000182262FE0-0x0000000182263080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x00000001822638B0-0x0000000182263950 0x0000000182262B50-0x0000000182262BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> BallCatchCountMap { get => default; } // 0x00000001822624D0-0x0000000182262530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGround { get => default; set {} } // 0x0000000182263080-0x0000000182263120 0x0000000182263300-0x00000001822633A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TimeCost { get => default; set {} } // 0x0000000182263560-0x0000000182263600 0x0000000182262F40-0x0000000182262FE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerInfo() {} // 0x0000000182263F00-0x0000000182263F90
	static FallPlayerInfo() {} // 0x0000000182263DD0-0x0000000182263F00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerInfo Clone() => default; // 0x0000000182263210-0x0000000182263300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallPlayerInfo ShallowCopy() => default; // 0x0000000182262AB0-0x0000000182262B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182262390-0x00000001822623E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822634C0-0x0000000182263510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182263510-0x0000000182263560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822623E0-0x00000001822624D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182262530-0x0000000182262600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FallPlayerInfo other) => default; // 0x0000000182262600-0x00000001822627A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182262CE0-0x0000000182262EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182263A40-0x0000000182263DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182263660-0x0000000182263860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822627A0-0x0000000182262990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FallPlayerInfo other) {} // 0x00000001822621F0-0x0000000182262390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182261FD0-0x0000000182262190
}

