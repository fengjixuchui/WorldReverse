/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerReportRsp : MessageBase, IMessage<PlayerReportRsp> // TypeDefIndex: 25651
{
	// Fields
	private static readonly MessageParser<PlayerReportRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09413
	private int retcode_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B09417
	private uint targetUid_; // 0x1C
	public const int CdTimeFieldNumber = 3; // Metadata: 0x00B0941B
	private uint cdTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerReportRsp> Parser { get => default; } // 0x00000001833F0480-0x00000001833F0510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833F0170-0x00000001833F0200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833EFD90-0x00000001833EFE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833EF4F0-0x00000001833EF550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833F0850-0x00000001833F0940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833F0640-0x00000001833F06A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833F02A0-0x00000001833F0390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833F0800-0x00000001833F0850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833EFEB0-0x00000001833EFFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001833EFCF0-0x00000001833EFD90 0x00000001833EF820-0x00000001833EF8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001833F00D0-0x00000001833F0170 0x00000001833EFC50-0x00000001833EFCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CdTime { get => default; set {} } // 0x00000001833EF6B0-0x00000001833EF750 0x00000001833F0200-0x00000001833F02A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25652
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25653
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4042
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportRsp() {} // 0x00000001833F0C90-0x00000001833F0CF0
	static PlayerReportRsp() {} // 0x00000001833F0BD0-0x00000001833F0C90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportRsp Clone() => default; // 0x00000001833F0390-0x00000001833F0480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportRsp ShallowCopy() => default; // 0x00000001833EFE10-0x00000001833EFEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833EF750-0x00000001833EF7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833F05A0-0x00000001833F05F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833F05F0-0x00000001833F0640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833EF7A0-0x00000001833EF820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833EF8C0-0x00000001833EF990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerReportRsp other) => default; // 0x00000001833EF990-0x00000001833EFAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833EFFA0-0x00000001833F00D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833F0940-0x00000001833F0BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833F06A0-0x00000001833F0800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833EFAD0-0x00000001833EFC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerReportRsp other) {} // 0x00000001833EF550-0x00000001833EF6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833EF3E0-0x00000001833EF4F0
}

