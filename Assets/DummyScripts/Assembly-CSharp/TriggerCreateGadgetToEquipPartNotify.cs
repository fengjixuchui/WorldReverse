/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TriggerCreateGadgetToEquipPartNotify : MessageBase, IMessage<TriggerCreateGadgetToEquipPartNotify> // TypeDefIndex: 23082
{
	// Fields
	private static readonly MessageParser<TriggerCreateGadgetToEquipPartNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B03263
	private uint entityId_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B03267
	private uint gadgetEntityId_; // 0x1C
	public const int GadgetIdFieldNumber = 3; // Metadata: 0x00B0326B
	private uint gadgetId_; // 0x20
	public const int EquipPartFieldNumber = 4; // Metadata: 0x00B0326F
	private string equipPart_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TriggerCreateGadgetToEquipPartNotify> Parser { get => default; } // 0x0000000181614A10-0x0000000181614AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816147A0-0x0000000181614830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181614370-0x00000001816143F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181613A70-0x0000000181613AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181614F70-0x0000000181615060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181614C70-0x0000000181614CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181614830-0x0000000181614920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181614F20-0x0000000181614F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181614490-0x0000000181614580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181614BD0-0x0000000181614C70 0x0000000181615060-0x0000000181615100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000181614CD0-0x0000000181614D70 0x0000000181613AD0-0x0000000181613B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x00000001816142D0-0x0000000181614370 0x0000000181614700-0x00000001816147A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string EquipPart { get => default; set {} } // 0x0000000181614230-0x00000001816142D0 0x00000001816139C0-0x0000000181613A70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23083
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23084
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 333
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TriggerCreateGadgetToEquipPartNotify() {} // 0x00000001816154C0-0x00000001816155E0
	static TriggerCreateGadgetToEquipPartNotify() {} // 0x0000000181615400-0x00000001816154C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TriggerCreateGadgetToEquipPartNotify Clone() => default; // 0x0000000181614920-0x0000000181614A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TriggerCreateGadgetToEquipPartNotify ShallowCopy() => default; // 0x00000001816143F0-0x0000000181614490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181613D10-0x0000000181613D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181614B30-0x0000000181614B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181614B80-0x0000000181614BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181613D60-0x0000000181613DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181613DF0-0x0000000181613EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TriggerCreateGadgetToEquipPartNotify other) => default; // 0x0000000181613EC0-0x0000000181614050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181614580-0x0000000181614700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181615100-0x0000000181615400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181614D70-0x0000000181614F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181614050-0x0000000181614230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TriggerCreateGadgetToEquipPartNotify other) {} // 0x0000000181613B70-0x0000000181613D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181613890-0x00000001816139C0
}

