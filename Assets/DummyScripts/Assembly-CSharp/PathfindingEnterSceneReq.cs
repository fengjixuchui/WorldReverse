/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PathfindingEnterSceneReq : MessageBase, IMessage<PathfindingEnterSceneReq> // TypeDefIndex: 24271
{
	// Fields
	private static readonly MessageParser<PathfindingEnterSceneReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B05FE3
	private uint sceneId_; // 0x18
	public const int VersionFieldNumber = 2; // Metadata: 0x00B05FE7
	private uint version_; // 0x1C
	public const int ObstaclesFieldNumber = 3; // Metadata: 0x00B05FEB
	private static readonly FieldCodec<ObstacleInfo> _repeated_obstacles_codec; // 0x08
	private readonly RepeatedMessageField<ObstacleInfo> obstacles_; // 0x20
	public const int IsEditorFieldNumber = 4; // Metadata: 0x00B05FEF
	private bool isEditor_; // 0x28
	public const int ActivityIdFieldNumber = 5; // Metadata: 0x00B05FF3
	private static readonly FieldCodec<uint> _repeated_activityId_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> activityId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PathfindingEnterSceneReq> Parser { get => default; } // 0x00000001842CEDA0-0x00000001842CEE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842CE9F0-0x00000001842CEA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842CE600-0x00000001842CE680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842CDBE0-0x00000001842CDC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842CF3B0-0x00000001842CF4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842CF0E0-0x00000001842CF140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842CEB20-0x00000001842CEC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842CF360-0x00000001842CF3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842CE780-0x00000001842CE870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001842CE060-0x00000001842CE100 0x00000001842CE560-0x00000001842CE600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Version { get => default; set {} } // 0x00000001842CEA80-0x00000001842CEB20 0x00000001842CEC10-0x00000001842CECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ObstacleInfo> Obstacles { get => default; } // 0x00000001842CE680-0x00000001842CE6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEditor { get => default; set {} } // 0x00000001842CEFE0-0x00000001842CF080 0x00000001842CDC40-0x00000001842CDCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ActivityId { get => default; } // 0x00000001842CF080-0x00000001842CF0E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24272
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24273
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2305
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PathfindingEnterSceneReq() {} // 0x00000001842CF940-0x00000001842CF9F0
	static PathfindingEnterSceneReq() {} // 0x00000001842CF810-0x00000001842CF940

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PathfindingEnterSceneReq Clone() => default; // 0x00000001842CECB0-0x00000001842CEDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PathfindingEnterSceneReq ShallowCopy() => default; // 0x00000001842CE6E0-0x00000001842CE780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842CDEC0-0x00000001842CDF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842CEEC0-0x00000001842CEF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842CEF50-0x00000001842CEFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842CDF10-0x00000001842CE060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842CE290-0x00000001842CE360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PathfindingEnterSceneReq other) => default; // 0x00000001842CE100-0x00000001842CE290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842CE870-0x00000001842CE9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842CF4A0-0x00000001842CF810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842CF140-0x00000001842CF360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842CE360-0x00000001842CE560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PathfindingEnterSceneReq other) {} // 0x00000001842CDCE0-0x00000001842CDEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842CD9D0-0x00000001842CDBE0
}

