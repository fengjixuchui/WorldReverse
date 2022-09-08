/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseWidgetRetractGadgetRsp : MessageBase, IMessage<UseWidgetRetractGadgetRsp> // TypeDefIndex: 25887
{
	// Fields
	private static readonly MessageParser<UseWidgetRetractGadgetRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09CBB
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B09CBF
	private uint entityId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseWidgetRetractGadgetRsp> Parser { get => default; } // 0x0000000181345700-0x0000000181345790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181345490-0x0000000181345520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181345180-0x0000000181345200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181344AD0-0x0000000181344B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181345B30-0x0000000181345C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181345960-0x00000001813459C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181345520-0x0000000181345610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181345AE0-0x0000000181345B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001813452A0-0x0000000181345390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001813450E0-0x0000000181345180 0x0000000181344D20-0x0000000181344DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001813458C0-0x0000000181345960 0x0000000181345C20-0x0000000181345CC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25888
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25889
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4288
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetRetractGadgetRsp() {} // 0x0000000181345F80-0x0000000181345FE0
	static UseWidgetRetractGadgetRsp() {} // 0x0000000181345EC0-0x0000000181345F80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetRetractGadgetRsp Clone() => default; // 0x0000000181345610-0x0000000181345700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetRetractGadgetRsp ShallowCopy() => default; // 0x0000000181345200-0x00000001813452A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181344C60-0x0000000181344CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181345820-0x0000000181345870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181345870-0x00000001813458C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181344CB0-0x0000000181344D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181344DC0-0x0000000181344E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseWidgetRetractGadgetRsp other) => default; // 0x0000000181344E90-0x0000000181344FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181345390-0x0000000181345490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181345CC0-0x0000000181345EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813459C0-0x0000000181345AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181344FB0-0x00000001813450E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseWidgetRetractGadgetRsp other) {} // 0x0000000181344B30-0x0000000181344C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813449D0-0x0000000181344AD0
}

