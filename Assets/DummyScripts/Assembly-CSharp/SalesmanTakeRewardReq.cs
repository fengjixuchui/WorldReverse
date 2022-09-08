/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SalesmanTakeRewardReq : MessageBase, IMessage<SalesmanTakeRewardReq> // TypeDefIndex: 21945
{
	// Fields
	private static readonly MessageParser<SalesmanTakeRewardReq> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B006A7
	private uint scheduleId_; // 0x18
	public const int PositionFieldNumber = 2; // Metadata: 0x00B006AB
	private uint position_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SalesmanTakeRewardReq> Parser { get => default; } // 0x0000000181E0A650-0x0000000181E0A6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E0A340-0x0000000181E0A3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E09F90-0x0000000181E0A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E09980-0x0000000181E099E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E0AA80-0x0000000181E0AB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E0A810-0x0000000181E0A870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E0A3D0-0x0000000181E0A4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E0AA30-0x0000000181E0AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E0A150-0x0000000181E0A240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000181E09BD0-0x0000000181E09C70 0x0000000181E0A870-0x0000000181E0A910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Position { get => default; set {} } // 0x0000000181E0A0B0-0x0000000181E0A150 0x0000000181E0A5B0-0x0000000181E0A650

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21946
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21947
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2033
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardReq() {} // 0x0000000181E0AE30-0x0000000181E0AE90
	static SalesmanTakeRewardReq() {} // 0x0000000181E0AD70-0x0000000181E0AE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardReq Clone() => default; // 0x0000000181E0A4C0-0x0000000181E0A5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeRewardReq ShallowCopy() => default; // 0x0000000181E0A010-0x0000000181E0A0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E09B10-0x0000000181E09B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E0A770-0x0000000181E0A7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E0A7C0-0x0000000181E0A810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E09B60-0x0000000181E09BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E09C70-0x0000000181E09D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SalesmanTakeRewardReq other) => default; // 0x0000000181E09D40-0x0000000181E09E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E0A240-0x0000000181E0A340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E0AB70-0x0000000181E0AD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E0A910-0x0000000181E0AA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E09E60-0x0000000181E09F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SalesmanTakeRewardReq other) {} // 0x0000000181E099E0-0x0000000181E09B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E09880-0x0000000181E09980
}

