/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassProduct : MessageBase, IMessage<BattlePassProduct> // TypeDefIndex: 22543
{
	// Fields
	private static readonly MessageParser<BattlePassProduct> _parser; // 0x00
	public const int NormalProductIdFieldNumber = 1; // Metadata: 0x00B01D3B
	private string normalProductId_; // 0x18
	public const int ExtraProductIdFieldNumber = 2; // Metadata: 0x00B01D3F
	private string extraProductId_; // 0x20
	public const int UpgradeProductIdFieldNumber = 3; // Metadata: 0x00B01D43
	private string upgradeProductId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassProduct> Parser { get => default; } // 0x0000000181A764E0-0x0000000181A76570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A761D0-0x0000000181A76260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A75D70-0x0000000181A75DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A75410-0x0000000181A75470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A769B0-0x0000000181A76AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A76750-0x0000000181A767B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A76260-0x0000000181A76350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A76960-0x0000000181A769B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A75F40-0x0000000181A76030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NormalProductId { get => default; set {} } // 0x0000000181A76440-0x0000000181A764E0 0x0000000181A75700-0x0000000181A757B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ExtraProductId { get => default; set {} } // 0x0000000181A75C30-0x0000000181A75CD0 0x0000000181A75E90-0x0000000181A75F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string UpgradeProductId { get => default; set {} } // 0x0000000181A75CD0-0x0000000181A75D70 0x0000000181A76600-0x0000000181A766B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassProduct() {} // 0x0000000181A76D90-0x0000000181A76E20
	static BattlePassProduct() {} // 0x0000000181A76CD0-0x0000000181A76D90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassProduct Clone() => default; // 0x0000000181A76350-0x0000000181A76440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassProduct ShallowCopy() => default; // 0x0000000181A75DF0-0x0000000181A75E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A75620-0x0000000181A75670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A766B0-0x0000000181A76700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A76700-0x0000000181A76750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A75670-0x0000000181A75700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A757B0-0x0000000181A75880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassProduct other) => default; // 0x0000000181A75880-0x0000000181A75A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A76030-0x0000000181A761D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A76AA0-0x0000000181A76CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A767B0-0x0000000181A76960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A75A60-0x0000000181A75C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassProduct other) {} // 0x0000000181A75470-0x0000000181A75620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A752F0-0x0000000181A75410
}

