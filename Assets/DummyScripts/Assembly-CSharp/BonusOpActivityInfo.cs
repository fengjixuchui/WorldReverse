/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BonusOpActivityInfo : MessageBase, IMessage<BonusOpActivityInfo> // TypeDefIndex: 24240
{
	// Fields
	private static readonly MessageParser<BonusOpActivityInfo> _parser; // 0x00
	public const int LeftBonusCountFieldNumber = 1; // Metadata: 0x00B05EC7
	private uint leftBonusCount_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BonusOpActivityInfo> Parser { get => default; } // 0x0000000181526CE0-0x0000000181526D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181526A70-0x0000000181526B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181526780-0x0000000181526800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181526150-0x00000001815261B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181527030-0x0000000181527120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181526EA0-0x0000000181526F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181526B00-0x0000000181526BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181526FE0-0x0000000181527030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815268A0-0x0000000181526990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftBonusCount { get => default; set {} } // 0x0000000181526380-0x0000000181526420 0x0000000181526420-0x00000001815264C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusOpActivityInfo() {} // 0x0000000181527350-0x00000001815273B0
	static BonusOpActivityInfo() {} // 0x0000000181527290-0x0000000181527350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusOpActivityInfo Clone() => default; // 0x0000000181526BF0-0x0000000181526CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusOpActivityInfo ShallowCopy() => default; // 0x0000000181526800-0x00000001815268A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815262C0-0x0000000181526310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181526E00-0x0000000181526E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181526E50-0x0000000181526EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181526310-0x0000000181526380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815264C0-0x0000000181526590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BonusOpActivityInfo other) => default; // 0x0000000181526590-0x0000000181526690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181526990-0x0000000181526A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181527120-0x0000000181527290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181526F00-0x0000000181526FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181526690-0x0000000181526780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BonusOpActivityInfo other) {} // 0x00000001815261B0-0x00000001815262C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181526070-0x0000000181526150
}

