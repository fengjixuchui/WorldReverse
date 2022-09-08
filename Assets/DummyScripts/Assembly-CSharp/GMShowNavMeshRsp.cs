/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GMShowNavMeshRsp : MessageBase, IMessage<GMShowNavMeshRsp> // TypeDefIndex: 24290
{
	// Fields
	private static readonly MessageParser<GMShowNavMeshRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06087
	private int retcode_; // 0x18
	public const int TilesFieldNumber = 2; // Metadata: 0x00B0608B
	private static readonly FieldCodec<PBNavMeshTile> _repeated_tiles_codec; // 0x08
	private readonly RepeatedMessageField<PBNavMeshTile> tiles_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GMShowNavMeshRsp> Parser { get => default; } // 0x00000001839C9860-0x00000001839C98F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839C95F0-0x00000001839C9680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001839C92E0-0x00000001839C9360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001839C8B10-0x00000001839C8B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839C9C90-0x00000001839C9D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839C9AA0-0x00000001839C9B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001839C9680-0x00000001839C9770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839C9C40-0x00000001839C9C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839C9400-0x00000001839C94F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001839C9240-0x00000001839C92E0 0x00000001839C8E60-0x00000001839C8F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PBNavMeshTile> Tiles { get => default; } // 0x00000001839C8CD0-0x00000001839C8D30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24291
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24292
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2354
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshRsp() {} // 0x00000001839CA070-0x00000001839CA100
	static GMShowNavMeshRsp() {} // 0x00000001839C9F60-0x00000001839CA070

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshRsp Clone() => default; // 0x00000001839C9770-0x00000001839C9860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshRsp ShallowCopy() => default; // 0x00000001839C9360-0x00000001839C9400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839C8D30-0x00000001839C8D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C9980-0x00000001839C9A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C9A10-0x00000001839C9AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839C8D80-0x00000001839C8E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839C9030-0x00000001839C9100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GMShowNavMeshRsp other) => default; // 0x00000001839C8F00-0x00000001839C9030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839C94F0-0x00000001839C95F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839C9D80-0x00000001839C9F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001839C9B00-0x00000001839C9C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839C9100-0x00000001839C9240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GMShowNavMeshRsp other) {} // 0x00000001839C8B70-0x00000001839C8CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001839C89B0-0x00000001839C8B10
}

