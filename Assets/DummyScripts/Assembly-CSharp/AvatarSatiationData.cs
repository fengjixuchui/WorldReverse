/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSatiationData : MessageBase, IMessage<AvatarSatiationData> // TypeDefIndex: 22502
{
	// Fields
	private static readonly MessageParser<AvatarSatiationData> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B01BA3
	private ulong avatarGuid_; // 0x18
	public const int FinishTimeFieldNumber = 2; // Metadata: 0x00B01BA7
	private float finishTime_; // 0x20
	public const int PenaltyFinishTimeFieldNumber = 3; // Metadata: 0x00B01BAB
	private float penaltyFinishTime_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSatiationData> Parser { get => default; } // 0x0000000184632160-0x00000001846321F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184631DB0-0x0000000184631E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184631A40-0x0000000184631AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184631320-0x0000000184631380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184632680-0x0000000184632770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184632460-0x00000001846324C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184631EE0-0x0000000184631FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184632630-0x0000000184632680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184631B60-0x0000000184631C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184631E40-0x0000000184631EE0 0x00000001846314F0-0x0000000184631590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FinishTime { get => default; set {} } // 0x00000001846320C0-0x0000000184632160 0x0000000184632280-0x0000000184632320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float PenaltyFinishTime { get => default; set {} } // 0x0000000184632370-0x0000000184632410 0x0000000184631660-0x0000000184631700

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationData() {} // 0x0000000184632AC0-0x0000000184632B20
	static AvatarSatiationData() {} // 0x0000000184632A00-0x0000000184632AC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationData Clone() => default; // 0x0000000184631FD0-0x00000001846320C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSatiationData ShallowCopy() => default; // 0x0000000184631AC0-0x0000000184631B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184631590-0x00000001846315E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184632320-0x0000000184632370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184632410-0x0000000184632460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846315E0-0x0000000184631660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184631700-0x00000001846317D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSatiationData other) => default; // 0x00000001846317D0-0x0000000184631920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184631C50-0x0000000184631DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184632770-0x0000000184632A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846324C0-0x0000000184632630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184631920-0x0000000184631A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSatiationData other) {} // 0x0000000184631380-0x00000001846314F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184631200-0x0000000184631320
}

