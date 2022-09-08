/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DelScenePlayTeamEntityNotify : MessageBase, IMessage<DelScenePlayTeamEntityNotify> // TypeDefIndex: 25308
{
	// Fields
	private static readonly MessageParser<DelScenePlayTeamEntityNotify> _parser; // 0x00
	public const int DelEntityIdListFieldNumber = 1; // Metadata: 0x00B086BF
	private static readonly FieldCodec<uint> _repeated_delEntityIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> delEntityIdList_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B086C3
	private uint sceneId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DelScenePlayTeamEntityNotify> Parser { get => default; } // 0x0000000184CF9FB0-0x0000000184CFA040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CF9D40-0x0000000184CF9DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CF9A30-0x0000000184CF9AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CF92B0-0x0000000184CF9310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CFA360-0x0000000184CFA450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CFA170-0x0000000184CFA1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CF9DD0-0x0000000184CF9EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CFA310-0x0000000184CFA360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CF9B50-0x0000000184CF9C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DelEntityIdList { get => default; } // 0x0000000184CF9310-0x0000000184CF9370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000184CF95C0-0x0000000184CF9660 0x0000000184CF9990-0x0000000184CF9A30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25309
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25310
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3051
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelScenePlayTeamEntityNotify() {} // 0x0000000184CFA710-0x0000000184CFA7A0
	static DelScenePlayTeamEntityNotify() {} // 0x0000000184CFA630-0x0000000184CFA710

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelScenePlayTeamEntityNotify Clone() => default; // 0x0000000184CF9EC0-0x0000000184CF9FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DelScenePlayTeamEntityNotify ShallowCopy() => default; // 0x0000000184CF9AB0-0x0000000184CF9B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CF94A0-0x0000000184CF94F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CFA0D0-0x0000000184CFA120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CFA120-0x0000000184CFA170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CF94F0-0x0000000184CF95C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CF9660-0x0000000184CF9730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DelScenePlayTeamEntityNotify other) => default; // 0x0000000184CF9730-0x0000000184CF9850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CF9C40-0x0000000184CF9D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CFA450-0x0000000184CFA630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CFA1D0-0x0000000184CFA310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CF9850-0x0000000184CF9990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DelScenePlayTeamEntityNotify other) {} // 0x0000000184CF9370-0x0000000184CF94A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CF9140-0x0000000184CF92B0
}

