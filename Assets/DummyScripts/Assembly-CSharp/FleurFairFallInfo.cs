/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairFallInfo : MessageBase, IMessage<FleurFairFallInfo> // TypeDefIndex: 22207
{
	// Fields
	private static readonly MessageParser<FleurFairFallInfo> _parser; // 0x00
	public const int BestScoreFieldNumber = 1; // Metadata: 0x00B0109F
	private uint bestScore_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairFallInfo> Parser { get => default; } // 0x000000018544ADC0-0x000000018544AE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018544AAB0-0x000000018544AB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018544A7C0-0x000000018544A840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018544A2D0-0x000000018544A330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018544B1B0-0x000000018544B2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018544B020-0x000000018544B080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018544AB40-0x000000018544AC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018544B160-0x000000018544B1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018544A8E0-0x000000018544A9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BestScore { get => default; set {} } // 0x000000018544AD20-0x000000018544ADC0 0x000000018544AF80-0x000000018544B020

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallInfo() {} // 0x000000018544B4D0-0x000000018544B530
	static FleurFairFallInfo() {} // 0x000000018544B410-0x000000018544B4D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallInfo Clone() => default; // 0x000000018544AC30-0x000000018544AD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallInfo ShallowCopy() => default; // 0x000000018544A840-0x000000018544A8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018544A440-0x000000018544A490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018544AEE0-0x000000018544AF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018544AF30-0x000000018544AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018544A490-0x000000018544A500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018544A500-0x000000018544A5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairFallInfo other) => default; // 0x000000018544A5D0-0x000000018544A6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018544A9D0-0x000000018544AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018544B2A0-0x000000018544B410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018544B080-0x000000018544B160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018544A6D0-0x000000018544A7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairFallInfo other) {} // 0x000000018544A330-0x000000018544A440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018544A1F0-0x000000018544A2D0
}

