/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ObstacleModifyNotify : MessageBase, IMessage<ObstacleModifyNotify> // TypeDefIndex: 24265
{
	// Fields
	private static readonly MessageParser<ObstacleModifyNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B05FAF
	private uint sceneId_; // 0x18
	public const int AddObstaclesFieldNumber = 2; // Metadata: 0x00B05FB3
	private static readonly FieldCodec<ObstacleInfo> _repeated_addObstacles_codec; // 0x08
	private readonly RepeatedMessageField<ObstacleInfo> addObstacles_; // 0x20
	public const int RemoveObstacleIdsFieldNumber = 3; // Metadata: 0x00B05FB7
	private static readonly FieldCodec<int> _repeated_removeObstacleIds_codec; // 0x10
	private readonly RepeatedPrimitiveField<int> removeObstacleIds_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ObstacleModifyNotify> Parser { get => default; } // 0x000000018321C000-0x000000018321C090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018321BD30-0x000000018321BDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018321BA00-0x000000018321BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018321B140-0x000000018321B1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018321C460-0x000000018321C550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018321C240-0x000000018321C2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018321BDC0-0x000000018321BEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018321C410-0x000000018321C460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018321BB20-0x000000018321BC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x000000018321B520-0x000000018321B5C0 0x000000018321B960-0x000000018321BA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ObstacleInfo> AddObstacles { get => default; } // 0x000000018321B4C0-0x000000018321B520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> RemoveObstacleIds { get => default; } // 0x000000018321BFA0-0x000000018321C000 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24266
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24267
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2303
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleModifyNotify() {} // 0x000000018321C8E0-0x000000018321C990
	static ObstacleModifyNotify() {} // 0x000000018321C7B0-0x000000018321C8E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleModifyNotify Clone() => default; // 0x000000018321BEB0-0x000000018321BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleModifyNotify ShallowCopy() => default; // 0x000000018321BA80-0x000000018321BB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018321B330-0x000000018321B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018321C120-0x000000018321C1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018321C1B0-0x000000018321C240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018321B380-0x000000018321B4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018321B5C0-0x000000018321B690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ObstacleModifyNotify other) => default; // 0x000000018321B690-0x000000018321B7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018321BC10-0x000000018321BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018321C550-0x000000018321C7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018321C2A0-0x000000018321C410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018321B7E0-0x000000018321B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ObstacleModifyNotify other) {} // 0x000000018321B1A0-0x000000018321B330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018321AF60-0x000000018321B140
}

