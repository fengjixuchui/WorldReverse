/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtBulletHitNotify : MessageBase, IMessage<EvtBulletHitNotify> // TypeDefIndex: 23042
{
	// Fields
	private static readonly MessageParser<EvtBulletHitNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B0309B
	private ForwardType forwardType_; // 0x18
	public const int ForwardPeerFieldNumber = 2; // Metadata: 0x00B0309F
	private uint forwardPeer_; // 0x1C
	public const int EntityIdFieldNumber = 3; // Metadata: 0x00B030A3
	private uint entityId_; // 0x20
	public const int HitEntityIdFieldNumber = 4; // Metadata: 0x00B030A7
	private uint hitEntityId_; // 0x24
	public const int HitColliderTypeFieldNumber = 5; // Metadata: 0x00B030AB
	private HitColliderType hitColliderType_; // 0x28
	public const int HitBoxIndexFieldNumber = 6; // Metadata: 0x00B030AF
	private int hitBoxIndex_; // 0x2C
	public const int HitPointFieldNumber = 7; // Metadata: 0x00B030B3
	private Vector hitPoint_; // 0x30
	public const int HitNormalFieldNumber = 8; // Metadata: 0x00B030B7
	private Vector hitNormal_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtBulletHitNotify> Parser { get => default; } // 0x000000018408EE50-0x000000018408EEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018408EA00-0x000000018408EA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018408E340-0x000000018408E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018408D3C0-0x000000018408D420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018408F470-0x000000018408F560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018408F130-0x000000018408F190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018408EBD0-0x000000018408ECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018408F420-0x000000018408F470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018408E460-0x000000018408E550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x000000018408E2A0-0x000000018408E340 0x000000018408D810-0x000000018408D8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForwardPeer { get => default; set {} } // 0x000000018408E8C0-0x000000018408E960 0x000000018408E960-0x000000018408EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018408F090-0x000000018408F130 0x000000018408F740-0x000000018408F7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HitEntityId { get => default; set {} } // 0x000000018408D420-0x000000018408D4C0 0x000000018408EA90-0x000000018408EB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitColliderType HitColliderType { get => default; set {} } // 0x000000018408EDB0-0x000000018408EE50 0x000000018408F6A0-0x000000018408F740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int HitBoxIndex { get => default; set {} } // 0x000000018408E200-0x000000018408E2A0 0x000000018408F560-0x000000018408F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HitPoint { get => default; set {} } // 0x000000018408EB30-0x000000018408EBD0 0x000000018408F600-0x000000018408F6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HitNormal { get => default; set {} } // 0x000000018408D320-0x000000018408D3C0 0x000000018408D8B0-0x000000018408D950

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23043
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23044
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 313
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletHitNotify() {} // 0x000000018408FDB0-0x000000018408FE20
	static EvtBulletHitNotify() {} // 0x000000018408FCF0-0x000000018408FDB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletHitNotify Clone() => default; // 0x000000018408ECC0-0x000000018408EDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletHitNotify ShallowCopy() => default; // 0x000000018408E3C0-0x000000018408E460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018408D780-0x000000018408D810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018408EF70-0x000000018408F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018408F000-0x000000018408F090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018408D950-0x000000018408DB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018408DB80-0x000000018408DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtBulletHitNotify other) => default; // 0x000000018408DC50-0x000000018408DE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018408E550-0x000000018408E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018408F7E0-0x000000018408FCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018408F190-0x000000018408F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018408DE50-0x000000018408E200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtBulletHitNotify other) {} // 0x000000018408D4C0-0x000000018408D780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018408D100-0x000000018408D320
}

