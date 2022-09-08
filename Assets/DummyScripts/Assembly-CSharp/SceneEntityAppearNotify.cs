/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityAppearNotify : MessageBase, IMessage<SceneEntityAppearNotify> // TypeDefIndex: 24910
{
	// Fields
	private static readonly MessageParser<SceneEntityAppearNotify> _parser; // 0x00
	public const int EntityListFieldNumber = 1; // Metadata: 0x00B0787B
	private static readonly FieldCodec<SceneEntityInfo> _repeated_entityList_codec; // 0x08
	private readonly RepeatedMessageField<SceneEntityInfo> entityList_; // 0x18
	public const int AppearTypeFieldNumber = 2; // Metadata: 0x00B0787F
	private VisionType appearType_; // 0x20
	public const int ParamFieldNumber = 3; // Metadata: 0x00B07883
	private uint param_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityAppearNotify> Parser { get => default; } // 0x00000001844F12E0-0x00000001844F1370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001844F0FD0-0x00000001844F1060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001844F0C50-0x00000001844F0CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001844F0470-0x00000001844F04D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001844F1890-0x00000001844F1980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001844F1520-0x00000001844F1580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001844F1100-0x00000001844F11F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001844F1840-0x00000001844F1890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001844F0D70-0x00000001844F0E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneEntityInfo> EntityList { get => default; } // 0x00000001844F04D0-0x00000001844F0530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public VisionType AppearType { get => default; set {} } // 0x00000001844F06C0-0x00000001844F0760 0x00000001844F1060-0x00000001844F1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x00000001844F1580-0x00000001844F1620 0x00000001844F1620-0x00000001844F16C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24911
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24912
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 206
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAppearNotify() {} // 0x00000001844F1D00-0x00000001844F1DA0
	static SceneEntityAppearNotify() {} // 0x00000001844F1BF0-0x00000001844F1D00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAppearNotify Clone() => default; // 0x00000001844F11F0-0x00000001844F12E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAppearNotify ShallowCopy() => default; // 0x00000001844F0CD0-0x00000001844F0D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844F0760-0x00000001844F07B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844F1400-0x00000001844F1490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844F1490-0x00000001844F1520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001844F07B0-0x00000001844F08A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001844F08A0-0x00000001844F0970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityAppearNotify other) => default; // 0x00000001844F0970-0x00000001844F0AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001844F0E60-0x00000001844F0FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001844F1980-0x00000001844F1BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001844F16C0-0x00000001844F1840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001844F0AC0-0x00000001844F0C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityAppearNotify other) {} // 0x00000001844F0530-0x00000001844F06C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001844F0300-0x00000001844F0470
}

