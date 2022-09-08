/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerFightRecordPair : MessageBase, IMessage<TowerFightRecordPair> // TypeDefIndex: 25757
{
	// Fields
	private static readonly MessageParser<TowerFightRecordPair> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B09823
	private uint avatarId_; // 0x18
	public const int DataFieldNumber = 2; // Metadata: 0x00B09827
	private uint data_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerFightRecordPair> Parser { get => default; } // 0x000000018240DAE0-0x000000018240DB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018240D7D0-0x000000018240D860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018240D4C0-0x000000018240D540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018240CD70-0x000000018240CDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018240DE70-0x000000018240DF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018240DCA0-0x000000018240DD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018240D860-0x000000018240D950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018240DE20-0x000000018240DE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018240D5E0-0x000000018240D6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x000000018240D380-0x000000018240D420 0x000000018240D420-0x000000018240D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Data { get => default; set {} } // 0x000000018240D1B0-0x000000018240D250 0x000000018240DA40-0x000000018240DAE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair() {} // 0x000000018240E220-0x000000018240E280
	static TowerFightRecordPair() {} // 0x000000018240E160-0x000000018240E220

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair Clone() => default; // 0x000000018240D950-0x000000018240DA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair ShallowCopy() => default; // 0x000000018240D540-0x000000018240D5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018240CF00-0x000000018240CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018240DC00-0x000000018240DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018240DC50-0x000000018240DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018240CF50-0x000000018240CFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018240D0E0-0x000000018240D1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerFightRecordPair other) => default; // 0x000000018240CFC0-0x000000018240D0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018240D6D0-0x000000018240D7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018240DF60-0x000000018240E160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018240DD00-0x000000018240DE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018240D250-0x000000018240D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerFightRecordPair other) {} // 0x000000018240CDD0-0x000000018240CF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018240CC70-0x000000018240CD70
}

