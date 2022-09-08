/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightActivityRestartReq : MessageBase, IMessage<FlightActivityRestartReq> // TypeDefIndex: 22036
{
	// Fields
	private static readonly MessageParser<FlightActivityRestartReq> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B00A13
	private uint scheduleId_; // 0x18
	public const int GroupIdFieldNumber = 3; // Metadata: 0x00B00A17
	private uint groupId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FlightActivityRestartReq> Parser { get => default; } // 0x0000000184A2FC10-0x0000000184A2FCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A2F900-0x0000000184A2F990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A2F5F0-0x0000000184A2F670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A2EF40-0x0000000184A2EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A30040-0x0000000184A30130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A2FDD0-0x0000000184A2FE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A2F990-0x0000000184A2FA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A2FFF0-0x0000000184A30040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A2F710-0x0000000184A2F800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000184A2F190-0x0000000184A2F230 0x0000000184A2FE30-0x0000000184A2FED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000184A2FA80-0x0000000184A2FB20 0x0000000184A2F550-0x0000000184A2F5F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22037
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22038
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2071
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartReq() {} // 0x0000000184A303F0-0x0000000184A30450
	static FlightActivityRestartReq() {} // 0x0000000184A30330-0x0000000184A303F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartReq Clone() => default; // 0x0000000184A2FB20-0x0000000184A2FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityRestartReq ShallowCopy() => default; // 0x0000000184A2F670-0x0000000184A2F710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A2F0D0-0x0000000184A2F120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A2FD30-0x0000000184A2FD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A2FD80-0x0000000184A2FDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A2F120-0x0000000184A2F190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A2F230-0x0000000184A2F300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FlightActivityRestartReq other) => default; // 0x0000000184A2F300-0x0000000184A2F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A2F800-0x0000000184A2F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A30130-0x0000000184A30330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A2FED0-0x0000000184A2FFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A2F420-0x0000000184A2F550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FlightActivityRestartReq other) {} // 0x0000000184A2EFA0-0x0000000184A2F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A2EE40-0x0000000184A2EF40
}

