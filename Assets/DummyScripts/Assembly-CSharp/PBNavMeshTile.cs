/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PBNavMeshTile : MessageBase, IMessage<PBNavMeshTile> // TypeDefIndex: 24289
{
	// Fields
	private static readonly MessageParser<PBNavMeshTile> _parser; // 0x00
	public const int VecsFieldNumber = 1; // Metadata: 0x00B0607F
	private static readonly FieldCodec<Vector> _repeated_vecs_codec; // 0x08
	private readonly RepeatedMessageField<Vector> vecs_; // 0x18
	public const int PolysFieldNumber = 2; // Metadata: 0x00B06083
	private static readonly FieldCodec<PBNavMeshPoly> _repeated_polys_codec; // 0x10
	private readonly RepeatedMessageField<PBNavMeshPoly> polys_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PBNavMeshTile> Parser { get => default; } // 0x0000000182646550-0x00000001826465E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001826462E0-0x0000000182646370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182645F80-0x0000000182646000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182645930-0x0000000182645990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182646990-0x0000000182646A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826467B0-0x0000000182646810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182646370-0x0000000182646460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182646940-0x0000000182646990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001826460A0-0x0000000182646190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Vector> Vecs { get => default; } // 0x0000000182646280-0x00000001826462E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PBNavMeshPoly> Polys { get => default; } // 0x00000001826458D0-0x0000000182645930 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshTile() {} // 0x0000000182646DA0-0x0000000182646E50
	static PBNavMeshTile() {} // 0x0000000182646C40-0x0000000182646DA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshTile Clone() => default; // 0x0000000182646460-0x0000000182646550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshTile ShallowCopy() => default; // 0x0000000182646000-0x00000001826460A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182645AF0-0x0000000182645B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182646670-0x0000000182646710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182646710-0x00000001826467B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182645B40-0x0000000182645C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182645C60-0x0000000182645D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PBNavMeshTile other) => default; // 0x0000000182645D30-0x0000000182645E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182646190-0x0000000182646280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182646A80-0x0000000182646C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182646810-0x0000000182646940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182645E60-0x0000000182645F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PBNavMeshTile other) {} // 0x0000000182645990-0x0000000182645AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182645730-0x00000001826458D0
}

