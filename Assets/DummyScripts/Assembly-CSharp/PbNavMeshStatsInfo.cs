/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PbNavMeshStatsInfo : MessageBase, IMessage<PbNavMeshStatsInfo> // TypeDefIndex: 24293
{
	// Fields
	private static readonly MessageParser<PbNavMeshStatsInfo> _parser; // 0x00
	public const int TotalAuthorityAiFieldNumber = 1; // Metadata: 0x00B0609F
	private int totalAuthorityAi_; // 0x18
	public const int TotalNoAuthorityAiFieldNumber = 2; // Metadata: 0x00B060A3
	private int totalNoAuthorityAi_; // 0x1C
	public const int AuthorityAiInCombatFieldNumber = 3; // Metadata: 0x00B060A7
	private int authorityAiInCombat_; // 0x20
	public const int NoAuthorityAiInCombatFieldNumber = 4; // Metadata: 0x00B060AB
	private int noAuthorityAiInCombat_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PbNavMeshStatsInfo> Parser { get => default; } // 0x0000000183255780-0x0000000183255810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183255470-0x0000000183255500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183254FC0-0x0000000183255040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183254730-0x0000000183254790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183255B90-0x0000000183255C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183255940-0x00000001832559A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832555A0-0x0000000183255690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183255B40-0x0000000183255B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183255180-0x0000000183255270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int TotalAuthorityAi { get => default; set {} } // 0x00000001832550E0-0x0000000183255180 0x0000000183255C80-0x0000000183255D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int TotalNoAuthorityAi { get => default; set {} } // 0x0000000183255500-0x00000001832555A0 0x0000000183254790-0x0000000183254830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AuthorityAiInCombat { get => default; set {} } // 0x00000001832553D0-0x0000000183255470 0x0000000183254A00-0x0000000183254AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int NoAuthorityAiInCombat { get => default; set {} } // 0x0000000183254B30-0x0000000183254BD0 0x0000000183255D20-0x0000000183255DC0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PbNavMeshStatsInfo() {} // 0x00000001832561A0-0x0000000183256200
	static PbNavMeshStatsInfo() {} // 0x00000001832560E0-0x00000001832561A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PbNavMeshStatsInfo Clone() => default; // 0x0000000183255690-0x0000000183255780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PbNavMeshStatsInfo ShallowCopy() => default; // 0x0000000183255040-0x00000001832550E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832549B0-0x0000000183254A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832558A0-0x00000001832558F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832558F0-0x0000000183255940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183254AA0-0x0000000183254B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183254D20-0x0000000183254DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PbNavMeshStatsInfo other) => default; // 0x0000000183254BD0-0x0000000183254D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183255270-0x00000001832553D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183255DC0-0x00000001832560E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832559A0-0x0000000183255B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183254DF0-0x0000000183254FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PbNavMeshStatsInfo other) {} // 0x0000000183254830-0x00000001832549B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183254600-0x0000000183254730
}

