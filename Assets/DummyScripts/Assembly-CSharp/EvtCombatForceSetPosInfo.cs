/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCombatForceSetPosInfo : MessageBase, IMessage<EvtCombatForceSetPosInfo> // TypeDefIndex: 23037
{
	// Fields
	private static readonly MessageParser<EvtCombatForceSetPosInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0305B
	private uint entityId_; // 0x18
	public const int ColliderEntityIdFieldNumber = 2; // Metadata: 0x00B0305F
	private uint colliderEntityId_; // 0x1C
	public const int IceIdFieldNumber = 3; // Metadata: 0x00B03063
	private uint iceId_; // 0x20
	public const int TargetPosFieldNumber = 4; // Metadata: 0x00B03067
	private Vector targetPos_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtCombatForceSetPosInfo> Parser { get => default; } // 0x0000000185071770-0x0000000185071800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850713C0-0x0000000185071450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185070FD0-0x0000000185071050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185070580-0x00000001850705E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185071D20-0x0000000185071E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185071AD0-0x0000000185071B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185071590-0x0000000185071680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185071CD0-0x0000000185071D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850710F0-0x00000001850711E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000185071A30-0x0000000185071AD0 0x0000000185071E10-0x0000000185071EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ColliderEntityId { get => default; set {} } // 0x0000000185070680-0x0000000185070720 0x0000000185071990-0x0000000185071A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint IceId { get => default; set {} } // 0x00000001850705E0-0x0000000185070680 0x0000000185071450-0x00000001850714F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetPos { get => default; set {} } // 0x00000001850714F0-0x0000000185071590 0x0000000185070F30-0x0000000185070FD0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatForceSetPosInfo() {} // 0x0000000185072270-0x00000001850722D0
	static EvtCombatForceSetPosInfo() {} // 0x00000001850721B0-0x0000000185072270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatForceSetPosInfo Clone() => default; // 0x0000000185071680-0x0000000185071770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCombatForceSetPosInfo ShallowCopy() => default; // 0x0000000185071050-0x00000001850710F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850708F0-0x0000000185070970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185071890-0x0000000185071910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185071910-0x0000000185071990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185070970-0x0000000185070AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185070AC0-0x0000000185070B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtCombatForceSetPosInfo other) => default; // 0x0000000185070B90-0x0000000185070D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850711E0-0x00000001850713C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185071EB0-0x00000001850721B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185071B30-0x0000000185071CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185070D00-0x0000000185070F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtCombatForceSetPosInfo other) {} // 0x0000000185070720-0x00000001850708F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185070400-0x0000000185070580
}

