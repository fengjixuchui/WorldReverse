/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientMassiveEntity : MessageBase, IMessage<ClientMassiveEntity> // TypeDefIndex: 26085
{
	// Fields
	private static readonly MessageParser<ClientMassiveEntity> _parser; // 0x00
	public const int EntityTypeFieldNumber = 1; // Metadata: 0x00B0B117
	private uint entityType_; // 0x18
	public const int ConfigIdFieldNumber = 2; // Metadata: 0x00B0B11B
	private uint configId_; // 0x1C
	public const int ObjIdFieldNumber = 3; // Metadata: 0x00B0B11F
	private long objId_; // 0x20
	public const int WaterInfoFieldNumber = 4; // Metadata: 0x00B0B123
	public const int GrassInfoFieldNumber = 5; // Metadata: 0x00B0B127
	public const int BoxInfoFieldNumber = 6; // Metadata: 0x00B0B12B
	private object entityInfo_; // 0x28
	private EntityInfoOneofCase entityInfoCase_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientMassiveEntity> Parser { get => default; } // 0x0000000181214610-0x00000001812146A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812140F0-0x0000000181214180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181213C50-0x0000000181213CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181212DF0-0x0000000181212E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181215020-0x0000000181215110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181214D60-0x0000000181214DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181214390-0x0000000181214480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181214FD0-0x0000000181215020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181213DD0-0x0000000181213EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityType { get => default; set {} } // 0x0000000181213280-0x0000000181213320 0x0000000181212F90-0x0000000181213030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000181214250-0x00000001812142F0 0x0000000181212E50-0x0000000181212EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long ObjId { get => default; set {} } // 0x0000000181212EF0-0x0000000181212F90 0x0000000181214570-0x0000000181214610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveWaterInfo WaterInfo { get => default; set {} } // 0x0000000181214180-0x0000000181214250 0x00000001812142F0-0x0000000181214390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveGrassInfo GrassInfo { get => default; set {} } // 0x0000000181213530-0x0000000181213600 0x0000000181213BB0-0x0000000181213C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveBoxInfo BoxInfo { get => default; set {} } // 0x0000000181214C90-0x0000000181214D60 0x0000000181213600-0x00000001812136A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityInfoOneofCase EntityInfoCase { get => default; } // 0x0000000181214090-0x00000001812140F0 

	// Nested types
	public enum EntityInfoOneofCase // TypeDefIndex: 26086
	{
		None = 0,
		WaterInfo = 4,
		GrassInfo = 5,
		BoxInfo = 6
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientMassiveEntity() {} // 0x0000000181215660-0x00000001812156D0
	static ClientMassiveEntity() {} // 0x00000001812155A0-0x0000000181215660

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientMassiveEntity Clone() => default; // 0x0000000181214480-0x0000000181214570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientMassiveEntity ShallowCopy() => default; // 0x0000000181213CD0-0x0000000181213D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181213320-0x00000001812134A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812149B0-0x0000000181214B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181214B20-0x0000000181214C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812134A0-0x0000000181213530
	public void resetEntityInfo() {} // 0x00000001812146A0-0x0000000181214920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntityInfo() {} // 0x0000000181213D70-0x0000000181213DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001812136A0-0x0000000181213770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientMassiveEntity other) => default; // 0x0000000181213770-0x0000000181213960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181213EC0-0x0000000181214090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181215110-0x00000001812155A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181214DC0-0x0000000181214FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181213960-0x0000000181213BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientMassiveEntity other) {} // 0x0000000181213030-0x0000000181213280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181212B30-0x0000000181212DF0
}

