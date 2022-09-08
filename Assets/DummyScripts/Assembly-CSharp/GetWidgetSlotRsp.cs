/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetWidgetSlotRsp : MessageBase, IMessage<GetWidgetSlotRsp> // TypeDefIndex: 25872
{
	// Fields
	private static readonly MessageParser<GetWidgetSlotRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09C1F
	private int retcode_; // 0x18
	public const int SlotListFieldNumber = 2; // Metadata: 0x00B09C23
	private static readonly FieldCodec<WidgetSlotData> _repeated_slotList_codec; // 0x08
	private readonly RepeatedMessageField<WidgetSlotData> slotList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetWidgetSlotRsp> Parser { get => default; } // 0x00000001848E1D50-0x00000001848E1DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848E1AE0-0x00000001848E1B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848E17D0-0x00000001848E1850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848E1000-0x00000001848E1060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848E2180-0x00000001848E2270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848E1F90-0x00000001848E1FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848E1B70-0x00000001848E1C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848E2130-0x00000001848E2180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848E18F0-0x00000001848E19E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001848E1730-0x00000001848E17D0 0x00000001848E1350-0x00000001848E13F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetSlotData> SlotList { get => default; } // 0x00000001848E12F0-0x00000001848E1350 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25873
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25874
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4283
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWidgetSlotRsp() {} // 0x00000001848E2560-0x00000001848E25F0
	static GetWidgetSlotRsp() {} // 0x00000001848E2450-0x00000001848E2560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWidgetSlotRsp Clone() => default; // 0x00000001848E1C60-0x00000001848E1D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetWidgetSlotRsp ShallowCopy() => default; // 0x00000001848E1850-0x00000001848E18F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848E11C0-0x00000001848E1210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848E1E70-0x00000001848E1F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848E1F00-0x00000001848E1F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848E1210-0x00000001848E12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848E1520-0x00000001848E15F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetWidgetSlotRsp other) => default; // 0x00000001848E13F0-0x00000001848E1520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848E19E0-0x00000001848E1AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848E2270-0x00000001848E2450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848E1FF0-0x00000001848E2130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848E15F0-0x00000001848E1730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetWidgetSlotRsp other) {} // 0x00000001848E1060-0x00000001848E11C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848E0EA0-0x00000001848E1000
}

