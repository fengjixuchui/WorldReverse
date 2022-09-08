/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FindHilichurlDetailInfo : MessageBase, IMessage<FindHilichurlDetailInfo> // TypeDefIndex: 22373
{
	// Fields
	private static readonly MessageParser<FindHilichurlDetailInfo> _parser; // 0x00
	public const int DayIndexFieldNumber = 1; // Metadata: 0x00B016F7
	private uint dayIndex_; // 0x18
	public const int PlayerDayIndexFieldNumber = 2; // Metadata: 0x00B016FB
	private uint playerDayIndex_; // 0x1C
	public const int DayContentInfoListFieldNumber = 3; // Metadata: 0x00B016FF
	private static readonly FieldCodec<FindHilichurlDayContentInfo> _repeated_dayContentInfoList_codec; // 0x08
	private readonly RepeatedMessageField<FindHilichurlDayContentInfo> dayContentInfoList_; // 0x20
	public const int IsContentClosedFieldNumber = 4; // Metadata: 0x00B01703
	private bool isContentClosed_; // 0x28
	public const int ContentCloseTimeFieldNumber = 5; // Metadata: 0x00B01707
	private uint contentCloseTime_; // 0x2C
	public const int MinOpenPlayerLevelFieldNumber = 6; // Metadata: 0x00B0170B
	private uint minOpenPlayerLevel_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FindHilichurlDetailInfo> Parser { get => default; } // 0x00000001829370C0-0x0000000182937150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182936D10-0x0000000182936DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182936940-0x00000001829369C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182935DB0-0x0000000182935E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829377D0-0x00000001829378C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182937440-0x00000001829374A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182936DA0-0x0000000182936E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829376E0-0x0000000182937730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182936A60-0x0000000182936B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x0000000182936F80-0x0000000182937020 0x0000000182937020-0x00000001829370C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerDayIndex { get => default; set {} } // 0x0000000182936350-0x00000001829363F0 0x00000001829362B0-0x0000000182936350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FindHilichurlDayContentInfo> DayContentInfoList { get => default; } // 0x00000001829378C0-0x0000000182937920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x0000000182935E10-0x0000000182935EB0 0x0000000182936210-0x00000001829362B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x0000000182937730-0x00000001829377D0 0x00000001829368A0-0x0000000182936940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinOpenPlayerLevel { get => default; set {} } // 0x0000000182937150-0x00000001829371F0 0x0000000182937280-0x0000000182937320

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FindHilichurlDetailInfo() {} // 0x0000000182937E40-0x0000000182937ED0
	static FindHilichurlDetailInfo() {} // 0x0000000182937D30-0x0000000182937E40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FindHilichurlDetailInfo Clone() => default; // 0x0000000182936E90-0x0000000182936F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FindHilichurlDetailInfo ShallowCopy() => default; // 0x00000001829369C0-0x0000000182936A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829360B0-0x0000000182936100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182937320-0x00000001829373B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829373B0-0x0000000182937440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182936100-0x0000000182936210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829363F0-0x00000001829364C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FindHilichurlDetailInfo other) => default; // 0x00000001829364C0-0x0000000182936670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182936B50-0x0000000182936D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182937920-0x0000000182937D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001829374A0-0x00000001829376E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182936670-0x00000001829368A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FindHilichurlDetailInfo other) {} // 0x0000000182935EB0-0x00000001829360B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182935BD0-0x0000000182935DB0
}

