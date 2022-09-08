/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CreateEntityInfo : MessageBase, IMessage<CreateEntityInfo> // TypeDefIndex: 26058
{
	// Fields
	private static readonly MessageParser<CreateEntityInfo> _parser; // 0x00
	public const int MonsterIdFieldNumber = 1; // Metadata: 0x00B0AEC3
	public const int NpcIdFieldNumber = 2; // Metadata: 0x00B0AEC7
	public const int GadgetIdFieldNumber = 3; // Metadata: 0x00B0AECB
	public const int ItemIdFieldNumber = 4; // Metadata: 0x00B0AECF
	public const int LevelFieldNumber = 5; // Metadata: 0x00B0AED3
	private uint level_; // 0x18
	public const int PosFieldNumber = 6; // Metadata: 0x00B0AED7
	private Vector pos_; // 0x20
	public const int RotFieldNumber = 7; // Metadata: 0x00B0AEDB
	private Vector rot_; // 0x28
	public const int SceneIdFieldNumber = 10; // Metadata: 0x00B0AEDF
	private uint sceneId_; // 0x30
	public const int RoomIdFieldNumber = 11; // Metadata: 0x00B0AEE3
	private uint roomId_; // 0x34
	public const int ClientUniqueIdFieldNumber = 12; // Metadata: 0x00B0AEE7
	private uint clientUniqueId_; // 0x38
	public const int GadgetFieldNumber = 13; // Metadata: 0x00B0AEEB
	private object entity_; // 0x40
	private EntityOneofCase entityCase_; // 0x48
	private object entityCreateInfo_; // 0x50
	private EntityCreateInfoOneofCase entityCreateInfoCase_; // 0x58

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CreateEntityInfo> Parser { get => default; } // 0x0000000183C594B0-0x0000000183C59540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C58D30-0x0000000183C58DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C58550-0x0000000183C585D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C56F40-0x0000000183C56FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C59EF0-0x0000000183C59FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C599D0-0x0000000183C59A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C59160-0x0000000183C59250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C59DF0-0x0000000183C59E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C587C0-0x0000000183C588B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x0000000183C593E0-0x0000000183C594B0 0x0000000183C57140-0x0000000183C571F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcId { get => default; set {} } // 0x0000000183C58F90-0x0000000183C59060 0x0000000183C585D0-0x0000000183C58680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x0000000183C583E0-0x0000000183C584B0 0x0000000183C58C20-0x0000000183C58CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000183C595D0-0x0000000183C596A0 0x0000000183C59E40-0x0000000183C59EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000183C57690-0x0000000183C57730 0x0000000183C58720-0x0000000183C587C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000183C59930-0x0000000183C599D0 0x0000000183C59D50-0x0000000183C59DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x0000000183C58DC0-0x0000000183C58E60 0x0000000183C570A0-0x0000000183C57140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000183C57B70-0x0000000183C57C10 0x0000000183C584B0-0x0000000183C58550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomId { get => default; set {} } // 0x0000000183C56FA0-0x0000000183C57040 0x0000000183C59060-0x0000000183C59100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientUniqueId { get => default; set {} } // 0x0000000183C59340-0x0000000183C593E0 0x0000000183C58E60-0x0000000183C58F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateGadgetInfo Gadget { get => default; set {} } // 0x0000000183C59780-0x0000000183C59850 0x0000000183C571F0-0x0000000183C57290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityOneofCase EntityCase { get => default; } // 0x0000000183C58CD0-0x0000000183C58D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityCreateInfoOneofCase EntityCreateInfoCase { get => default; } // 0x0000000183C57040-0x0000000183C570A0 

	// Nested types
	public enum EntityOneofCase // TypeDefIndex: 26059
	{
		None = 0,
		MonsterId = 1,
		NpcId = 2,
		GadgetId = 3,
		ItemId = 4
	}

	public enum EntityCreateInfoOneofCase // TypeDefIndex: 26060
	{
		None = 0,
		Gadget = 13
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo() {} // 0x0000000183C5A850-0x0000000183C5A8C0
	static CreateEntityInfo() {} // 0x0000000183C5A790-0x0000000183C5A850

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo Clone() => default; // 0x0000000183C59250-0x0000000183C59340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo ShallowCopy() => default; // 0x0000000183C58680-0x0000000183C58720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C57730-0x0000000183C57820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C596A0-0x0000000183C59780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C59850-0x0000000183C59930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C57820-0x0000000183C57A50
	public void resetEntity() {} // 0x0000000183C58F00-0x0000000183C58F90
	public void resetEntityCreateInfo() {} // 0x0000000183C57A50-0x0000000183C57B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntity() {} // 0x0000000183C57290-0x0000000183C572F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntityCreateInfo() {} // 0x0000000183C59100-0x0000000183C59160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C57C10-0x0000000183C57CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CreateEntityInfo other) => default; // 0x0000000183C57CE0-0x0000000183C57F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C588B0-0x0000000183C58C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C59FE0-0x0000000183C5A790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C59A30-0x0000000183C59D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C57F80-0x0000000183C583E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CreateEntityInfo other) {} // 0x0000000183C572F0-0x0000000183C57690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C56C40-0x0000000183C56F40
}

