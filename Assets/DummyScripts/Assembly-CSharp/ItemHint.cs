/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemHint : MessageBase, IMessage<ItemHint> // TypeDefIndex: 23620
{
	// Fields
	private static readonly MessageParser<ItemHint> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B046C7
	private uint itemId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B046CB
	private uint count_; // 0x1C
	public const int IsNewFieldNumber = 3; // Metadata: 0x00B046CF
	private bool isNew_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemHint> Parser { get => default; } // 0x0000000182A641C0-0x0000000182A64250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A63F50-0x0000000182A63FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A63C10-0x0000000182A63C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A634E0-0x0000000182A63540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A64770-0x0000000182A64860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A644C0-0x0000000182A64520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A63FE0-0x0000000182A640D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A64680-0x0000000182A646D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A63D30-0x0000000182A63E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000182A642E0-0x0000000182A64380 0x0000000182A646D0-0x0000000182A64770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000182A64380-0x0000000182A64420 0x0000000182A63440-0x0000000182A634E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNew { get => default; set {} } // 0x0000000182A636A0-0x0000000182A63740 0x0000000182A63810-0x0000000182A638B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemHint() {} // 0x0000000182A64BB0-0x0000000182A64C10
	static ItemHint() {} // 0x0000000182A64AF0-0x0000000182A64BB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemHint Clone() => default; // 0x0000000182A640D0-0x0000000182A641C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemHint ShallowCopy() => default; // 0x0000000182A63C90-0x0000000182A63D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A63740-0x0000000182A63790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A64420-0x0000000182A64470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A64470-0x0000000182A644C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A63790-0x0000000182A63810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A638B0-0x0000000182A63980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemHint other) => default; // 0x0000000182A63980-0x0000000182A63AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A63E20-0x0000000182A63F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A64860-0x0000000182A64AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A64520-0x0000000182A64680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A63AC0-0x0000000182A63C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemHint other) {} // 0x0000000182A63540-0x0000000182A636A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A63330-0x0000000182A63440
}

