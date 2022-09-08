/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampActivityInfo : MessageBase, IMessage<SeaLampActivityInfo> // TypeDefIndex: 21918
{
	// Fields
	private static readonly MessageParser<SeaLampActivityInfo> _parser; // 0x00
	public const int DayIndexFieldNumber = 1; // Metadata: 0x00B0057F
	private uint dayIndex_; // 0x18
	public const int PopularityFieldNumber = 2; // Metadata: 0x00B00583
	private uint popularity_; // 0x1C
	public const int SeaLampCoinFieldNumber = 3; // Metadata: 0x00B00587
	private uint seaLampCoin_; // 0x20
	public const int IsContentClosedFieldNumber = 4; // Metadata: 0x00B0058B
	private bool isContentClosed_; // 0x24
	public const int SectionInfoListFieldNumber = 5; // Metadata: 0x00B0058F
	private static readonly FieldCodec<SeaLampSectionInfo> _repeated_sectionInfoList_codec; // 0x08
	private readonly RepeatedMessageField<SeaLampSectionInfo> sectionInfoList_; // 0x28
	public const int MechanicusIdFieldNumber = 6; // Metadata: 0x00B00593
	private uint mechanicusId_; // 0x30
	public const int IsMechanicusOpenFieldNumber = 7; // Metadata: 0x00B00597
	private bool isMechanicusOpen_; // 0x34
	public const int FirstDayStartTimeFieldNumber = 8; // Metadata: 0x00B0059B
	private uint firstDayStartTime_; // 0x38
	public const int IsMechanicusFeatureCloseFieldNumber = 9; // Metadata: 0x00B0059F
	private bool isMechanicusFeatureClose_; // 0x3C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampActivityInfo> Parser { get => default; } // 0x00000001850A2250-0x00000001850A22E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850A1D00-0x00000001850A1D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850A1830-0x00000001850A18B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850A0A00-0x00000001850A0A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850A2AC0-0x00000001850A2BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850A2530-0x00000001850A2590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850A1F30-0x00000001850A2020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850A2A70-0x00000001850A2AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850A1950-0x00000001850A1A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x00000001850A2110-0x00000001850A21B0 0x00000001850A21B0-0x00000001850A2250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Popularity { get => default; set {} } // 0x00000001850A1D90-0x00000001850A1E30 0x00000001850A2630-0x00000001850A26D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SeaLampCoin { get => default; set {} } // 0x00000001850A2590-0x00000001850A2630 0x00000001850A1790-0x00000001850A1830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x00000001850A0A60-0x00000001850A0B00 0x00000001850A10E0-0x00000001850A1180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SeaLampSectionInfo> SectionInfoList { get => default; } // 0x00000001850A1ED0-0x00000001850A1F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x00000001850A1E30-0x00000001850A1ED0 0x00000001850A1040-0x00000001850A10E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMechanicusOpen { get => default; set {} } // 0x00000001850A1180-0x00000001850A1220 0x00000001850A0E10-0x00000001850A0EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FirstDayStartTime { get => default; set {} } // 0x00000001850A2400-0x00000001850A24A0 0x00000001850A1C60-0x00000001850A1D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMechanicusFeatureClose { get => default; set {} } // 0x00000001850A26D0-0x00000001850A2770 0x00000001850A0B00-0x00000001850A0BA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityInfo() {} // 0x00000001850A3280-0x00000001850A3310
	static SeaLampActivityInfo() {} // 0x00000001850A3170-0x00000001850A3280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityInfo Clone() => default; // 0x00000001850A2020-0x00000001850A2110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityInfo ShallowCopy() => default; // 0x00000001850A18B0-0x00000001850A1950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850A0EB0-0x00000001850A0F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A2370-0x00000001850A2400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A24A0-0x00000001850A2530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850A0F00-0x00000001850A1040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850A1220-0x00000001850A12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampActivityInfo other) => default; // 0x00000001850A12F0-0x00000001850A14F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850A1A40-0x00000001850A1C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850A2BB0-0x00000001850A3170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850A2770-0x00000001850A2A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850A14F0-0x00000001850A1790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampActivityInfo other) {} // 0x00000001850A0BA0-0x00000001850A0E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850A07C0-0x00000001850A0A00
}

