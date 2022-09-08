/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusMonsterInfo : MessageBase, IMessage<InBattleMechanicusMonsterInfo> // TypeDefIndex: 24108
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusMonsterInfo> _parser; // 0x00
	public const int MonsterIdFieldNumber = 1; // Metadata: 0x00B0594F
	private uint monsterId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B05953
	private uint count_; // 0x1C
	public const int LevelFieldNumber = 3; // Metadata: 0x00B05957
	private uint level_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusMonsterInfo> Parser { get => default; } // 0x0000000182FC99B0-0x0000000182FC9A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FC96A0-0x0000000182FC9730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FC92C0-0x0000000182FC9340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FC8B60-0x0000000182FC8BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FC9E20-0x0000000182FC9F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FC9C10-0x0000000182FC9C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FC9730-0x0000000182FC9820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FC9DD0-0x0000000182FC9E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FC9480-0x0000000182FC9570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x0000000182FC9910-0x0000000182FC99B0 0x0000000182FC8BC0-0x0000000182FC8C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000182FC9AD0-0x0000000182FC9B70 0x0000000182FC8AC0-0x0000000182FC8B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000182FC8DC0-0x0000000182FC8E60 0x0000000182FC93E0-0x0000000182FC9480

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusMonsterInfo() {} // 0x0000000182FCA260-0x0000000182FCA2C0
	static InBattleMechanicusMonsterInfo() {} // 0x0000000182FCA1A0-0x0000000182FCA260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusMonsterInfo Clone() => default; // 0x0000000182FC9820-0x0000000182FC9910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusMonsterInfo ShallowCopy() => default; // 0x0000000182FC9340-0x0000000182FC93E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FC8E60-0x0000000182FC8EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC9B70-0x0000000182FC9BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC9BC0-0x0000000182FC9C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FC8EB0-0x0000000182FC8F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FC8F30-0x0000000182FC9000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusMonsterInfo other) => default; // 0x0000000182FC9000-0x0000000182FC9140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FC9570-0x0000000182FC96A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FC9F10-0x0000000182FCA1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FC9C70-0x0000000182FC9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FC9140-0x0000000182FC92C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusMonsterInfo other) {} // 0x0000000182FC8C60-0x0000000182FC8DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FC89B0-0x0000000182FC8AC0
}

