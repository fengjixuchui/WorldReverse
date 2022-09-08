/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightActivityRestartRsp : MessageBase, IMessage<FlightActivityRestartRsp> // TypeDefIndex: 22039
{
	// Fields
	private static readonly MessageParser<FlightActivityRestartRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00A2F
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B00A33
	private uint scheduleId_; // 0x1C
	public const int GroupIdFieldNumber = 3; // Metadata: 0x00B00A37
	private uint groupId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FlightActivityRestartRsp> Parser { get => default; } // 0x00000001815AC4B0-0x00000001815AC540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815AC1A0-0x00000001815AC230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815ABE60-0x00000001815ABEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815AB5C0-0x00000001815AB620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815AC920-0x00000001815ACA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815AC670-0x00000001815AC6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815AC230-0x00000001815AC320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815AC8D0-0x00000001815AC920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815ABF80-0x00000001815AC070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001815ABD20-0x00000001815ABDC0 0x00000001815AB8F0-0x00000001815AB990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001815AB850-0x00000001815AB8F0 0x00000001815AC6D0-0x00000001815AC770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001815AC320-0x00000001815AC3C0 0x00000001815ABDC0-0x00000001815ABE60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22040
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22041
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2072
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartRsp() {} // 0x00000001815ACD60-0x00000001815ACDC0
	static FlightActivityRestartRsp() {} // 0x00000001815ACCA0-0x00000001815ACD60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartRsp Clone() => default; // 0x00000001815AC3C0-0x00000001815AC4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartRsp ShallowCopy() => default; // 0x00000001815ABEE0-0x00000001815ABF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815AB780-0x00000001815AB7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815AC5D0-0x00000001815AC620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815AC620-0x00000001815AC670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815AB7D0-0x00000001815AB850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815ABAD0-0x00000001815ABBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FlightActivityRestartRsp other) => default; // 0x00000001815AB990-0x00000001815ABAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815AC070-0x00000001815AC1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815ACA10-0x00000001815ACCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815AC770-0x00000001815AC8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815ABBA0-0x00000001815ABD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FlightActivityRestartRsp other) {} // 0x00000001815AB620-0x00000001815AB780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815AB4B0-0x00000001815AB5C0
}

