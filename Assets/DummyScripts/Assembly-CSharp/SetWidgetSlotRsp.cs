/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetWidgetSlotRsp : MessageBase, IMessage<SetWidgetSlotRsp> // TypeDefIndex: 25863
{
	// Fields
	private static readonly MessageParser<SetWidgetSlotRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09BD3
	private int retcode_; // 0x18
	public const int OpFieldNumber = 2; // Metadata: 0x00B09BD7
	private WidgetSlotOp op_; // 0x1C
	public const int TagListFieldNumber = 3; // Metadata: 0x00B09BDB
	private static readonly FieldCodec<WidgetSlotTag> _repeated_tagList_codec; // 0x08
	private readonly RepeatedPrimitiveField<WidgetSlotTag> tagList_; // 0x20
	public const int MaterialIdFieldNumber = 4; // Metadata: 0x00B09BDF
	private uint materialId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetWidgetSlotRsp> Parser { get => default; } // 0x000000018293EBC0-0x000000018293EC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018293E6B0-0x000000018293E740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018293E270-0x000000018293E2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018293DA00-0x000000018293DA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018293F050-0x000000018293F140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018293ED80-0x000000018293EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018293E980-0x000000018293EA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018293F000-0x000000018293F050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018293E390-0x000000018293E480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018293E1D0-0x000000018293E270 0x000000018293DD20-0x000000018293DDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetSlotOp Op { get => default; set {} } // 0x000000018293E740-0x000000018293E7E0 0x000000018293E610-0x000000018293E6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<WidgetSlotTag> TagList { get => default; } // 0x000000018293E7E0-0x000000018293E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x000000018293E840-0x000000018293E8E0 0x000000018293E8E0-0x000000018293E980

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25864
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25865
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4280
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotRsp() {} // 0x000000018293F590-0x000000018293F630
	static SetWidgetSlotRsp() {} // 0x000000018293F440-0x000000018293F590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotRsp Clone() => default; // 0x000000018293EA70-0x000000018293EB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetWidgetSlotRsp ShallowCopy() => default; // 0x000000018293E2F0-0x000000018293E390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018293DBE0-0x000000018293DC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018293ECE0-0x000000018293ED30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018293ED30-0x000000018293ED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018293DC30-0x000000018293DD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018293DDC0-0x000000018293DE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetWidgetSlotRsp other) => default; // 0x000000018293DE90-0x000000018293DFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018293E480-0x000000018293E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018293F140-0x000000018293F440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018293EDE0-0x000000018293EFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018293DFF0-0x000000018293E1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetWidgetSlotRsp other) {} // 0x000000018293DA60-0x000000018293DBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018293D870-0x000000018293DA00
}

