/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneNpcInfo : MessageBase, IMessage<SceneNpcInfo> // TypeDefIndex: 26016
{
	// Fields
	private static readonly MessageParser<SceneNpcInfo> _parser; // 0x00
	public const int NpcIdFieldNumber = 1; // Metadata: 0x00B0AB77
	private uint npcId_; // 0x18
	public const int RoomIdFieldNumber = 2; // Metadata: 0x00B0AB7B
	private uint roomId_; // 0x1C
	public const int ParentQuestIdFieldNumber = 3; // Metadata: 0x00B0AB7F
	private uint parentQuestId_; // 0x20
	public const int BlockIdFieldNumber = 4; // Metadata: 0x00B0AB83
	private uint blockId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneNpcInfo> Parser { get => default; } // 0x0000000183398FB0-0x0000000183399040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183398B60-0x0000000183398BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183398750-0x00000001833987D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183397F60-0x0000000183397FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183399500-0x00000001833995F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183399210-0x0000000183399270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183398DD0-0x0000000183398EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833994B0-0x0000000183399500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183398910-0x0000000183398A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcId { get => default; set {} } // 0x0000000183398C90-0x0000000183398D30 0x00000001833987D0-0x0000000183398870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomId { get => default; set {} } // 0x0000000183397FC0-0x0000000183398060 0x0000000183398D30-0x0000000183398DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x00000001833982C0-0x0000000183398360 0x0000000183398BF0-0x0000000183398C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlockId { get => default; set {} } // 0x0000000183399170-0x0000000183399210 0x0000000183399270-0x0000000183399310

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneNpcInfo() {} // 0x00000001833999D0-0x0000000183399A30
	static SceneNpcInfo() {} // 0x0000000183399910-0x00000001833999D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneNpcInfo Clone() => default; // 0x0000000183398EC0-0x0000000183398FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneNpcInfo ShallowCopy() => default; // 0x0000000183398870-0x0000000183398910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833981E0-0x0000000183398230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833990D0-0x0000000183399120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183399120-0x0000000183399170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183398230-0x00000001833982C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833984B0-0x0000000183398580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneNpcInfo other) => default; // 0x0000000183398360-0x00000001833984B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183398A00-0x0000000183398B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833995F0-0x0000000183399910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183399310-0x00000001833994B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183398580-0x0000000183398750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneNpcInfo other) {} // 0x0000000183398060-0x00000001833981E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183397E30-0x0000000183397F60
}

