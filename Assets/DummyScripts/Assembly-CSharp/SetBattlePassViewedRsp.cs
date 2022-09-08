/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetBattlePassViewedRsp : MessageBase, IMessage<SetBattlePassViewedRsp> // TypeDefIndex: 22579
{
	// Fields
	private static readonly MessageParser<SetBattlePassViewedRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01E93
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B01E97
	private uint scheduleId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetBattlePassViewedRsp> Parser { get => default; } // 0x0000000181CB3810-0x0000000181CB38A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CB35A0-0x0000000181CB3630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CB3290-0x0000000181CB3310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CB2B40-0x0000000181CB2BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CB3C40-0x0000000181CB3D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CB39D0-0x0000000181CB3A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CB3630-0x0000000181CB3720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CB3BF0-0x0000000181CB3C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CB33B0-0x0000000181CB34A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181CB31F0-0x0000000181CB3290 0x0000000181CB2E30-0x0000000181CB2ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000181CB2D90-0x0000000181CB2E30 0x0000000181CB3A30-0x0000000181CB3AD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22580
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22581
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2614
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetBattlePassViewedRsp() {} // 0x0000000181CB3FF0-0x0000000181CB4280
	static SetBattlePassViewedRsp() {} // 0x0000000181CB3F30-0x0000000181CB3FF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetBattlePassViewedRsp Clone() => default; // 0x0000000181CB3720-0x0000000181CB3810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetBattlePassViewedRsp ShallowCopy() => default; // 0x0000000181CB3310-0x0000000181CB33B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CB2CD0-0x0000000181CB2D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CB3930-0x0000000181CB3980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CB3980-0x0000000181CB39D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CB2D20-0x0000000181CB2D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CB2FF0-0x0000000181CB30C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetBattlePassViewedRsp other) => default; // 0x0000000181CB2ED0-0x0000000181CB2FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CB34A0-0x0000000181CB35A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CB3D30-0x0000000181CB3F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CB3AD0-0x0000000181CB3BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CB30C0-0x0000000181CB31F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetBattlePassViewedRsp other) {} // 0x0000000181CB2BA0-0x0000000181CB2CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CB2A40-0x0000000181CB2B40
}

