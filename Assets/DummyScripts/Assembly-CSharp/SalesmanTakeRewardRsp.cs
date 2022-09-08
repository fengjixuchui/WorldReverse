/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SalesmanTakeRewardRsp : MessageBase, IMessage<SalesmanTakeRewardRsp> // TypeDefIndex: 21948
{
	// Fields
	private static readonly MessageParser<SalesmanTakeRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B006C3
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B006C7
	private uint scheduleId_; // 0x1C
	public const int RewardIdFieldNumber = 3; // Metadata: 0x00B006CB
	private uint rewardId_; // 0x20
	public const int PositionFieldNumber = 4; // Metadata: 0x00B006CF
	private uint position_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SalesmanTakeRewardRsp> Parser { get => default; } // 0x0000000183A79F50-0x0000000183A79FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A79BA0-0x0000000183A79C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A79790-0x0000000183A79810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A78F00-0x0000000183A78F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A7A4A0-0x0000000183A7A590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A7A1B0-0x0000000183A7A210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A79C30-0x0000000183A79D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A7A450-0x0000000183A7A4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A79950-0x0000000183A79A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183A796F0-0x0000000183A79790 0x0000000183A79260-0x0000000183A79300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000183A791C0-0x0000000183A79260 0x0000000183A7A210-0x0000000183A7A2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000183A7A110-0x0000000183A7A1B0 0x0000000183A79EB0-0x0000000183A79F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Position { get => default; set {} } // 0x0000000183A798B0-0x0000000183A79950 0x0000000183A79E10-0x0000000183A79EB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21949
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21950
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2034
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardRsp() {} // 0x0000000183A7A970-0x0000000183A7AA40
	static SalesmanTakeRewardRsp() {} // 0x0000000183A7A8B0-0x0000000183A7A970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardRsp Clone() => default; // 0x0000000183A79D20-0x0000000183A79E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardRsp ShallowCopy() => default; // 0x0000000183A79810-0x0000000183A798B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A790E0-0x0000000183A79130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A7A070-0x0000000183A7A0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A7A0C0-0x0000000183A7A110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A79130-0x0000000183A791C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A79450-0x0000000183A79520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SalesmanTakeRewardRsp other) => default; // 0x0000000183A79300-0x0000000183A79450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A79A40-0x0000000183A79BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A7A590-0x0000000183A7A8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A7A2B0-0x0000000183A7A450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A79520-0x0000000183A796F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SalesmanTakeRewardRsp other) {} // 0x0000000183A78F60-0x0000000183A790E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A78DD0-0x0000000183A78F00
}

