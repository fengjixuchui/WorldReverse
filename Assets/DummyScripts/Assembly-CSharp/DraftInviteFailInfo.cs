/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DraftInviteFailInfo : MessageBase, IMessage<DraftInviteFailInfo> // TypeDefIndex: 22766
{
	// Fields
	private static readonly MessageParser<DraftInviteFailInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0251F
	private uint uid_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B02523
	private DraftInviteFailReason reason_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DraftInviteFailInfo> Parser { get => default; } // 0x0000000183FF5BF0-0x0000000183FF5C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FF5840-0x0000000183FF58D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FF54E0-0x0000000183FF5560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FF4E30-0x0000000183FF4E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FF5F80-0x0000000183FF6070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FF5DB0-0x0000000183FF5E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FF5970-0x0000000183FF5A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FF5F30-0x0000000183FF5F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FF5600-0x0000000183FF56F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000183FF5440-0x0000000183FF54E0 0x0000000183FF58D0-0x0000000183FF5970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteFailReason Reason { get => default; set {} } // 0x0000000183FF5B50-0x0000000183FF5BF0 0x0000000183FF5010-0x0000000183FF50B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteFailInfo() {} // 0x0000000183FF6330-0x0000000183FF63A0
	static DraftInviteFailInfo() {} // 0x0000000183FF6270-0x0000000183FF6330

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteFailInfo Clone() => default; // 0x0000000183FF5A60-0x0000000183FF5B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DraftInviteFailInfo ShallowCopy() => default; // 0x0000000183FF5560-0x0000000183FF5600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FF4FC0-0x0000000183FF5010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF5D10-0x0000000183FF5D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF5D60-0x0000000183FF5DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FF50B0-0x0000000183FF5120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FF5120-0x0000000183FF51F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DraftInviteFailInfo other) => default; // 0x0000000183FF51F0-0x0000000183FF5310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FF56F0-0x0000000183FF5840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FF6070-0x0000000183FF6270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FF5E10-0x0000000183FF5F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FF5310-0x0000000183FF5440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DraftInviteFailInfo other) {} // 0x0000000183FF4E90-0x0000000183FF4FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FF4D40-0x0000000183FF4E30
}

