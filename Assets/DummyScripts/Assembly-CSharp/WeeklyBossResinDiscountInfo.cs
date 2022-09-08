/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WeeklyBossResinDiscountInfo : MessageBase, IMessage<WeeklyBossResinDiscountInfo> // TypeDefIndex: 26030
{
	// Fields
	private static readonly MessageParser<WeeklyBossResinDiscountInfo> _parser; // 0x00
	public const int DiscountNumFieldNumber = 1; // Metadata: 0x00B0AC57
	private uint discountNum_; // 0x18
	public const int DiscountNumLimitFieldNumber = 2; // Metadata: 0x00B0AC5B
	private uint discountNumLimit_; // 0x1C
	public const int ResinCostFieldNumber = 3; // Metadata: 0x00B0AC5F
	private uint resinCost_; // 0x20
	public const int OriginalResinCostFieldNumber = 4; // Metadata: 0x00B0AC63
	private uint originalResinCost_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WeeklyBossResinDiscountInfo> Parser { get => default; } // 0x00000001845A44E0-0x00000001845A4570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845A41D0-0x00000001845A4260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845A3DC0-0x00000001845A3E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845A3490-0x00000001845A34F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845A4990-0x00000001845A4A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845A4740-0x00000001845A47A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845A4300-0x00000001845A43F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845A4940-0x00000001845A4990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845A3F80-0x00000001845A4070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DiscountNum { get => default; set {} } // 0x00000001845A4260-0x00000001845A4300 0x00000001845A3710-0x00000001845A37B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DiscountNumLimit { get => default; set {} } // 0x00000001845A3E40-0x00000001845A3EE0 0x00000001845A34F0-0x00000001845A3590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ResinCost { get => default; set {} } // 0x00000001845A46A0-0x00000001845A4740 0x00000001845A3890-0x00000001845A3930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OriginalResinCost { get => default; set {} } // 0x00000001845A33F0-0x00000001845A3490 0x00000001845A3930-0x00000001845A39D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeeklyBossResinDiscountInfo() {} // 0x00000001845A4E60-0x00000001845A4EC0
	static WeeklyBossResinDiscountInfo() {} // 0x00000001845A4DA0-0x00000001845A4E60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeeklyBossResinDiscountInfo Clone() => default; // 0x00000001845A43F0-0x00000001845A44E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeeklyBossResinDiscountInfo ShallowCopy() => default; // 0x00000001845A3EE0-0x00000001845A3F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845A37B0-0x00000001845A3800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845A4600-0x00000001845A4650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845A4650-0x00000001845A46A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845A3800-0x00000001845A3890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845A3B20-0x00000001845A3BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WeeklyBossResinDiscountInfo other) => default; // 0x00000001845A39D0-0x00000001845A3B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845A4070-0x00000001845A41D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845A4A80-0x00000001845A4DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845A47A0-0x00000001845A4940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845A3BF0-0x00000001845A3DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WeeklyBossResinDiscountInfo other) {} // 0x00000001845A3590-0x00000001845A3710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845A32C0-0x00000001845A33F0
}

