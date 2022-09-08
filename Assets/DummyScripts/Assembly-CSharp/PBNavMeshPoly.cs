/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PBNavMeshPoly : MessageBase, IMessage<PBNavMeshPoly> // TypeDefIndex: 24286
{
	// Fields
	private static readonly MessageParser<PBNavMeshPoly> _parser; // 0x00
	public const int VectsFieldNumber = 1; // Metadata: 0x00B06067
	private static readonly FieldCodec<int> _repeated_vects_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> vects_; // 0x18
	public const int EdgeTypesFieldNumber = 2; // Metadata: 0x00B0606B
	private static readonly FieldCodec<Types.EdgeType> _repeated_edgeTypes_codec; // 0x10
	private readonly RepeatedPrimitiveField<Types.EdgeType> edgeTypes_; // 0x20
	public const int AreaFieldNumber = 3; // Metadata: 0x00B0606F
	private int area_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PBNavMeshPoly> Parser { get => default; } // 0x0000000181B973E0-0x0000000181B97470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B97110-0x0000000181B971A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B96D90-0x0000000181B96E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B964E0-0x0000000181B96540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B977C0-0x0000000181B978B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B975A0-0x0000000181B97600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B971A0-0x0000000181B97290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B97770-0x0000000181B977C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B96F10-0x0000000181B97000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> Vects { get => default; } // 0x0000000181B96540-0x0000000181B965A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<Types.EdgeType> EdgeTypes { get => default; } // 0x0000000181B96EB0-0x0000000181B96F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Area { get => default; set {} } // 0x0000000181B96840-0x0000000181B968E0 0x0000000181B96750-0x0000000181B967F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24287
	{
		// Nested types
		public enum EdgeType // TypeDefIndex: 24288
		{
			Inner = 0,
			TileBound = 1,
			TileBoundUnconnect = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshPoly() {} // 0x0000000181B97C80-0x0000000181B97D30
	static PBNavMeshPoly() {} // 0x0000000181B97B10-0x0000000181B97C80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshPoly Clone() => default; // 0x0000000181B97290-0x0000000181B97380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PBNavMeshPoly ShallowCopy() => default; // 0x0000000181B96E10-0x0000000181B96EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B967F0-0x0000000181B96840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B97500-0x0000000181B97550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B97550-0x0000000181B975A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B968E0-0x0000000181B96A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B96A10-0x0000000181B96AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PBNavMeshPoly other) => default; // 0x0000000181B96AE0-0x0000000181B96C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B97000-0x0000000181B97110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B978B0-0x0000000181B97B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B97600-0x0000000181B97770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B96C20-0x0000000181B96D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PBNavMeshPoly other) {} // 0x0000000181B965A0-0x0000000181B966F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B96300-0x0000000181B964E0
}

