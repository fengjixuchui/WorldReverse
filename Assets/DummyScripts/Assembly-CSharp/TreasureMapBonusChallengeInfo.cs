/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapBonusChallengeInfo : MessageBase, IMessage<TreasureMapBonusChallengeInfo> // TypeDefIndex: 22096
{
	// Fields
	private static readonly MessageParser<TreasureMapBonusChallengeInfo> _parser; // 0x00
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B00C97
	private uint configId_; // 0x18
	public const int IsActiveFieldNumber = 2; // Metadata: 0x00B00C9B
	private bool isActive_; // 0x1C
	public const int IsDoneFieldNumber = 3; // Metadata: 0x00B00C9F
	private bool isDone_; // 0x1D

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapBonusChallengeInfo> Parser { get => default; } // 0x000000018197FAE0-0x000000018197FB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018197F7D0-0x000000018197F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018197F480-0x000000018197F500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018197ED90-0x000000018197EDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181980090-0x0000000181980180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018197FDE0-0x000000018197FE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018197F900-0x000000018197F9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181980040-0x0000000181980090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018197F5A0-0x000000018197F690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x000000018197F860-0x000000018197F900 0x000000018197EDF0-0x000000018197EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsActive { get => default; set {} } // 0x000000018197FD40-0x000000018197FDE0 0x000000018197FE40-0x000000018197FEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDone { get => default; set {} } // 0x000000018197FC50-0x000000018197FCF0 0x000000018197EFF0-0x000000018197F090

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeInfo() {} // 0x00000001819804D0-0x0000000181980530
	static TreasureMapBonusChallengeInfo() {} // 0x0000000181980410-0x00000001819804D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeInfo Clone() => default; // 0x000000018197F9F0-0x000000018197FAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeInfo ShallowCopy() => default; // 0x000000018197F500-0x000000018197F5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018197F090-0x000000018197F0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018197FC00-0x000000018197FC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018197FCF0-0x000000018197FD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018197F0E0-0x000000018197F160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018197F2A0-0x000000018197F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapBonusChallengeInfo other) => default; // 0x000000018197F160-0x000000018197F2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018197F690-0x000000018197F7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181980180-0x0000000181980410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018197FEE0-0x0000000181980040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018197F370-0x000000018197F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapBonusChallengeInfo other) {} // 0x000000018197EE90-0x000000018197EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018197EC80-0x000000018197ED90
}

