/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetSlotData : MessageBase, IMessage<WidgetSlotData> // TypeDefIndex: 25859
{
	// Fields
	private static readonly MessageParser<WidgetSlotData> _parser; // 0x00
	public const int TagFieldNumber = 1; // Metadata: 0x00B09BA7
	private WidgetSlotTag tag_; // 0x18
	public const int MaterialIdFieldNumber = 2; // Metadata: 0x00B09BAB
	private uint materialId_; // 0x1C
	public const int CdOverTimeFieldNumber = 3; // Metadata: 0x00B09BAF
	private uint cdOverTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetSlotData> Parser { get => default; } // 0x00000001820A7B70-0x00000001820A7C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820A77C0-0x00000001820A7850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820A7440-0x00000001820A74C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820A6CE0-0x00000001820A6D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820A7FE0-0x00000001820A80D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820A7DD0-0x00000001820A7E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820A7990-0x00000001820A7A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820A7F90-0x00000001820A7FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820A7560-0x00000001820A7650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotTag Tag { get => default; set {} } // 0x00000001820A6D40-0x00000001820A6DE0 0x00000001820A7D30-0x00000001820A7DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x00000001820A7850-0x00000001820A78F0 0x00000001820A78F0-0x00000001820A7990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CdOverTime { get => default; set {} } // 0x00000001820A80D0-0x00000001820A8170 0x00000001820A6F40-0x00000001820A6FE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotData() {} // 0x00000001820A84C0-0x00000001820A8530
	static WidgetSlotData() {} // 0x00000001820A8400-0x00000001820A84C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotData Clone() => default; // 0x00000001820A7A80-0x00000001820A7B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotData ShallowCopy() => default; // 0x00000001820A74C0-0x00000001820A7560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820A6FE0-0x00000001820A7030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820A7C90-0x00000001820A7CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820A7CE0-0x00000001820A7D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820A7030-0x00000001820A70B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820A71F0-0x00000001820A72C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetSlotData other) => default; // 0x00000001820A70B0-0x00000001820A71F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820A7650-0x00000001820A77C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820A8170-0x00000001820A8400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820A7E30-0x00000001820A7F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820A72C0-0x00000001820A7440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetSlotData other) {} // 0x00000001820A6DE0-0x00000001820A6F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820A6BD0-0x00000001820A6CE0
}

