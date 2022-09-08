/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Option : MessageBase, IMessage<Option> // TypeDefIndex: 26465
{
	// Fields
	private static readonly MessageParser<Option> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C314
	private string name_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B0C318
	private Any value_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Option> Parser { /* [XID] */ /* 0x0000000189A54060-0x0000000189A54080 */ get => default; } // 0x0000000182E23370-0x0000000182E23440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A5BA70-0x0000000189A5BA90 */ get => default; } // 0x0000000182E22EF0-0x0000000182E22FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A63140-0x0000000189A63160 */ get => default; } // 0x0000000182E22AD0-0x0000000182E22BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A6ACC0-0x0000000189A6ACE0 */ get => default; } // 0x0000000182E21F70-0x0000000182E22010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A72320-0x0000000189A72340 */ get => default; } // 0x0000000182E239E0-0x0000000182E23AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A79FE0-0x0000000189A7A000 */ get => default; } // 0x0000000182E23730-0x0000000182E237D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A81480-0x0000000189A814A0 */ get => default; } // 0x0000000182E23140-0x0000000182E23240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A88EA0-0x0000000189A88EC0 */ get => default; } // 0x0000000182E23940-0x0000000182E239E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A90670-0x0000000189A90690 */ get => default; } // 0x0000000182E22C80-0x0000000182E22D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189AD7270-0x0000000189AD7290 */ get => default; /* [XID] */ /* 0x0000000189ADED10-0x0000000189ADED30 */ set {} } // 0x0000000182E229F0-0x0000000182E22AD0 0x0000000182E224A0-0x0000000182E22590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Any Value { /* [XID] */ /* 0x0000000189AE6660-0x0000000189AE6680 */ get => default; /* [XID] */ /* 0x0000000189AEDED0-0x0000000189AEDEF0 */ set {} } // 0x0000000182E23060-0x0000000182E23140 0x0000000182E23590-0x0000000182E23670

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Option() {} // 0x0000000182E23DA0-0x0000000182E23E10
	static Option() {} // 0x0000000182E23CE0-0x0000000182E23DA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A97E60-0x0000000189A97EA0
	// [XID] // 0x0000000189A97E60-0x0000000189A97EA0
	public Option Clone() => default; // 0x0000000182E23240-0x0000000182E23370
	[DebuggerNonUserCode] // 0x0000000189AA21B0-0x0000000189AA21F0
	// [XID] // 0x0000000189AA21B0-0x0000000189AA21F0
	public Option ShallowCopy() => default; // 0x0000000182E22BA0-0x0000000182E22C80
	[DebuggerNonUserCode] // 0x0000000189AACB40-0x0000000189AACB80
	// [XID] // 0x0000000189AACB40-0x0000000189AACB80
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E22270-0x0000000182E22330
	[DebuggerNonUserCode] // 0x0000000189AB72B0-0x0000000189AB72F0
	// [XID] // 0x0000000189AB72B0-0x0000000189AB72F0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E234D0-0x0000000182E23590
	[DebuggerNonUserCode] // 0x0000000189AC1F40-0x0000000189AC1F80
	// [XID] // 0x0000000189AC1F40-0x0000000189AC1F80
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E23670-0x0000000182E23730
	[DebuggerNonUserCode] // 0x0000000189ACC500-0x0000000189ACC540
	// [XID] // 0x0000000189ACC500-0x0000000189ACC540
	public override void Reset() {} // 0x0000000182E22330-0x0000000182E22430
	[DebuggerNonUserCode] // 0x0000000189AF5680-0x0000000189AF56D0
	// [IDTag] // 0x0000000189AF5680-0x0000000189AF56D0
	// [XID] // 0x0000000189AF5680-0x0000000189AF56D0
	public override bool Equals(object other) => default; // 0x0000000182E22750-0x0000000182E22860
	[DebuggerNonUserCode] // 0x0000000189B02D20-0x0000000189B02D70
	// [IDTag] // 0x0000000189B02D20-0x0000000189B02D70
	// [XID] // 0x0000000189B02D20-0x0000000189B02D70
	public bool Equals(Option other) => default; // 0x0000000182E22590-0x0000000182E22750
	[DebuggerNonUserCode] // 0x0000000189B10540-0x0000000189B10580
	// [XID] // 0x0000000189B10540-0x0000000189B10580
	public override int GetHashCode() => default; // 0x0000000182E22D80-0x0000000182E22EF0
	[DebuggerNonUserCode] // 0x0000000189B1A870-0x0000000189B1A8B0
	// [XID] // 0x0000000189B1A870-0x0000000189B1A8B0
	public override string ToString() => default; // 0x0000000182E23AE0-0x0000000182E23CE0
	[DebuggerNonUserCode] // 0x0000000189B24EC0-0x0000000189B24F00
	// [XID] // 0x0000000189B24EC0-0x0000000189B24F00
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E237D0-0x0000000182E23940
	[DebuggerNonUserCode] // 0x0000000189B2EFB0-0x0000000189B2EFF0
	// [XID] // 0x0000000189B2EFB0-0x0000000189B2EFF0
	public override int CalculateSize() => default; // 0x0000000182E22860-0x0000000182E229F0
	[DebuggerNonUserCode] // 0x0000000189B39950-0x0000000189B39990
	// [XID] // 0x0000000189B39950-0x0000000189B39990
	public void CopyFrom(Option other) {} // 0x0000000182E22080-0x0000000182E22270
	[DebuggerNonUserCode] // 0x0000000189B44510-0x0000000189B44550
	// [XID] // 0x0000000189B44510-0x0000000189B44550
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E21DE0-0x0000000182E21F70
}

