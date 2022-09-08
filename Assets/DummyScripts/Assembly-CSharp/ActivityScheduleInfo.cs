/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityScheduleInfo : MessageBase, IMessage<ActivityScheduleInfo> // TypeDefIndex: 21852
{
	// Fields
	private static readonly MessageParser<ActivityScheduleInfo> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B0022F
	private uint activityId_; // 0x18
	public const int IsOpenFieldNumber = 2; // Metadata: 0x00B00233
	private bool isOpen_; // 0x1C
	public const int ScheduleIdFieldNumber = 3; // Metadata: 0x00B00237
	private uint scheduleId_; // 0x20
	public const int BeginTimeFieldNumber = 4; // Metadata: 0x00B0023B
	private uint beginTime_; // 0x24
	public const int EndTimeFieldNumber = 5; // Metadata: 0x00B0023F
	private uint endTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityScheduleInfo> Parser { get => default; } // 0x0000000185514990-0x0000000185514A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185514680-0x0000000185514710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001855142E0-0x0000000185514360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001855139E0-0x0000000185513A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001855151A0-0x0000000185515290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185514D30-0x0000000185514D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185514710-0x0000000185514800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185515150-0x00000001855151A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185514400-0x00000001855144F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000185514BF0-0x0000000185514C90 0x0000000185513AE0-0x0000000185513B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000185514E30-0x0000000185514ED0 0x0000000185513A40-0x0000000185513AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000185513E20-0x0000000185513EC0 0x0000000185514D90-0x0000000185514E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001855150B0-0x0000000185515150 0x0000000185514B50-0x0000000185514BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001855148F0-0x0000000185514990 0x0000000185514C90-0x0000000185514D30

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfo() {} // 0x00000001855156F0-0x0000000185515750
	static ActivityScheduleInfo() {} // 0x0000000185515630-0x00000001855156F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfo Clone() => default; // 0x0000000185514800-0x00000001855148F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityScheduleInfo ShallowCopy() => default; // 0x0000000185514360-0x0000000185514400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185513D30-0x0000000185513D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185514AB0-0x0000000185514B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185514B00-0x0000000185514B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185513D80-0x0000000185513E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185514030-0x0000000185514100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityScheduleInfo other) => default; // 0x0000000185513EC0-0x0000000185514030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001855144F0-0x0000000185514680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185515290-0x0000000185515630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185514ED0-0x00000001855150B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185514100-0x00000001855142E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityScheduleInfo other) {} // 0x0000000185513B80-0x0000000185513D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185513890-0x00000001855139E0
}

