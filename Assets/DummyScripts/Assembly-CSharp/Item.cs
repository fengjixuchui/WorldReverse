/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Item : MessageBase, IMessage<Item> // TypeDefIndex: 25984
{
	// Fields
	private static readonly MessageParser<Item> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0A8FB
	private uint itemId_; // 0x18
	public const int GuidFieldNumber = 2; // Metadata: 0x00B0A8FF
	private ulong guid_; // 0x20
	public const int MaterialFieldNumber = 5; // Metadata: 0x00B0A903
	public const int EquipFieldNumber = 6; // Metadata: 0x00B0A907
	public const int FurnitureFieldNumber = 7; // Metadata: 0x00B0A90B
	private object detail_; // 0x28
	private DetailOneofCase detailCase_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Item> Parser { get => default; } // 0x00000001824503F0-0x0000000182450480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182450010-0x00000001824500A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018244FC50-0x000000018244FCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018244ECA0-0x000000018244ED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182450C80-0x0000000182450D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182450960-0x00000001824509C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182450170-0x0000000182450260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182450B90-0x0000000182450BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018244FD70-0x000000018244FE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000182450510-0x00000001824505B0 0x0000000182450BE0-0x0000000182450C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x000000018244F0F0-0x000000018244F190 0x000000018244F490-0x000000018244F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Material Material { get => default; set {} } // 0x000000018244ED60-0x000000018244EE30 0x000000018244EE30-0x000000018244EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Equip Equip { get => default; set {} } // 0x00000001824500A0-0x0000000182450170 0x000000018244F3F0-0x000000018244F490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Furniture Furniture { get => default; set {} } // 0x0000000182450890-0x0000000182450960 0x0000000182450350-0x00000001824503F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x000000018244F310-0x000000018244F370 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 25985
	{
		None = 0,
		Material = 5,
		Equip = 6,
		Furniture = 7
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Item() {} // 0x0000000182451220-0x0000000182451290
	static Item() {} // 0x0000000182451160-0x0000000182451220

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Item Clone() => default; // 0x0000000182450260-0x0000000182450350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Item ShallowCopy() => default; // 0x000000018244FCD0-0x000000018244FD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018244F190-0x000000018244F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824505B0-0x0000000182450720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182450720-0x0000000182450890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018244F370-0x000000018244F3F0
	public void resetDetail() {} // 0x000000018244F9D0-0x000000018244FC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x000000018244ED00-0x000000018244ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018244F700-0x000000018244F7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Item other) => default; // 0x000000018244F530-0x000000018244F700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018244FE60-0x0000000182450010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182450D70-0x0000000182451160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824509C0-0x0000000182450B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018244F7D0-0x000000018244F9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Item other) {} // 0x000000018244EED0-0x000000018244F0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018244EA00-0x000000018244ECA0
}

