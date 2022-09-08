/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSetAttackTargetNotify : MessageBase, IMessage<EvtSetAttackTargetNotify> // TypeDefIndex: 23023
{
	// Fields
	private static readonly MessageParser<EvtSetAttackTargetNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02F83
	private ForwardType forwardType_; // 0x18
	public const int EvtSetAttackTargetInfoFieldNumber = 2; // Metadata: 0x00B02F87
	private EvtSetAttackTargetInfo evtSetAttackTargetInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtSetAttackTargetNotify> Parser { get => default; } // 0x00000001849EF0B0-0x00000001849EF140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849EEE40-0x00000001849EEED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849EEA70-0x00000001849EEAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849EE160-0x00000001849EE1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849EF540-0x00000001849EF630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849EF2D0-0x00000001849EF330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849EEED0-0x00000001849EEFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849EF4F0-0x00000001849EF540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849EEB90-0x00000001849EEC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x00000001849EE9D0-0x00000001849EEA70 0x00000001849EE3C0-0x00000001849EE460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetInfo EvtSetAttackTargetInfo { get => default; set {} } // 0x00000001849EE590-0x00000001849EE630 0x00000001849EF330-0x00000001849EF3D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23024
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23025
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 310
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetNotify() {} // 0x00000001849EF8D0-0x00000001849EF940
	static EvtSetAttackTargetNotify() {} // 0x00000001849EF810-0x00000001849EF8D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetNotify Clone() => default; // 0x00000001849EEFC0-0x00000001849EF0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetNotify ShallowCopy() => default; // 0x00000001849EEAF0-0x00000001849EEB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849EE340-0x00000001849EE3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849EF1D0-0x00000001849EF250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849EF250-0x00000001849EF2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849EE460-0x00000001849EE590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849EE760-0x00000001849EE830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtSetAttackTargetNotify other) => default; // 0x00000001849EE630-0x00000001849EE760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849EEC80-0x00000001849EEE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849EF630-0x00000001849EF810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849EF3D0-0x00000001849EF4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849EE830-0x00000001849EE9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtSetAttackTargetNotify other) {} // 0x00000001849EE1C0-0x00000001849EE340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849EE030-0x00000001849EE160
}

