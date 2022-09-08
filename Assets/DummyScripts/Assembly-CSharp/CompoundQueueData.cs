/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CompoundQueueData : MessageBase, IMessage<CompoundQueueData> // TypeDefIndex: 24400
{
	// Fields
	private static readonly MessageParser<CompoundQueueData> _parser; // 0x00
	public const int CompoundIdFieldNumber = 1; // Metadata: 0x00B065A7
	private uint compoundId_; // 0x18
	public const int OutputCountFieldNumber = 2; // Metadata: 0x00B065AB
	private uint outputCount_; // 0x1C
	public const int WaitCountFieldNumber = 3; // Metadata: 0x00B065AF
	private uint waitCount_; // 0x20
	public const int OutputTimeFieldNumber = 4; // Metadata: 0x00B065B3
	private uint outputTime_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CompoundQueueData> Parser { get => default; } // 0x0000000181BE9C30-0x0000000181BE9CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BE99C0-0x0000000181BE9A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BE9510-0x0000000181BE9590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BE8BE0-0x0000000181BE8C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BEA0E0-0x0000000181BEA1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BE9E90-0x0000000181BE9EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BE9A50-0x0000000181BE9B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BEA090-0x0000000181BEA0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BE9630-0x0000000181BE9720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CompoundId { get => default; set {} } // 0x0000000181BE9DF0-0x0000000181BE9E90 0x0000000181BEA1D0-0x0000000181BEA270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OutputCount { get => default; set {} } // 0x0000000181BE9470-0x0000000181BE9510 0x0000000181BE8FE0-0x0000000181BE9080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WaitCount { get => default; set {} } // 0x0000000181BE9920-0x0000000181BE99C0 0x0000000181BE8E60-0x0000000181BE8F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OutputTime { get => default; set {} } // 0x0000000181BE9880-0x0000000181BE9920 0x0000000181BE8C40-0x0000000181BE8CE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundQueueData() {} // 0x0000000181BEA650-0x0000000181BEA8E0
	static CompoundQueueData() {} // 0x0000000181BEA590-0x0000000181BEA650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundQueueData Clone() => default; // 0x0000000181BE9B40-0x0000000181BE9C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundQueueData ShallowCopy() => default; // 0x0000000181BE9590-0x0000000181BE9630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BE8F00-0x0000000181BE8F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BE9D50-0x0000000181BE9DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BE9DA0-0x0000000181BE9DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BE8F50-0x0000000181BE8FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BE9080-0x0000000181BE9150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CompoundQueueData other) => default; // 0x0000000181BE9150-0x0000000181BE92A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BE9720-0x0000000181BE9880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BEA270-0x0000000181BEA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BE9EF0-0x0000000181BEA090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BE92A0-0x0000000181BE9470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CompoundQueueData other) {} // 0x0000000181BE8CE0-0x0000000181BE8E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BE8AB0-0x0000000181BE8BE0
}

