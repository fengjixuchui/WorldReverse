/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ObstacleInfo : MessageBase, IMessage<ObstacleInfo> // TypeDefIndex: 24262
{
	// Fields
	private static readonly MessageParser<ObstacleInfo> _parser; // 0x00
	public const int ObstacleIdFieldNumber = 1; // Metadata: 0x00B05F93
	private int obstacleId_; // 0x18
	public const int ShapeFieldNumber = 2; // Metadata: 0x00B05F97
	private Types.ShapeType shape_; // 0x1C
	public const int CenterFieldNumber = 3; // Metadata: 0x00B05F9B
	private Vector center_; // 0x20
	public const int RotationFieldNumber = 4; // Metadata: 0x00B05F9F
	private MathQuaternion rotation_; // 0x28
	public const int ExtentsFieldNumber = 5; // Metadata: 0x00B05FA3
	private Vector3Int extents_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ObstacleInfo> Parser { get => default; } // 0x0000000183289590-0x0000000183289620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183289280-0x0000000183289310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183288C80-0x0000000183288D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183287E70-0x0000000183287ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183289B10-0x0000000183289C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832897F0-0x0000000183289850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183289310-0x0000000183289400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183289AC0-0x0000000183289B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183288DA0-0x0000000183288E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ObstacleId { get => default; set {} } // 0x0000000183288570-0x0000000183288610 0x0000000183287ED0-0x0000000183287F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.ShapeType Shape { get => default; set {} } // 0x0000000183288BE0-0x0000000183288C80 0x0000000183287DD0-0x0000000183287E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x0000000183287AA0-0x0000000183287B40 0x00000001832891E0-0x0000000183289280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion Rotation { get => default; set {} } // 0x0000000183289A20-0x0000000183289AC0 0x0000000183287D30-0x0000000183287DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int Extents { get => default; set {} } // 0x00000001832894F0-0x0000000183289590 0x0000000183289C00-0x0000000183289CA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24263
	{
		// Nested types
		public enum ShapeType // TypeDefIndex: 24264
		{
			ObstacleShapeCapsule = 0,
			ObstacleShapeBox = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleInfo() {} // 0x000000018328A0B0-0x000000018328A120
	static ObstacleInfo() {} // 0x0000000183289FF0-0x000000018328A0B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleInfo Clone() => default; // 0x0000000183289400-0x00000001832894F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ObstacleInfo ShallowCopy() => default; // 0x0000000183288D00-0x0000000183288DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183288200-0x00000001832882B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832896B0-0x0000000183289750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183289750-0x00000001832897F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832882B0-0x0000000183288570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183288610-0x00000001832886E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ObstacleInfo other) => default; // 0x00000001832886E0-0x0000000183288890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183288E90-0x00000001832891E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183289CA0-0x0000000183289FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183289850-0x0000000183289A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183288890-0x0000000183288BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ObstacleInfo other) {} // 0x0000000183287F70-0x0000000183288200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183287B40-0x0000000183287D30
}

