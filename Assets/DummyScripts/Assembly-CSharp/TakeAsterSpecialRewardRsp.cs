/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeAsterSpecialRewardRsp : MessageBase, IMessage<TakeAsterSpecialRewardRsp> // TypeDefIndex: 22025
{
	// Fields
	private static readonly MessageParser<TakeAsterSpecialRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00997
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B0099B
	private uint scheduleId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeAsterSpecialRewardRsp> Parser { get => default; } // 0x00000001814FDA10-0x00000001814FDAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814FD7A0-0x00000001814FD830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001814FD490-0x00000001814FD510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001814FCD40-0x00000001814FCDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814FDE40-0x00000001814FDF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814FDBD0-0x00000001814FDC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814FD830-0x00000001814FD920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001814FDDF0-0x00000001814FDE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001814FD5B0-0x00000001814FD6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001814FD3F0-0x00000001814FD490 0x00000001814FD030-0x00000001814FD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001814FCF90-0x00000001814FD030 0x00000001814FDC30-0x00000001814FDCD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22026
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22027
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2068
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardRsp() {} // 0x00000001814FE1F0-0x00000001814FE250
	static TakeAsterSpecialRewardRsp() {} // 0x00000001814FE130-0x00000001814FE1F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardRsp Clone() => default; // 0x00000001814FD920-0x00000001814FDA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardRsp ShallowCopy() => default; // 0x00000001814FD510-0x00000001814FD5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001814FCED0-0x00000001814FCF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814FDB30-0x00000001814FDB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814FDB80-0x00000001814FDBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001814FCF20-0x00000001814FCF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814FD0D0-0x00000001814FD1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeAsterSpecialRewardRsp other) => default; // 0x00000001814FD1A0-0x00000001814FD2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001814FD6A0-0x00000001814FD7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814FDF30-0x00000001814FE130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001814FDCD0-0x00000001814FDDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814FD2C0-0x00000001814FD3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeAsterSpecialRewardRsp other) {} // 0x00000001814FCDA0-0x00000001814FCED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814FCC40-0x00000001814FCD40
}

