/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HitCollision : MessageBase, IMessage<HitCollision> // TypeDefIndex: 22985
{
	// Fields
	private static readonly MessageParser<HitCollision> _parser; // 0x00
	public const int HitColliderTypeFieldNumber = 1; // Metadata: 0x00B02D43
	private HitColliderType hitColliderType_; // 0x18
	public const int HitBoxIndexFieldNumber = 2; // Metadata: 0x00B02D47
	private int hitBoxIndex_; // 0x1C
	public const int HitPointFieldNumber = 3; // Metadata: 0x00B02D4B
	private Vector hitPoint_; // 0x20
	public const int HitDirFieldNumber = 4; // Metadata: 0x00B02D4F
	private Vector hitDir_; // 0x28
	public const int AttackeeHitForceAngleFieldNumber = 5; // Metadata: 0x00B02D53
	private float attackeeHitForceAngle_; // 0x30
	public const int AttackeeHitEntityAngleFieldNumber = 6; // Metadata: 0x00B02D57
	private float attackeeHitEntityAngle_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HitCollision> Parser { get => default; } // 0x000000018450F960-0x000000018450F9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018450F510-0x000000018450F5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018450EFE0-0x000000018450F060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018450E270-0x000000018450E2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018450FFB0-0x00000001845100A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018450FCE0-0x000000018450FD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018450F6E0-0x000000018450F7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018450FF60-0x000000018450FFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018450F100-0x000000018450F1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitColliderType HitColliderType { get => default; set {} } // 0x000000018450F8C0-0x000000018450F960 0x00000001845101E0-0x0000000184510280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int HitBoxIndex { get => default; set {} } // 0x000000018450EF40-0x000000018450EFE0 0x00000001845100A0-0x0000000184510140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HitPoint { get => default; set {} } // 0x000000018450F640-0x000000018450F6E0 0x0000000184510140-0x00000001845101E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HitDir { get => default; set {} } // 0x000000018450E890-0x000000018450E930 0x000000018450E930-0x000000018450E9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float AttackeeHitForceAngle { get => default; set {} } // 0x000000018450F5A0-0x000000018450F640 0x000000018450FC40-0x000000018450FCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float AttackeeHitEntityAngle { get => default; set {} } // 0x000000018450E5E0-0x000000018450E680 0x000000018450F9F0-0x000000018450FA90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitCollision() {} // 0x0000000184510740-0x00000001845107B0
	static HitCollision() {} // 0x0000000184510680-0x0000000184510740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitCollision Clone() => default; // 0x000000018450F7D0-0x000000018450F8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitCollision ShallowCopy() => default; // 0x000000018450F060-0x000000018450F100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018450E550-0x000000018450E5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018450FB20-0x000000018450FBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018450FBB0-0x000000018450FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018450E680-0x000000018450E890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018450E9D0-0x000000018450EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HitCollision other) => default; // 0x000000018450EAA0-0x000000018450EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018450F1F0-0x000000018450F510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184510280-0x0000000184510680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018450FD40-0x000000018450FF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018450EC70-0x000000018450EF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HitCollision other) {} // 0x000000018450E2D0-0x000000018450E550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018450E090-0x000000018450E270
}

