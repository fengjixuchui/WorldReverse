/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCombatSteerMotionInfo : MessageBase, IMessage<EvtCombatSteerMotionInfo> // TypeDefIndex: 23036
{
	// Fields
	private static readonly MessageParser<EvtCombatSteerMotionInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0304B
	private uint entityId_; // 0x18
	public const int VelocityFieldNumber = 2; // Metadata: 0x00B0304F
	private Vector velocity_; // 0x20
	public const int FaceDirFieldNumber = 3; // Metadata: 0x00B03053
	private Vector faceDir_; // 0x28
	public const int PosFieldNumber = 4; // Metadata: 0x00B03057
	private Vector pos_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtCombatSteerMotionInfo> Parser { get => default; } // 0x000000018356F1E0-0x000000018356F270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018356ED90-0x000000018356EE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018356E8B0-0x000000018356E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018356DC80-0x000000018356DCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018356F860-0x000000018356F950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018356F580-0x000000018356F5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018356EF60-0x000000018356F050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018356F810-0x000000018356F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018356E9D0-0x000000018356EAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018356F4E0-0x000000018356F580 0x000000018356F950-0x000000018356F9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Velocity { get => default; set {} } // 0x000000018356DF50-0x000000018356DFF0 0x000000018356EEC0-0x000000018356EF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FaceDir { get => default; set {} } // 0x000000018356F140-0x000000018356F1E0 0x000000018356EE20-0x000000018356EEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x000000018356F440-0x000000018356F4E0 0x000000018356F770-0x000000018356F810

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatSteerMotionInfo() {} // 0x000000018356FD80-0x000000018356FDE0
	static EvtCombatSteerMotionInfo() {} // 0x000000018356FCC0-0x000000018356FD80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatSteerMotionInfo Clone() => default; // 0x000000018356F050-0x000000018356F140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatSteerMotionInfo ShallowCopy() => default; // 0x000000018356E930-0x000000018356E9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018356DFF0-0x000000018356E0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018356F300-0x000000018356F3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018356F3A0-0x000000018356F440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018356E0A0-0x000000018356E350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018356E350-0x000000018356E420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtCombatSteerMotionInfo other) => default; // 0x000000018356E420-0x000000018356E5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018356EAC0-0x000000018356ED90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018356F9F0-0x000000018356FCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018356F5E0-0x000000018356F770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018356E5B0-0x000000018356E8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtCombatSteerMotionInfo other) {} // 0x000000018356DCE0-0x000000018356DF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018356DAA0-0x000000018356DC80
}

