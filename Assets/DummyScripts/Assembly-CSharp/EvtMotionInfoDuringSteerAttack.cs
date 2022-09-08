/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtMotionInfoDuringSteerAttack : MessageBase, IMessage<EvtMotionInfoDuringSteerAttack> // TypeDefIndex: 23035
{
	// Fields
	private static readonly MessageParser<EvtMotionInfoDuringSteerAttack> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0303B
	private uint entityId_; // 0x18
	public const int VelocityFieldNumber = 2; // Metadata: 0x00B0303F
	private Vector velocity_; // 0x20
	public const int FaceDirFieldNumber = 3; // Metadata: 0x00B03043
	private Vector faceDir_; // 0x28
	public const int PosFieldNumber = 4; // Metadata: 0x00B03047
	private Vector pos_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtMotionInfoDuringSteerAttack> Parser { get => default; } // 0x00000001849775F0-0x0000000184977680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849771A0-0x0000000184977230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184976CC0-0x0000000184976D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184976090-0x00000001849760F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184977C70-0x0000000184977D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184977990-0x00000001849779F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184977370-0x0000000184977460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184977C20-0x0000000184977C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184976DE0-0x0000000184976ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001849778F0-0x0000000184977990 0x0000000184977D60-0x0000000184977E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Velocity { get => default; set {} } // 0x0000000184976360-0x0000000184976400 0x00000001849772D0-0x0000000184977370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FaceDir { get => default; set {} } // 0x0000000184977550-0x00000001849775F0 0x0000000184977230-0x00000001849772D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184977850-0x00000001849778F0 0x0000000184977B80-0x0000000184977C20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMotionInfoDuringSteerAttack() {} // 0x0000000184978190-0x00000001849781F0
	static EvtMotionInfoDuringSteerAttack() {} // 0x00000001849780D0-0x0000000184978190

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMotionInfoDuringSteerAttack Clone() => default; // 0x0000000184977460-0x0000000184977550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMotionInfoDuringSteerAttack ShallowCopy() => default; // 0x0000000184976D40-0x0000000184976DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184976400-0x00000001849764B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184977710-0x00000001849777B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849777B0-0x0000000184977850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849764B0-0x0000000184976760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849768F0-0x00000001849769C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtMotionInfoDuringSteerAttack other) => default; // 0x0000000184976760-0x00000001849768F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184976ED0-0x00000001849771A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184977E00-0x00000001849780D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849779F0-0x0000000184977B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849769C0-0x0000000184976CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtMotionInfoDuringSteerAttack other) {} // 0x00000001849760F0-0x0000000184976360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184975EB0-0x0000000184976090
}

