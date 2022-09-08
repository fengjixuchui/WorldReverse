/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServerMassiveEntity : MessageBase, IMessage<ServerMassiveEntity> // TypeDefIndex: 26089
{
	// Fields
	private static readonly MessageParser<ServerMassiveEntity> _parser; // 0x00
	public const int EntityTypeFieldNumber = 1; // Metadata: 0x00B0B15B
	private uint entityType_; // 0x18
	public const int ConfigIdFieldNumber = 2; // Metadata: 0x00B0B15F
	private uint configId_; // 0x1C
	public const int RuntimeIdFieldNumber = 3; // Metadata: 0x00B0B163
	private uint runtimeId_; // 0x20
	public const int AuthorityPeerIdFieldNumber = 4; // Metadata: 0x00B0B167
	private uint authorityPeerId_; // 0x24
	public const int ObjIdFieldNumber = 5; // Metadata: 0x00B0B16B
	private long objId_; // 0x28
	public const int WaterInfoFieldNumber = 6; // Metadata: 0x00B0B16F
	public const int GrassInfoFieldNumber = 7; // Metadata: 0x00B0B173
	public const int BoxInfoFieldNumber = 8; // Metadata: 0x00B0B177
	private object entityInfo_; // 0x30
	private EntityInfoOneofCase entityInfoCase_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServerMassiveEntity> Parser { get => default; } // 0x0000000183859690-0x0000000183859720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838590D0-0x0000000183859160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183858BD0-0x0000000183858C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183857B00-0x0000000183857B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018385A1B0-0x000000018385A2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183859E80-0x0000000183859EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183859370-0x0000000183859460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018385A160-0x000000018385A1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183858D50-0x0000000183858E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityType { get => default; set {} } // 0x0000000183858070-0x0000000183858110 0x0000000183857CA0-0x0000000183857D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000183859230-0x00000001838592D0 0x0000000183857B60-0x0000000183857C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RuntimeId { get => default; set {} } // 0x0000000183858A90-0x0000000183858B30 0x0000000183857D40-0x0000000183857DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x0000000183859720-0x00000001838597C0 0x00000001838595F0-0x0000000183859690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long ObjId { get => default; set {} } // 0x0000000183857C00-0x0000000183857CA0 0x0000000183859550-0x00000001838595F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveWaterInfo WaterInfo { get => default; set {} } // 0x0000000183859160-0x0000000183859230 0x00000001838592D0-0x0000000183859370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveGrassInfo GrassInfo { get => default; set {} } // 0x0000000183858340-0x0000000183858410 0x0000000183858B30-0x0000000183858BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveBoxInfo BoxInfo { get => default; set {} } // 0x0000000183859DB0-0x0000000183859E80 0x0000000183858410-0x00000001838584B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityInfoOneofCase EntityInfoCase { get => default; } // 0x0000000183859070-0x00000001838590D0 

	// Nested types
	public enum EntityInfoOneofCase // TypeDefIndex: 26090
	{
		None = 0,
		WaterInfo = 6,
		GrassInfo = 7,
		BoxInfo = 8
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerMassiveEntity() {} // 0x000000018385A950-0x000000018385A9C0
	static ServerMassiveEntity() {} // 0x000000018385A890-0x000000018385A950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerMassiveEntity Clone() => default; // 0x0000000183859460-0x0000000183859550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServerMassiveEntity ShallowCopy() => default; // 0x0000000183858C50-0x0000000183858CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183858110-0x0000000183858290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183859AD0-0x0000000183859C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183859C40-0x0000000183859DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183858290-0x0000000183858340
	public void resetEntityInfo() {} // 0x00000001838597C0-0x0000000183859A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntityInfo() {} // 0x0000000183858CF0-0x0000000183858D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838584B0-0x0000000183858580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServerMassiveEntity other) => default; // 0x0000000183858580-0x00000001838587B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183858E40-0x0000000183859070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018385A2A0-0x000000018385A890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183859EE0-0x000000018385A160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838587B0-0x0000000183858A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServerMassiveEntity other) {} // 0x0000000183857DE0-0x0000000183858070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183857800-0x0000000183857B00
}

