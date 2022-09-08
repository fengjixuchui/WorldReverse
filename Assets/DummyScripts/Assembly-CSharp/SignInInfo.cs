/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SignInInfo : MessageBase, IMessage<SignInInfo> // TypeDefIndex: 25448
{
	// Fields
	private static readonly MessageParser<SignInInfo> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B08C8B
	private uint scheduleId_; // 0x18
	public const int ConfigIdFieldNumber = 2; // Metadata: 0x00B08C8F
	private uint configId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B08C93
	private uint beginTime_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B08C97
	private uint endTime_; // 0x24
	public const int IsCondSatisfiedFieldNumber = 10; // Metadata: 0x00B08C9B
	private bool isCondSatisfied_; // 0x28
	public const int SignInCountFieldNumber = 11; // Metadata: 0x00B08C9F
	private uint signInCount_; // 0x2C
	public const int LastSignInTimeFieldNumber = 12; // Metadata: 0x00B08CA3
	private uint lastSignInTime_; // 0x30
	public const int RewardDayListFieldNumber = 13; // Metadata: 0x00B08CA7
	private static readonly FieldCodec<uint> _repeated_rewardDayList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> rewardDayList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SignInInfo> Parser { get => default; } // 0x00000001828F8BB0-0x00000001828F8C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828F86C0-0x00000001828F8750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828F8220-0x00000001828F82A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828F7700-0x00000001828F7760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828F9490-0x00000001828F9580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828F8F50-0x00000001828F8FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828F8930-0x00000001828F8A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828F93A0-0x00000001828F93F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828F8340-0x00000001828F8430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001828F7C10-0x00000001828F7CB0 0x00000001828F8FB0-0x00000001828F9050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x00000001828F8890-0x00000001828F8930 0x00000001828F7800-0x00000001828F78A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001828F9300-0x00000001828F93A0 0x00000001828F8E10-0x00000001828F8EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001828F8B10-0x00000001828F8BB0 0x00000001828F8EB0-0x00000001828F8F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCondSatisfied { get => default; set {} } // 0x00000001828F7760-0x00000001828F7800 0x00000001828F8CD0-0x00000001828F8D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignInCount { get => default; set {} } // 0x00000001828F8620-0x00000001828F86C0 0x00000001828F8750-0x00000001828F87F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastSignInTime { get => default; set {} } // 0x00000001828F93F0-0x00000001828F9490 0x00000001828F87F0-0x00000001828F8890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RewardDayList { get => default; } // 0x00000001828F9580-0x00000001828F95E0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfo() {} // 0x00000001828F9BF0-0x00000001828F9C80
	static SignInInfo() {} // 0x00000001828F9B10-0x00000001828F9BF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfo Clone() => default; // 0x00000001828F8A20-0x00000001828F8B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfo ShallowCopy() => default; // 0x00000001828F82A0-0x00000001828F8340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828F7AB0-0x00000001828F7B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828F8D70-0x00000001828F8DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828F8DC0-0x00000001828F8E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828F7B00-0x00000001828F7C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828F7E90-0x00000001828F7F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SignInInfo other) => default; // 0x00000001828F7CB0-0x00000001828F7E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828F8430-0x00000001828F8620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828F95E0-0x00000001828F9B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828F9050-0x00000001828F9300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828F7F60-0x00000001828F8220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SignInInfo other) {} // 0x00000001828F78A0-0x00000001828F7AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828F74F0-0x00000001828F7700
}

