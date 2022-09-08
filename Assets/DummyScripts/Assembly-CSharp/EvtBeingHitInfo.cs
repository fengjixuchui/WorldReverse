/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtBeingHitInfo : MessageBase, IMessage<EvtBeingHitInfo> // TypeDefIndex: 22989
{
	// Fields
	private static readonly MessageParser<EvtBeingHitInfo> _parser; // 0x00
	public const int PeerIdFieldNumber = 1; // Metadata: 0x00B02DFF
	private uint peerId_; // 0x18
	public const int AttackResultFieldNumber = 2; // Metadata: 0x00B02E03
	private AttackResult attackResult_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtBeingHitInfo> Parser { get => default; } // 0x0000000181294F00-0x0000000181294F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181294BF0-0x0000000181294C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001812947C0-0x0000000181294840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181293F50-0x0000000181293FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001812952F0-0x00000001812953E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181295120-0x0000000181295180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181294C80-0x0000000181294D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812952A0-0x00000001812952F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181294980-0x0000000181294A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PeerId { get => default; set {} } // 0x00000001812948E0-0x0000000181294980 0x0000000181293FB0-0x0000000181294050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AttackResult AttackResult { get => default; set {} } // 0x0000000181294250-0x00000001812942F0 0x0000000181294E60-0x0000000181294F00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitInfo() {} // 0x0000000181295680-0x00000001812956E0
	static EvtBeingHitInfo() {} // 0x00000001812955C0-0x0000000181295680

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitInfo Clone() => default; // 0x0000000181294D70-0x0000000181294E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitInfo ShallowCopy() => default; // 0x0000000181294840-0x00000001812948E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001812941D0-0x0000000181294250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181295020-0x00000001812950A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812950A0-0x0000000181295120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812942F0-0x0000000181294420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181294420-0x00000001812944F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtBeingHitInfo other) => default; // 0x00000001812944F0-0x0000000181294620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181294A70-0x0000000181294BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001812953E0-0x00000001812955C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181295180-0x00000001812952A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181294620-0x00000001812947C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtBeingHitInfo other) {} // 0x0000000181294050-0x00000001812941D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181293E10-0x0000000181293F50
}

