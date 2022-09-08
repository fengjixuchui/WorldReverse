/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayOwnerStartInviteRsp : MessageBase, IMessage<MpPlayOwnerStartInviteRsp> // TypeDefIndex: 24075
{
	// Fields
	private static readonly MessageParser<MpPlayOwnerStartInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05803
	private int retcode_; // 0x18
	public const int MpPlayIdFieldNumber = 2; // Metadata: 0x00B05807
	private uint mpPlayId_; // 0x1C
	public const int IsSkipMatchFieldNumber = 3; // Metadata: 0x00B0580B
	private bool isSkipMatch_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayOwnerStartInviteRsp> Parser { get => default; } // 0x0000000182B6B610-0x0000000182B6B6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B6B300-0x0000000182B6B390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B6AF20-0x0000000182B6AFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B6A750-0x0000000182B6A7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B6BA80-0x0000000182B6BB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B6B7D0-0x0000000182B6B830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B6B430-0x0000000182B6B520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B6BA30-0x0000000182B6BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B6B040-0x0000000182B6B130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182B6AE80-0x0000000182B6AF20 0x0000000182B6AA80-0x0000000182B6AB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000182B6B260-0x0000000182B6B300 0x0000000182B6A9E0-0x0000000182B6AA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipMatch { get => default; set {} } // 0x0000000182B6B990-0x0000000182B6BA30 0x0000000182B6B390-0x0000000182B6B430

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24076
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24077
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1818
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerStartInviteRsp() {} // 0x0000000182B6BEC0-0x0000000182B6BF60
	static MpPlayOwnerStartInviteRsp() {} // 0x0000000182B6BE00-0x0000000182B6BEC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerStartInviteRsp Clone() => default; // 0x0000000182B6B520-0x0000000182B6B610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerStartInviteRsp ShallowCopy() => default; // 0x0000000182B6AFA0-0x0000000182B6B040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B6A910-0x0000000182B6A960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B6B730-0x0000000182B6B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B6B780-0x0000000182B6B7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B6A960-0x0000000182B6A9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B6AC60-0x0000000182B6AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayOwnerStartInviteRsp other) => default; // 0x0000000182B6AB20-0x0000000182B6AC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B6B130-0x0000000182B6B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B6BB70-0x0000000182B6BE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B6B830-0x0000000182B6B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B6AD30-0x0000000182B6AE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayOwnerStartInviteRsp other) {} // 0x0000000182B6A7B0-0x0000000182B6A910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B6A640-0x0000000182B6A750
}

