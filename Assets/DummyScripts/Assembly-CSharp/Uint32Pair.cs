/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Uint32Pair : MessageBase, IMessage<Uint32Pair> // TypeDefIndex: 25962
{
	// Fields
	private static readonly MessageParser<Uint32Pair> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00B0A77F
	private uint key_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B0A783
	private uint value_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Uint32Pair> Parser { get => default; } // 0x00000001820711B0-0x0000000182071240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182070EA0-0x0000000182070F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182070B90-0x0000000182070C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182070580-0x00000001820705E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820715E0-0x00000001820716D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182071410-0x0000000182071470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182070FD0-0x00000001820710C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182071590-0x00000001820715E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182070CB0-0x0000000182070DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Key { get => default; set {} } // 0x00000001820716D0-0x0000000182071770 0x00000001820705E0-0x0000000182070680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Value { get => default; set {} } // 0x0000000182070F30-0x0000000182070FD0 0x0000000182071320-0x00000001820713C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Uint32Pair() {} // 0x0000000182071A30-0x0000000182071A90
	static Uint32Pair() {} // 0x0000000182071970-0x0000000182071A30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Uint32Pair Clone() => default; // 0x00000001820710C0-0x00000001820711B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Uint32Pair ShallowCopy() => default; // 0x0000000182070C10-0x0000000182070CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820707B0-0x0000000182070800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820712D0-0x0000000182071320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820713C0-0x0000000182071410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182070800-0x0000000182070870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182070870-0x0000000182070940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Uint32Pair other) => default; // 0x0000000182070940-0x0000000182070A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182070DA0-0x0000000182070EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182071770-0x0000000182071970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182071470-0x0000000182071590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182070A60-0x0000000182070B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Uint32Pair other) {} // 0x0000000182070680-0x00000001820707B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182070480-0x0000000182070580
}

