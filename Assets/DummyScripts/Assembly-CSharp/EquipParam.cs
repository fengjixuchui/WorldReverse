/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipParam : MessageBase, IMessage<EquipParam> // TypeDefIndex: 25987
{
	// Fields
	private static readonly MessageParser<EquipParam> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0A927
	private uint itemId_; // 0x18
	public const int ItemNumFieldNumber = 2; // Metadata: 0x00B0A92B
	private uint itemNum_; // 0x1C
	public const int ItemLevelFieldNumber = 3; // Metadata: 0x00B0A92F
	private uint itemLevel_; // 0x20
	public const int PromoteLevelFieldNumber = 4; // Metadata: 0x00B0A933
	private uint promoteLevel_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EquipParam> Parser { get => default; } // 0x0000000182C34E10-0x0000000182C34EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C34A60-0x0000000182C34AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C346F0-0x0000000182C34770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C33F00-0x0000000182C33F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C35400-0x0000000182C354F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C35110-0x0000000182C35170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C34AF0-0x0000000182C34BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C35310-0x0000000182C35360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C34810-0x0000000182C34900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000182C34FD0-0x0000000182C35070 0x0000000182C35360-0x0000000182C35400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemNum { get => default; set {} } // 0x0000000182C34CD0-0x0000000182C34D70 0x0000000182C34EA0-0x0000000182C34F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemLevel { get => default; set {} } // 0x0000000182C345B0-0x0000000182C34650 0x0000000182C354F0-0x0000000182C35590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x0000000182C34650-0x0000000182C346F0 0x0000000182C34D70-0x0000000182C34E10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParam() {} // 0x0000000182C35970-0x0000000182C359D0
	static EquipParam() {} // 0x0000000182C358B0-0x0000000182C35970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParam Clone() => default; // 0x0000000182C34BE0-0x0000000182C34CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParam ShallowCopy() => default; // 0x0000000182C34770-0x0000000182C34810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C340E0-0x0000000182C34130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C35070-0x0000000182C350C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C350C0-0x0000000182C35110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C34130-0x0000000182C341C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C341C0-0x0000000182C34290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EquipParam other) => default; // 0x0000000182C34290-0x0000000182C343E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C34900-0x0000000182C34A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C35590-0x0000000182C358B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C35170-0x0000000182C35310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C343E0-0x0000000182C345B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EquipParam other) {} // 0x0000000182C33F60-0x0000000182C340E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C33DD0-0x0000000182C33F00
}

