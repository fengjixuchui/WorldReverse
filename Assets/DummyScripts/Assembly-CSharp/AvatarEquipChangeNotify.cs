/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarEquipChangeNotify : MessageBase, IMessage<AvatarEquipChangeNotify> // TypeDefIndex: 23648
{
	// Fields
	private static readonly MessageParser<AvatarEquipChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B047FB
	private ulong avatarGuid_; // 0x18
	public const int EquipTypeFieldNumber = 2; // Metadata: 0x00B047FF
	private uint equipType_; // 0x20
	public const int ItemIdFieldNumber = 3; // Metadata: 0x00B04803
	private uint itemId_; // 0x24
	public const int EquipGuidFieldNumber = 4; // Metadata: 0x00B04807
	private ulong equipGuid_; // 0x28
	public const int WeaponFieldNumber = 5; // Metadata: 0x00B0480B
	private SceneWeaponInfo weapon_; // 0x30
	public const int ReliquaryFieldNumber = 6; // Metadata: 0x00B0480F
	private SceneReliquaryInfo reliquary_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarEquipChangeNotify> Parser { get => default; } // 0x000000018397CF20-0x000000018397CFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018397CAD0-0x000000018397CB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018397C560-0x000000018397C5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018397B7B0-0x000000018397B810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018397D600-0x000000018397D6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018397D200-0x000000018397D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018397CC00-0x000000018397CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018397D510-0x000000018397D560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018397C720-0x000000018397C810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018397CB60-0x000000018397CC00 0x000000018397BBC0-0x000000018397BC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EquipType { get => default; set {} } // 0x000000018397C5E0-0x000000018397C680 0x000000018397B810-0x000000018397B8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x000000018397D040-0x000000018397D0E0 0x000000018397D560-0x000000018397D600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong EquipGuid { get => default; set {} } // 0x000000018397C4C0-0x000000018397C560 0x000000018397D260-0x000000018397D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeaponInfo Weapon { get => default; set {} } // 0x000000018397CE80-0x000000018397CF20 0x000000018397CCF0-0x000000018397CD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneReliquaryInfo Reliquary { get => default; set {} } // 0x000000018397B8B0-0x000000018397B950 0x000000018397D6F0-0x000000018397D790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23649
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23650
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 618
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipChangeNotify() {} // 0x000000018397DC50-0x000000018397DCB0
	static AvatarEquipChangeNotify() {} // 0x000000018397DB90-0x000000018397DC50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipChangeNotify Clone() => default; // 0x000000018397CD90-0x000000018397CE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEquipChangeNotify ShallowCopy() => default; // 0x000000018397C680-0x000000018397C720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018397BC60-0x000000018397BCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018397D0E0-0x000000018397D170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018397D170-0x000000018397D200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018397BCF0-0x000000018397BF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018397BF00-0x000000018397BFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarEquipChangeNotify other) => default; // 0x000000018397BFD0-0x000000018397C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018397C810-0x000000018397CAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018397D790-0x000000018397DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018397D300-0x000000018397D510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018397C190-0x000000018397C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarEquipChangeNotify other) {} // 0x000000018397B950-0x000000018397BBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018397B5C0-0x000000018397B7B0
}

