/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityJumpNotify : MessageBase, IMessage<EntityJumpNotify> // TypeDefIndex: 24956
{
	// Fields
	private static readonly MessageParser<EntityJumpNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B07A53
	private uint entityId_; // 0x18
	public const int JumpTypeFieldNumber = 2; // Metadata: 0x00B07A57
	private Types.Type jumpType_; // 0x1C
	public const int PosFieldNumber = 3; // Metadata: 0x00B07A5B
	private Vector pos_; // 0x20
	public const int RotFieldNumber = 4; // Metadata: 0x00B07A5F
	private Vector rot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityJumpNotify> Parser { get => default; } // 0x0000000185608D00-0x0000000185608D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185608950-0x00000001856089E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185608490-0x0000000185608510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185607A00-0x0000000185607A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185609360-0x0000000185609450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185609080-0x00000001856090E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185608A80-0x0000000185608B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185609310-0x0000000185609360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001856085B0-0x00000001856086A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000185608FE0-0x0000000185609080 0x0000000185609450-0x00000001856094F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Type JumpType { get => default; set {} } // 0x0000000185608B70-0x0000000185608C10 0x00000001856094F0-0x0000000185609590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000185608F40-0x0000000185608FE0 0x0000000185609270-0x0000000185609310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x00000001856089E0-0x0000000185608A80 0x0000000185607A60-0x0000000185607B00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24957
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24958
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 221
		}

		public enum Type // TypeDefIndex: 24959
		{
			Null = 0,
			Active = 1,
			Passive = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityJumpNotify() {} // 0x0000000185609930-0x00000001856099A0
	static EntityJumpNotify() {} // 0x0000000185609870-0x0000000185609930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityJumpNotify Clone() => default; // 0x0000000185608C10-0x0000000185608D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityJumpNotify ShallowCopy() => default; // 0x0000000185608510-0x00000001856085B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185607D20-0x0000000185607DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185608E20-0x0000000185608EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185608EB0-0x0000000185608F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185607DB0-0x0000000185607FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185608130-0x0000000185608200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityJumpNotify other) => default; // 0x0000000185607FB0-0x0000000185608130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001856086A0-0x0000000185608950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185609590-0x0000000185609870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001856090E0-0x0000000185609270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185608200-0x0000000185608490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityJumpNotify other) {} // 0x0000000185607B00-0x0000000185607D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185607860-0x0000000185607A00
}

