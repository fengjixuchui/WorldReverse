/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetSlotChangeNotify : MessageBase, IMessage<WidgetSlotChangeNotify> // TypeDefIndex: 25866
{
	// Fields
	private static readonly MessageParser<WidgetSlotChangeNotify> _parser; // 0x00
	public const int OpFieldNumber = 1; // Metadata: 0x00B09BF3
	private WidgetSlotOp op_; // 0x18
	public const int SlotFieldNumber = 2; // Metadata: 0x00B09BF7
	private WidgetSlotData slot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetSlotChangeNotify> Parser { get => default; } // 0x0000000181F30330-0x0000000181F303C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F2FF80-0x0000000181F30010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F2FB10-0x0000000181F2FB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F2F3E0-0x0000000181F2F440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F307C0-0x0000000181F308B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F305F0-0x0000000181F30650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F300B0-0x0000000181F301A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F30770-0x0000000181F307C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F2FC30-0x0000000181F2FD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotOp Op { get => default; set {} } // 0x0000000181F30010-0x0000000181F300B0 0x0000000181F2FEE0-0x0000000181F2FF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotData Slot { get => default; set {} } // 0x0000000181F30550-0x0000000181F305F0 0x0000000181F30290-0x0000000181F30330

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25867
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25868
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4281
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotChangeNotify() {} // 0x0000000181F30B50-0x0000000181F30BC0
	static WidgetSlotChangeNotify() {} // 0x0000000181F30A90-0x0000000181F30B50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotChangeNotify Clone() => default; // 0x0000000181F301A0-0x0000000181F30290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotChangeNotify ShallowCopy() => default; // 0x0000000181F2FB90-0x0000000181F2FC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F2F5C0-0x0000000181F2F640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F30450-0x0000000181F304D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F304D0-0x0000000181F30550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F2F640-0x0000000181F2F770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F2F770-0x0000000181F2F840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetSlotChangeNotify other) => default; // 0x0000000181F2F840-0x0000000181F2F970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F2FD20-0x0000000181F2FEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F308B0-0x0000000181F30A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F30650-0x0000000181F30770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F2F970-0x0000000181F2FB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetSlotChangeNotify other) {} // 0x0000000181F2F440-0x0000000181F2F5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F2F2B0-0x0000000181F2F3E0
}

