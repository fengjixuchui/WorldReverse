/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MsgParam : MessageBase, IMessage<MsgParam> // TypeDefIndex: 23960
{
	// Fields
	private static readonly MessageParser<MsgParam> _parser; // 0x00
	public const int IntParamFieldNumber = 1; // Metadata: 0x00B053B7
	public const int FltParamFieldNumber = 2; // Metadata: 0x00B053BB
	public const int StrParamFieldNumber = 3; // Metadata: 0x00B053BF
	private object param_; // 0x18
	private ParamOneofCase paramCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MsgParam> Parser { get => default; } // 0x000000018250BA40-0x000000018250BAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018250B690-0x000000018250B720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018250B1D0-0x000000018250B250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018250AA50-0x000000018250AAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018250C010-0x000000018250C100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018250BD80-0x000000018250BDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018250B780-0x000000018250B870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018250BFC0-0x000000018250C010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018250B3A0-0x000000018250B490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint IntParam { get => default; set {} } // 0x000000018250B5C0-0x000000018250B690 0x000000018250B250-0x000000018250B300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FltParam { get => default; set {} } // 0x000000018250B960-0x000000018250BA40 0x000000018250BC70-0x000000018250BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string StrParam { get => default; set {} } // 0x000000018250B100-0x000000018250B1D0 0x000000018250BBB0-0x000000018250BC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ParamOneofCase ParamCase { get => default; } // 0x000000018250B720-0x000000018250B780 

	// Nested types
	public enum ParamOneofCase // TypeDefIndex: 23961
	{
		None = 0,
		IntParam = 1,
		FltParam = 2,
		StrParam = 3
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MsgParam() {} // 0x000000018250C470-0x000000018250C4E0
	static MsgParam() {} // 0x000000018250C3B0-0x000000018250C470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MsgParam Clone() => default; // 0x000000018250B870-0x000000018250B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MsgParam ShallowCopy() => default; // 0x000000018250B300-0x000000018250B3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018250ACB0-0x000000018250AD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018250BB60-0x000000018250BBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018250BD30-0x000000018250BD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018250AD00-0x000000018250AD60
	public void resetParam() {} // 0x000000018250BF30-0x000000018250BFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearParam() {} // 0x000000018250AC50-0x000000018250ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018250AF00-0x000000018250AFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MsgParam other) => default; // 0x000000018250AD60-0x000000018250AF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018250B490-0x000000018250B5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018250C100-0x000000018250C3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018250BDE0-0x000000018250BF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018250AFD0-0x000000018250B100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MsgParam other) {} // 0x000000018250AAB0-0x000000018250AC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018250A940-0x000000018250AA50
}

