/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DelTeamEntityNotify : MessageBase, IMessage<DelTeamEntityNotify> // TypeDefIndex: 23123
{
	// Fields
	private static readonly MessageParser<DelTeamEntityNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B033DF
	private uint sceneId_; // 0x18
	public const int DelEntityIdListFieldNumber = 2; // Metadata: 0x00B033E3
	private static readonly FieldCodec<uint> _repeated_delEntityIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> delEntityIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DelTeamEntityNotify> Parser { get => default; } // 0x00000001819FF0B0-0x00000001819FF140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819FEE40-0x00000001819FEED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819FEB30-0x00000001819FEBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819FE3B0-0x00000001819FE410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819FF460-0x00000001819FF550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819FF270-0x00000001819FF2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819FEED0-0x00000001819FEFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819FF410-0x00000001819FF460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819FEC50-0x00000001819FED40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001819FE6B0-0x00000001819FE750 0x00000001819FEA90-0x00000001819FEB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelEntityIdList { get => default; } // 0x00000001819FE410-0x00000001819FE470 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23124
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23125
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 349
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelTeamEntityNotify() {} // 0x00000001819FF810-0x00000001819FF8A0
	static DelTeamEntityNotify() {} // 0x00000001819FF730-0x00000001819FF810

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelTeamEntityNotify Clone() => default; // 0x00000001819FEFC0-0x00000001819FF0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelTeamEntityNotify ShallowCopy() => default; // 0x00000001819FEBB0-0x00000001819FEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819FE5A0-0x00000001819FE5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819FF1D0-0x00000001819FF220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819FF220-0x00000001819FF270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819FE5F0-0x00000001819FE6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819FE750-0x00000001819FE820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DelTeamEntityNotify other) => default; // 0x00000001819FE820-0x00000001819FE950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819FED40-0x00000001819FEE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819FF550-0x00000001819FF730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819FF2D0-0x00000001819FF410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819FE950-0x00000001819FEA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DelTeamEntityNotify other) {} // 0x00000001819FE470-0x00000001819FE5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819FE240-0x00000001819FE3B0
}

