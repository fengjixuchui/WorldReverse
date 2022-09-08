/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetWidgetSlotReq : MessageBase, IMessage<SetWidgetSlotReq> // TypeDefIndex: 25860
{
	// Fields
	private static readonly MessageParser<SetWidgetSlotReq> _parser; // 0x00
	public const int OpFieldNumber = 2; // Metadata: 0x00B09BB3
	private WidgetSlotOp op_; // 0x18
	public const int TagListFieldNumber = 3; // Metadata: 0x00B09BB7
	private static readonly FieldCodec<WidgetSlotTag> _repeated_tagList_codec; // 0x08
	private readonly RepeatedPrimitiveField<WidgetSlotTag> tagList_; // 0x20
	public const int MaterialIdFieldNumber = 4; // Metadata: 0x00B09BBB
	private uint materialId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetWidgetSlotReq> Parser { get => default; } // 0x0000000182E15A60-0x0000000182E15AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E15550-0x0000000182E155E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E15130-0x0000000182E151B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E14AA0-0x0000000182E14B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E15EB0-0x0000000182E15FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E15C20-0x0000000182E15C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E15820-0x0000000182E15910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E15E60-0x0000000182E15EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E15250-0x0000000182E15340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotOp Op { get => default; set {} } // 0x0000000182E155E0-0x0000000182E15680 0x0000000182E154B0-0x0000000182E15550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<WidgetSlotTag> TagList { get => default; } // 0x0000000182E15680-0x0000000182E156E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x0000000182E156E0-0x0000000182E15780 0x0000000182E15780-0x0000000182E15820

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25861
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25862
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4279
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotReq() {} // 0x0000000182E16360-0x0000000182E16400
	static SetWidgetSlotReq() {} // 0x0000000182E16210-0x0000000182E16360

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotReq Clone() => default; // 0x0000000182E15910-0x0000000182E15A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotReq ShallowCopy() => default; // 0x0000000182E151B0-0x0000000182E15250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E14C60-0x0000000182E14CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E15B80-0x0000000182E15BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E15BD0-0x0000000182E15C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E14CB0-0x0000000182E14D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E14ED0-0x0000000182E14FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetWidgetSlotReq other) => default; // 0x0000000182E14D90-0x0000000182E14ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E15340-0x0000000182E154B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E15FA0-0x0000000182E16210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E15C80-0x0000000182E15E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E14FA0-0x0000000182E15130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetWidgetSlotReq other) {} // 0x0000000182E14B00-0x0000000182E14C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E14930-0x0000000182E14AA0
}

