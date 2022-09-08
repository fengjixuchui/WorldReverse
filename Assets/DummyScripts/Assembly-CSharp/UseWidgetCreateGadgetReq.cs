/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseWidgetCreateGadgetReq : MessageBase, IMessage<UseWidgetCreateGadgetReq> // TypeDefIndex: 25878
{
	// Fields
	private static readonly MessageParser<UseWidgetCreateGadgetReq> _parser; // 0x00
	public const int MaterialIdFieldNumber = 1; // Metadata: 0x00B09C6B
	private uint materialId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B09C6F
	private Vector pos_; // 0x20
	public const int RotFieldNumber = 3; // Metadata: 0x00B09C73
	private Vector rot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseWidgetCreateGadgetReq> Parser { get => default; } // 0x0000000183A56100-0x0000000183A56190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A55CB0-0x0000000183A55D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A55880-0x0000000183A55900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A54E80-0x0000000183A54EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A56680-0x0000000183A56770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A563E0-0x0000000183A56440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A55F20-0x0000000183A56010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A56630-0x0000000183A56680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A559A0-0x0000000183A55A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x0000000183A55DE0-0x0000000183A55E80 0x0000000183A55E80-0x0000000183A55F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000183A56340-0x0000000183A563E0 0x0000000183A56590-0x0000000183A56630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x0000000183A55D40-0x0000000183A55DE0 0x0000000183A54EE0-0x0000000183A54F80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25879
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25880
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4285
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetCreateGadgetReq() {} // 0x0000000183A56A90-0x0000000183A56AF0
	static UseWidgetCreateGadgetReq() {} // 0x0000000183A569D0-0x0000000183A56A90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetCreateGadgetReq Clone() => default; // 0x0000000183A56010-0x0000000183A56100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseWidgetCreateGadgetReq ShallowCopy() => default; // 0x0000000183A55900-0x0000000183A559A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A55180-0x0000000183A55210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A56220-0x0000000183A562B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A562B0-0x0000000183A56340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A55210-0x0000000183A55400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A55560-0x0000000183A55630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseWidgetCreateGadgetReq other) => default; // 0x0000000183A55400-0x0000000183A55560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A55A90-0x0000000183A55CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A56770-0x0000000183A569D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A56440-0x0000000183A56590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A55630-0x0000000183A55880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseWidgetCreateGadgetReq other) {} // 0x0000000183A54F80-0x0000000183A55180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A54CF0-0x0000000183A54E80
}

