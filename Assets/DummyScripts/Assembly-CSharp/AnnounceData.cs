/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnnounceData : MessageBase, IMessage<AnnounceData> // TypeDefIndex: 21928
{
	// Fields
	private static readonly MessageParser<AnnounceData> _parser; // 0x00
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B005EB
	private uint configId_; // 0x18
	public const int BeginTimeFieldNumber = 2; // Metadata: 0x00B005EF
	private uint beginTime_; // 0x1C
	public const int EndTimeFieldNumber = 3; // Metadata: 0x00B005F3
	private uint endTime_; // 0x20
	public const int CenterSystemTextFieldNumber = 4; // Metadata: 0x00B005F7
	private string centerSystemText_; // 0x28
	public const int CountDownTextFieldNumber = 5; // Metadata: 0x00B005FB
	private string countDownText_; // 0x30
	public const int DungeonConfirmTextFieldNumber = 6; // Metadata: 0x00B005FF
	private string dungeonConfirmText_; // 0x38
	public const int CenterSystemFrequencyFieldNumber = 7; // Metadata: 0x00B00603
	private uint centerSystemFrequency_; // 0x40
	public const int CountDownFrequencyFieldNumber = 8; // Metadata: 0x00B00607
	private uint countDownFrequency_; // 0x44
	public const int IsCenterSystemLast5EveryMinutesFieldNumber = 9; // Metadata: 0x00B0060B
	private bool isCenterSystemLast5EveryMinutes_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnnounceData> Parser { get => default; } // 0x0000000181684360-0x00000001816843F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181683DC0-0x0000000181683E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181683850-0x00000001816838D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816829C0-0x0000000181682A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181684C30-0x0000000181684D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181684700-0x0000000181684760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181684030-0x0000000181684120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181684B30-0x0000000181684B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181683A10-0x0000000181683B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000181683F90-0x0000000181684030 0x0000000181682AC0-0x0000000181682B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000181684A90-0x0000000181684B30 0x00000001816845C0-0x0000000181684660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000181684210-0x00000001816842B0 0x0000000181684660-0x0000000181684700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CenterSystemText { get => default; set {} } // 0x0000000181684520-0x00000001816845C0 0x0000000181684B80-0x0000000181684C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CountDownText { get => default; set {} } // 0x0000000181682F90-0x0000000181683030 0x0000000181682C00-0x0000000181682CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DungeonConfirmText { get => default; set {} } // 0x0000000181684D20-0x0000000181684DC0 0x00000001816842B0-0x0000000181684360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CenterSystemFrequency { get => default; set {} } // 0x0000000181683EF0-0x0000000181683F90 0x0000000181682A20-0x0000000181682AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CountDownFrequency { get => default; set {} } // 0x0000000181682B60-0x0000000181682C00 0x00000001816837B0-0x0000000181683850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCenterSystemLast5EveryMinutes { get => default; set {} } // 0x0000000181683E50-0x0000000181683EF0 0x00000001816838D0-0x0000000181683970

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnnounceData() {} // 0x0000000181685400-0x0000000181685490
	static AnnounceData() {} // 0x0000000181685340-0x0000000181685400

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnnounceData Clone() => default; // 0x0000000181684120-0x0000000181684210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnnounceData ShallowCopy() => default; // 0x0000000181683970-0x0000000181683A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181682F40-0x0000000181682F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181684480-0x00000001816844D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816844D0-0x0000000181684520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181683030-0x0000000181683110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181683110-0x00000001816831E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnnounceData other) => default; // 0x00000001816831E0-0x0000000181683460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181683B00-0x0000000181683DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181684DC0-0x0000000181685340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181684760-0x0000000181684A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181683460-0x00000001816837B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnnounceData other) {} // 0x0000000181682CB0-0x0000000181682F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816827F0-0x00000001816829C0
}

