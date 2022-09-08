/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtHittingOtherInfo : MessageBase, IMessage<EvtHittingOtherInfo> // TypeDefIndex: 22990
{
	// Fields
	private static readonly MessageParser<EvtHittingOtherInfo> _parser; // 0x00
	public const int PeerIdFieldNumber = 1; // Metadata: 0x00B02E07
	private uint peerId_; // 0x18
	public const int AttackResultFieldNumber = 2; // Metadata: 0x00B02E0B
	private AttackResult attackResult_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtHittingOtherInfo> Parser { get => default; } // 0x0000000184ECFC20-0x0000000184ECFCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ECF910-0x0000000184ECF9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ECF4E0-0x0000000184ECF560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ECEC70-0x0000000184ECECD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184ED0010-0x0000000184ED0100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184ECFE40-0x0000000184ECFEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ECF9A0-0x0000000184ECFA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184ECFFC0-0x0000000184ED0010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ECF6A0-0x0000000184ECF790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PeerId { get => default; set {} } // 0x0000000184ECF600-0x0000000184ECF6A0 0x0000000184ECECD0-0x0000000184ECED70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AttackResult AttackResult { get => default; set {} } // 0x0000000184ECEF70-0x0000000184ECF010 0x0000000184ECFB80-0x0000000184ECFC20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtHittingOtherInfo() {} // 0x0000000184ED03A0-0x0000000184ED0400
	static EvtHittingOtherInfo() {} // 0x0000000184ED02E0-0x0000000184ED03A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtHittingOtherInfo Clone() => default; // 0x0000000184ECFA90-0x0000000184ECFB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtHittingOtherInfo ShallowCopy() => default; // 0x0000000184ECF560-0x0000000184ECF600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ECEEF0-0x0000000184ECEF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ECFD40-0x0000000184ECFDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ECFDC0-0x0000000184ECFE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ECF010-0x0000000184ECF140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ECF270-0x0000000184ECF340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtHittingOtherInfo other) => default; // 0x0000000184ECF140-0x0000000184ECF270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ECF790-0x0000000184ECF910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184ED0100-0x0000000184ED02E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184ECFEA0-0x0000000184ECFFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ECF340-0x0000000184ECF4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtHittingOtherInfo other) {} // 0x0000000184ECED70-0x0000000184ECEEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ECEB30-0x0000000184ECEC70
}

