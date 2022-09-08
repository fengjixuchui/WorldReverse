/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopCg : MessageBase, IMessage<CoopCg> // TypeDefIndex: 22701
{
	// Fields
	private static readonly MessageParser<CoopCg> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B022E3
	private uint id_; // 0x18
	public const int IsUnlockFieldNumber = 2; // Metadata: 0x00B022E7
	private bool isUnlock_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopCg> Parser { get => default; } // 0x00000001842EACC0-0x00000001842EAD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842EAA50-0x00000001842EAAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842EA730-0x00000001842EA7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842EA0B0-0x00000001842EA110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842EB190-0x00000001842EB280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842EAF20-0x00000001842EAF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842EAAE0-0x00000001842EABD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842EB140-0x00000001842EB190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842EA850-0x00000001842EA940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001842EA690-0x00000001842EA730 0x00000001842EAD50-0x00000001842EADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUnlock { get => default; set {} } // 0x00000001842EB0A0-0x00000001842EB140 0x00000001842EA300-0x00000001842EA3A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopCg() {} // 0x00000001842EB540-0x00000001842EB5A0
	static CoopCg() {} // 0x00000001842EB480-0x00000001842EB540

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopCg Clone() => default; // 0x00000001842EABD0-0x00000001842EACC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopCg ShallowCopy() => default; // 0x00000001842EA7B0-0x00000001842EA850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842EA240-0x00000001842EA290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842EAE80-0x00000001842EAED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842EAED0-0x00000001842EAF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842EA290-0x00000001842EA300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842EA3A0-0x00000001842EA470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopCg other) => default; // 0x00000001842EA470-0x00000001842EA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842EA940-0x00000001842EAA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842EB280-0x00000001842EB480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842EAF80-0x00000001842EB0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842EA590-0x00000001842EA690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopCg other) {} // 0x00000001842EA110-0x00000001842EA240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842E9FB0-0x00000001842EA0B0
}

