/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AllWidgetDataNotify : MessageBase, IMessage<AllWidgetDataNotify> // TypeDefIndex: 25875
{
	// Fields
	private static readonly MessageParser<AllWidgetDataNotify> _parser; // 0x00
	public const int AnchorPointListFieldNumber = 2; // Metadata: 0x00B09C37
	private static readonly FieldCodec<AnchorPointData> _repeated_anchorPointList_codec; // 0x08
	private readonly RepeatedMessageField<AnchorPointData> anchorPointList_; // 0x18
	public const int NextAnchorPointUsableTimeFieldNumber = 3; // Metadata: 0x00B09C3B
	private uint nextAnchorPointUsableTime_; // 0x20
	public const int NextBonfireUsableTimeFieldNumber = 4; // Metadata: 0x00B09C3F
	private uint nextBonfireUsableTime_; // 0x24
	public const int LunchBoxDataFieldNumber = 5; // Metadata: 0x00B09C43
	private LunchBoxData lunchBoxData_; // 0x28
	public const int OneoffGatherPointDetectorDataListFieldNumber = 6; // Metadata: 0x00B09C47
	private static readonly FieldCodec<OneoffGatherPointDetectorData> _repeated_oneoffGatherPointDetectorDataList_codec; // 0x10
	private readonly RepeatedMessageField<OneoffGatherPointDetectorData> oneoffGatherPointDetectorDataList_; // 0x30
	public const int ClientCollectorDataListFieldNumber = 7; // Metadata: 0x00B09C4B
	private static readonly FieldCodec<ClientCollectorData> _repeated_clientCollectorDataList_codec; // 0x18
	private readonly RepeatedMessageField<ClientCollectorData> clientCollectorDataList_; // 0x38
	public const int CoolDownGroupDataListFieldNumber = 8; // Metadata: 0x00B09C4F
	private static readonly FieldCodec<WidgetCoolDownData> _repeated_coolDownGroupDataList_codec; // 0x20
	private readonly RepeatedMessageField<WidgetCoolDownData> coolDownGroupDataList_; // 0x40
	public const int NormalCoolDownDataListFieldNumber = 9; // Metadata: 0x00B09C53
	private static readonly FieldCodec<WidgetCoolDownData> _repeated_normalCoolDownDataList_codec; // 0x28
	private readonly RepeatedMessageField<WidgetCoolDownData> normalCoolDownDataList_; // 0x48
	public const int SlotListFieldNumber = 11; // Metadata: 0x00B09C57
	private static readonly FieldCodec<WidgetSlotData> _repeated_slotList_codec; // 0x30
	private readonly RepeatedMessageField<WidgetSlotData> slotList_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AllWidgetDataNotify> Parser { get => default; } // 0x00000001823DEE60-0x00000001823DEEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823DEA90-0x00000001823DEB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823DE600-0x00000001823DE680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823DD730-0x00000001823DD790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823DF7B0-0x00000001823DF8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823DF320-0x00000001823DF380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823DEC20-0x00000001823DED10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823DF660-0x00000001823DF6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823DE720-0x00000001823DE810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AnchorPointData> AnchorPointList { get => default; } // 0x00000001823DEE00-0x00000001823DEE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextAnchorPointUsableTime { get => default; set {} } // 0x00000001823DD690-0x00000001823DD730 0x00000001823DF710-0x00000001823DF7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextBonfireUsableTime { get => default; set {} } // 0x00000001823DD790-0x00000001823DD830 0x00000001823DF150-0x00000001823DF1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData LunchBoxData { get => default; set {} } // 0x00000001823DF0B0-0x00000001823DF150 0x00000001823DEB20-0x00000001823DEBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OneoffGatherPointDetectorData> OneoffGatherPointDetectorDataList { get => default; } // 0x00000001823DF8A0-0x00000001823DF900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ClientCollectorData> ClientCollectorDataList { get => default; } // 0x00000001823DE5A0-0x00000001823DE600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetCoolDownData> CoolDownGroupDataList { get => default; } // 0x00000001823DF6B0-0x00000001823DF710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetCoolDownData> NormalCoolDownDataList { get => default; } // 0x00000001823DEBC0-0x00000001823DEC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WidgetSlotData> SlotList { get => default; } // 0x00000001823DDEC0-0x00000001823DDF20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25876
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25877
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4284
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllWidgetDataNotify() {} // 0x00000001823E00A0-0x00000001823E01E0
	static AllWidgetDataNotify() {} // 0x00000001823DFE20-0x00000001823E00A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllWidgetDataNotify Clone() => default; // 0x00000001823DED10-0x00000001823DEE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AllWidgetDataNotify ShallowCopy() => default; // 0x00000001823DE680-0x00000001823DE720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823DDAF0-0x00000001823DDB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823DEF80-0x00000001823DF0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823DF1F0-0x00000001823DF320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823DDB70-0x00000001823DDEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823DDF20-0x00000001823DDFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AllWidgetDataNotify other) => default; // 0x00000001823DDFF0-0x00000001823DE250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823DE810-0x00000001823DEA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823DF900-0x00000001823DFE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823DF380-0x00000001823DF660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823DE250-0x00000001823DE5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AllWidgetDataNotify other) {} // 0x00000001823DD830-0x00000001823DDAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823DD2C0-0x00000001823DD690
}

