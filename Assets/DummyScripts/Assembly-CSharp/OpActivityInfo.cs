/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpActivityInfo : MessageBase, IMessage<OpActivityInfo> // TypeDefIndex: 24238
{
	// Fields
	private static readonly MessageParser<OpActivityInfo> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B05EA7
	private uint activityId_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B05EAB
	private uint scheduleId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B05EAF
	private uint beginTime_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B05EB3
	private uint endTime_; // 0x24
	public const int BonusInfoFieldNumber = 5; // Metadata: 0x00B05EB7
	public const int IsHasChangeFieldNumber = 6; // Metadata: 0x00B05EBB
	private bool isHasChange_; // 0x28
	private object detail_; // 0x30
	private DetailOneofCase detailCase_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpActivityInfo> Parser { get => default; } // 0x0000000183D0D220-0x0000000183D0D2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D0CF10-0x0000000183D0CFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D0CA60-0x0000000183D0CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D0BD40-0x0000000183D0BDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D0DB40-0x0000000183D0DC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D0D6A0-0x0000000183D0D700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D0CFA0-0x0000000183D0D090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D0DAF0-0x0000000183D0DB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D0CC50-0x0000000183D0CD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183D0D560-0x0000000183D0D600 0x0000000183D0BE00-0x0000000183D0BEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000183D0C340-0x0000000183D0C3E0 0x0000000183D0D700-0x0000000183D0D7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000183D0DA50-0x0000000183D0DAF0 0x0000000183D0D4C0-0x0000000183D0D560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000183D0D180-0x0000000183D0D220 0x0000000183D0D600-0x0000000183D0D6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusOpActivityInfo BonusInfo { get => default; set {} } // 0x0000000183D0CB80-0x0000000183D0CC50 0x0000000183D0C1F0-0x0000000183D0C290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsHasChange { get => default; set {} } // 0x0000000183D0D7A0-0x0000000183D0D840 0x0000000183D0C8A0-0x0000000183D0C940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x0000000183D0C190-0x0000000183D0C1F0 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 24239
	{
		None = 0,
		BonusInfo = 5
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityInfo() {} // 0x0000000183D0E1A0-0x0000000183D0E210
	static OpActivityInfo() {} // 0x0000000183D0E0E0-0x0000000183D0E1A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityInfo Clone() => default; // 0x0000000183D0D090-0x0000000183D0D180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityInfo ShallowCopy() => default; // 0x0000000183D0CAE0-0x0000000183D0CB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D0C0D0-0x0000000183D0C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D0D340-0x0000000183D0D400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D0D400-0x0000000183D0D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D0C290-0x0000000183D0C340
	public void resetDetail() {} // 0x0000000183D0C940-0x0000000183D0CA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x0000000183D0BDA0-0x0000000183D0BE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D0C5B0-0x0000000183D0C680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpActivityInfo other) => default; // 0x0000000183D0C3E0-0x0000000183D0C5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D0CD40-0x0000000183D0CF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D0DC30-0x0000000183D0E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D0D840-0x0000000183D0DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D0C680-0x0000000183D0C8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpActivityInfo other) {} // 0x0000000183D0BEA0-0x0000000183D0C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D0BB40-0x0000000183D0BD40
}

