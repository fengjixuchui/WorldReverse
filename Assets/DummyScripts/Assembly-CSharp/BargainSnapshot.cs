/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainSnapshot : MessageBase, IMessage<BargainSnapshot> // TypeDefIndex: 24629
{
	// Fields
	private static readonly MessageParser<BargainSnapshot> _parser; // 0x00
	public const int CurMoodFieldNumber = 1; // Metadata: 0x00B06E07
	private int curMood_; // 0x18
	public const int ExpectedPriceFieldNumber = 2; // Metadata: 0x00B06E0B
	private uint expectedPrice_; // 0x1C
	public const int PriceLowLimitFieldNumber = 3; // Metadata: 0x00B06E0F
	private uint priceLowLimit_; // 0x20
	public const int BargainIdFieldNumber = 4; // Metadata: 0x00B06E13
	private uint bargainId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BargainSnapshot> Parser { get => default; } // 0x00000001853A5C80-0x00000001853A5D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001853A5830-0x00000001853A58C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001853A54C0-0x00000001853A5540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001853A4C30-0x00000001853A4C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001853A6130-0x00000001853A6220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001853A5EE0-0x00000001853A5F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001853A58C0-0x00000001853A59B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001853A60E0-0x00000001853A6130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001853A55E0-0x00000001853A56D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int CurMood { get => default; set {} } // 0x00000001853A4F90-0x00000001853A5030 0x00000001853A5AA0-0x00000001853A5B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpectedPrice { get => default; set {} } // 0x00000001853A5B40-0x00000001853A5BE0 0x00000001853A5420-0x00000001853A54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PriceLowLimit { get => default; set {} } // 0x00000001853A5BE0-0x00000001853A5C80 0x00000001853A5D10-0x00000001853A5DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BargainId { get => default; set {} } // 0x00000001853A6220-0x00000001853A62C0 0x00000001853A4EF0-0x00000001853A4F90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainSnapshot() {} // 0x00000001853A66A0-0x00000001853A6700
	static BargainSnapshot() {} // 0x00000001853A65E0-0x00000001853A66A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainSnapshot Clone() => default; // 0x00000001853A59B0-0x00000001853A5AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainSnapshot ShallowCopy() => default; // 0x00000001853A5540-0x00000001853A55E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001853A4E10-0x00000001853A4E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853A5E40-0x00000001853A5E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853A5E90-0x00000001853A5EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001853A4E60-0x00000001853A4EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001853A5180-0x00000001853A5250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BargainSnapshot other) => default; // 0x00000001853A5030-0x00000001853A5180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001853A56D0-0x00000001853A5830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001853A62C0-0x00000001853A65E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001853A5F40-0x00000001853A60E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001853A5250-0x00000001853A5420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BargainSnapshot other) {} // 0x00000001853A4C90-0x00000001853A4E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001853A4B00-0x00000001853A4C30
}

