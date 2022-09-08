/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMusicRecord : MessageBase, IMessage<FleurFairMusicRecord> // TypeDefIndex: 22208
{
	// Fields
	private static readonly MessageParser<FleurFairMusicRecord> _parser; // 0x00
	public const int MaxScoreFieldNumber = 1; // Metadata: 0x00B010A3
	private uint maxScore_; // 0x18
	public const int MaxComboFieldNumber = 2; // Metadata: 0x00B010A7
	private uint maxCombo_; // 0x1C
	public const int IsUnlockFieldNumber = 3; // Metadata: 0x00B010AB
	private bool isUnlock_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairMusicRecord> Parser { get => default; } // 0x00000001821B9350-0x00000001821B93E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821B8FA0-0x00000001821B9030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821B8BC0-0x00000001821B8C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821B8490-0x00000001821B84F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821B97C0-0x00000001821B98B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821B9510-0x00000001821B9570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821B9030-0x00000001821B9120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821B9770-0x00000001821B97C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821B8CE0-0x00000001821B8DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxScore { get => default; set {} } // 0x00000001821B84F0-0x00000001821B8590 0x00000001821B8F00-0x00000001821B8FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxCombo { get => default; set {} } // 0x00000001821B9210-0x00000001821B92B0 0x00000001821B92B0-0x00000001821B9350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUnlock { get => default; set {} } // 0x00000001821B96D0-0x00000001821B9770 0x00000001821B87C0-0x00000001821B8860

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicRecord() {} // 0x00000001821B9C00-0x00000001821B9C60
	static FleurFairMusicRecord() {} // 0x00000001821B9B40-0x00000001821B9C00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicRecord Clone() => default; // 0x00000001821B9120-0x00000001821B9210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicRecord ShallowCopy() => default; // 0x00000001821B8C40-0x00000001821B8CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821B86F0-0x00000001821B8740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821B9470-0x00000001821B94C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821B94C0-0x00000001821B9510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821B8740-0x00000001821B87C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821B8860-0x00000001821B8930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairMusicRecord other) => default; // 0x00000001821B8930-0x00000001821B8A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821B8DD0-0x00000001821B8F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821B98B0-0x00000001821B9B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821B9570-0x00000001821B96D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821B8A70-0x00000001821B8BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairMusicRecord other) {} // 0x00000001821B8590-0x00000001821B86F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821B8380-0x00000001821B8490
}

