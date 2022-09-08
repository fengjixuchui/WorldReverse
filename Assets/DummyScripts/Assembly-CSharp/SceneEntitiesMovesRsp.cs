/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntitiesMovesRsp : MessageBase, IMessage<SceneEntitiesMovesRsp> // TypeDefIndex: 25201
{
	// Fields
	private static readonly MessageParser<SceneEntitiesMovesRsp> _parser; // 0x00
	public const int EntityMoveFailInfoListFieldNumber = 1; // Metadata: 0x00B08337
	private static readonly FieldCodec<EntityMoveFailInfo> _repeated_entityMoveFailInfoList_codec; // 0x08
	private readonly RepeatedMessageField<EntityMoveFailInfo> entityMoveFailInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntitiesMovesRsp> Parser { get => default; } // 0x0000000183FCB2D0-0x0000000183FCB360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FCB060-0x0000000183FCB0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FCAD90-0x0000000183FCAE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FCA7B0-0x0000000183FCA810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FCB6C0-0x0000000183FCB7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FCB510-0x0000000183FCB570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FCB0F0-0x0000000183FCB1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FCB670-0x0000000183FCB6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FCAEB0-0x0000000183FCAFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityMoveFailInfo> EntityMoveFailInfoList { get => default; } // 0x0000000183FCAD30-0x0000000183FCAD90 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25202
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25203
		{
			None = 0,
			EnetIsReliable = 0,
			EnetChannelId = 1,
			CmdId = 300
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesRsp() {} // 0x0000000183FCBA10-0x0000000183FCBAA0
	static SceneEntitiesMovesRsp() {} // 0x0000000183FCB900-0x0000000183FCBA10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesRsp Clone() => default; // 0x0000000183FCB1E0-0x0000000183FCB2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesRsp ShallowCopy() => default; // 0x0000000183FCAE10-0x0000000183FCAEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FCA940-0x0000000183FCA990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCB3F0-0x0000000183FCB480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCB480-0x0000000183FCB510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FCA990-0x0000000183FCAA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FCAB70-0x0000000183FCAC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntitiesMovesRsp other) => default; // 0x0000000183FCAA60-0x0000000183FCAB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FCAFA0-0x0000000183FCB060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FCB7B0-0x0000000183FCB900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FCB570-0x0000000183FCB670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FCAC40-0x0000000183FCAD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntitiesMovesRsp other) {} // 0x0000000183FCA810-0x0000000183FCA940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FCA680-0x0000000183FCA7B0
}

