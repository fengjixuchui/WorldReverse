/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FinishDeliveryNotify : MessageBase, IMessage<FinishDeliveryNotify> // TypeDefIndex: 21995
{
	// Fields
	private static readonly MessageParser<FinishDeliveryNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B0086F
	private uint scheduleId_; // 0x18
	public const int DayIndexFieldNumber = 2; // Metadata: 0x00B00873
	private uint dayIndex_; // 0x1C
	public const int FinishedQuestIndexFieldNumber = 3; // Metadata: 0x00B00877
	private uint finishedQuestIndex_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FinishDeliveryNotify> Parser { get => default; } // 0x00000001851B8330-0x00000001851B83C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851B7F80-0x00000001851B8010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851B7BA0-0x00000001851B7C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851B74E0-0x00000001851B7540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851B87A0-0x00000001851B8890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851B84F0-0x00000001851B8550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851B8010-0x00000001851B8100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851B8750-0x00000001851B87A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851B7D60-0x00000001851B7E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001851B7770-0x00000001851B7810 0x00000001851B8550-0x00000001851B85F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x00000001851B81F0-0x00000001851B8290 0x00000001851B8290-0x00000001851B8330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedQuestIndex { get => default; set {} } // 0x00000001851B7CC0-0x00000001851B7D60 0x00000001851B8890-0x00000001851B8930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21996
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21997
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2053
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishDeliveryNotify() {} // 0x00000001851B8C80-0x00000001851B8CE0
	static FinishDeliveryNotify() {} // 0x00000001851B8BC0-0x00000001851B8C80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishDeliveryNotify Clone() => default; // 0x00000001851B8100-0x00000001851B81F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishDeliveryNotify ShallowCopy() => default; // 0x00000001851B7C20-0x00000001851B7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851B76A0-0x00000001851B76F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851B8450-0x00000001851B84A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851B84A0-0x00000001851B84F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851B76F0-0x00000001851B7770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851B7950-0x00000001851B7A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FinishDeliveryNotify other) => default; // 0x00000001851B7810-0x00000001851B7950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851B7E50-0x00000001851B7F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851B8930-0x00000001851B8BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851B85F0-0x00000001851B8750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851B7A20-0x00000001851B7BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FinishDeliveryNotify other) {} // 0x00000001851B7540-0x00000001851B76A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851B73D0-0x00000001851B74E0
}

