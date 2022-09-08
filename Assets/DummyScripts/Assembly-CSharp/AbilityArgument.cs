/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityArgument : MessageBase, IMessage<AbilityArgument> // TypeDefIndex: 22998
{
	// Fields
	private static readonly MessageParser<AbilityArgument> _parser; // 0x00
	public const int IntArgFieldNumber = 1; // Metadata: 0x00B02E57
	public const int FloatArgFieldNumber = 2; // Metadata: 0x00B02E5B
	public const int StrArgFieldNumber = 3; // Metadata: 0x00B02E5F
	private object arg_; // 0x18
	private ArgOneofCase argCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityArgument> Parser { get => default; } // 0x00000001827BD4A0-0x00000001827BD530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827BD1D0-0x00000001827BD260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827BCDE0-0x00000001827BCE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827BC4E0-0x00000001827BC540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827BDAA0-0x00000001827BDB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827BD8A0-0x00000001827BD900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827BD260-0x00000001827BD350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827BDA50-0x00000001827BDAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827BCF00-0x00000001827BCFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint IntArg { get => default; set {} } // 0x00000001827BCD10-0x00000001827BCDE0 0x00000001827BD120-0x00000001827BD1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FloatArg { get => default; set {} } // 0x00000001827BD530-0x00000001827BD610 0x00000001827BC540-0x00000001827BC600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string StrArg { get => default; set {} } // 0x00000001827BD6F0-0x00000001827BD7C0 0x00000001827BC7A0-0x00000001827BC860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArgOneofCase ArgCase { get => default; } // 0x00000001827BC910-0x00000001827BC970 

	// Nested types
	public enum ArgOneofCase // TypeDefIndex: 22999
	{
		None = 0,
		IntArg = 1,
		FloatArg = 2,
		StrArg = 3
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityArgument() {} // 0x00000001827BDF00-0x00000001827BDF70
	static AbilityArgument() {} // 0x00000001827BDE40-0x00000001827BDF00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityArgument Clone() => default; // 0x00000001827BD350-0x00000001827BD440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityArgument ShallowCopy() => default; // 0x00000001827BCE60-0x00000001827BCF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827BC860-0x00000001827BC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827BD6A0-0x00000001827BD6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827BD7C0-0x00000001827BD810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827BC8B0-0x00000001827BC910
	public void resetArg() {} // 0x00000001827BD810-0x00000001827BD8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearArg() {} // 0x00000001827BD440-0x00000001827BD4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827BC970-0x00000001827BCA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityArgument other) => default; // 0x00000001827BCA40-0x00000001827BCBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827BCFF0-0x00000001827BD120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827BDB90-0x00000001827BDE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827BD900-0x00000001827BDA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827BCBE0-0x00000001827BCD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityArgument other) {} // 0x00000001827BC600-0x00000001827BC7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827BC3D0-0x00000001827BC4E0
}

