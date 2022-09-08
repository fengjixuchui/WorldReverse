/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayInfo : MessageBase, IMessage<ScenePlayInfo> // TypeDefIndex: 25396
{
	// Fields
	private static readonly MessageParser<ScenePlayInfo> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08A3F
	private uint playId_; // 0x18
	public const int PlayTypeFieldNumber = 2; // Metadata: 0x00B08A43
	private uint playType_; // 0x1C
	public const int EntryIdFieldNumber = 3; // Metadata: 0x00B08A47
	private uint entryId_; // 0x20
	public const int IsOpenFieldNumber = 4; // Metadata: 0x00B08A4B
	private bool isOpen_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayInfo> Parser { get => default; } // 0x00000001824464C0-0x0000000182446550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182446250-0x00000001824462E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182445E40-0x0000000182445EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182445540-0x00000001824455A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182446AB0-0x0000000182446BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182446720-0x0000000182446780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824462E0-0x00000001824463D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182446A60-0x0000000182446AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182445F60-0x0000000182446050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000182445DA0-0x0000000182445E40 0x00000001824461B0-0x0000000182446250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000182446780-0x0000000182446820 0x0000000182445940-0x00000001824459E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntryId { get => default; set {} } // 0x0000000182446630-0x00000001824466D0 0x00000001824458A0-0x0000000182445940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000182446820-0x00000001824468C0 0x00000001824455A0-0x0000000182445640

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayInfo() {} // 0x0000000182446F80-0x0000000182446FE0
	static ScenePlayInfo() {} // 0x0000000182446EC0-0x0000000182446F80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayInfo Clone() => default; // 0x00000001824463D0-0x00000001824464C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayInfo ShallowCopy() => default; // 0x0000000182445EC0-0x0000000182445F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824457C0-0x0000000182445810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824465E0-0x0000000182446630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824466D0-0x0000000182446720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182445810-0x00000001824458A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824459E0-0x0000000182445AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayInfo other) => default; // 0x0000000182445AB0-0x0000000182445C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182446050-0x00000001824461B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182446BA0-0x0000000182446EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824468C0-0x0000000182446A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182445C10-0x0000000182445DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayInfo other) {} // 0x0000000182445640-0x00000001824457C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182445410-0x0000000182445540
}

