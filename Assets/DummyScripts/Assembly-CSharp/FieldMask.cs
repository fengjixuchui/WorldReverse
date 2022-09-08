/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FieldMask : MessageBase, IMessage<FieldMask>, ICustomDiagnosticMessage // TypeDefIndex: 26444
{
	// Fields
	private static readonly MessageParser<FieldMask> _parser; // 0x00
	public const int PathsFieldNumber = 1; // Metadata: 0x00B0C1E4
	private static readonly FieldCodec<string> _repeated_paths_codec; // 0x08
	private readonly RepeatedPrimitiveField<string> paths_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FieldMask> Parser { /* [XID] */ /* 0x0000000189BAEE90-0x0000000189BAEEB0 */ get => default; } // 0x00000001835163F0-0x00000001835164C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BB6560-0x0000000189BB6580 */ get => default; } // 0x0000000183515E90-0x0000000183515F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BBDBE0-0x0000000189BBDC00 */ get => default; } // 0x0000000183515970-0x0000000183515A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BC58E0-0x0000000189BC5900 */ get => default; } // 0x0000000183514C90-0x0000000183514D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BCD380-0x0000000189BCD3A0 */ get => default; } // 0x00000001835168A0-0x00000001835169A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BD4880-0x0000000189BD48A0 */ get => default; } // 0x0000000183516620-0x00000001835166C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189BDC3B0-0x0000000189BDC3D0 */ get => default; } // 0x0000000183516000-0x0000000183516100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895E8C10-0x00000001895E8C30 */ get => default; } // 0x0000000183516800-0x00000001835168A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001895F04A0-0x00000001895F04C0 */ get => default; } // 0x0000000183515B20-0x0000000183515C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> Paths { /* [XID] */ /* 0x0000000189636C90-0x0000000189636CB0 */ get => default; } // 0x0000000183516350-0x00000001835163F0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FieldMask() {} // 0x0000000183516C10-0x0000000183516CA0
	static FieldMask() {} // 0x0000000183516B30-0x0000000183516C10

	// Methods
	[DebuggerNonUserCode] // 0x00000001895F7EF0-0x00000001895F7F30
	// [XID] // 0x00000001895F7EF0-0x00000001895F7F30
	public FieldMask Clone() => default; // 0x0000000183516100-0x0000000183516230
	[DebuggerNonUserCode] // 0x0000000189602470-0x00000001896024B0
	// [XID] // 0x0000000189602470-0x00000001896024B0
	public FieldMask ShallowCopy() => default; // 0x0000000183515A40-0x0000000183515B20
	[DebuggerNonUserCode] // 0x000000018960CB70-0x000000018960CBB0
	// [XID] // 0x000000018960CB70-0x000000018960CBB0
	protected override void InternalSetInPool(bool value) {} // 0x0000000183515400-0x00000001835154B0
	[DebuggerNonUserCode] // 0x00000001896170E0-0x0000000189617120
	// [XID] // 0x00000001896170E0-0x0000000189617120
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835164C0-0x0000000183516570
	[DebuggerNonUserCode] // 0x0000000189621910-0x0000000189621950
	// [XID] // 0x0000000189621910-0x0000000189621950
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183516570-0x0000000183516620
	[DebuggerNonUserCode] // 0x000000018962BF30-0x000000018962BF70
	// [XID] // 0x000000018962BF30-0x000000018962BF70
	public override void Reset() {} // 0x00000001835154B0-0x0000000183515570
	[DebuggerNonUserCode] // 0x000000018963E1E0-0x000000018963E230
	// [IDTag] // 0x000000018963E1E0-0x000000018963E230
	// [XID] // 0x000000018963E1E0-0x000000018963E230
	public override bool Equals(object other) => default; // 0x0000000183515730-0x0000000183515840
	[DebuggerNonUserCode] // 0x000000018964BA70-0x000000018964BAC0
	// [IDTag] // 0x000000018964BA70-0x000000018964BAC0
	// [XID] // 0x000000018964BA70-0x000000018964BAC0
	public bool Equals(FieldMask other) => default; // 0x00000001835155E0-0x0000000183515730
	[DebuggerNonUserCode] // 0x00000001896590D0-0x0000000189659110
	// [XID] // 0x00000001896590D0-0x0000000189659110
	public override int GetHashCode() => default; // 0x0000000183515C20-0x0000000183515D20
	[DebuggerNonUserCode] // 0x0000000189663830-0x0000000189663870
	// [XID] // 0x0000000189663830-0x0000000189663870
	public override string ToString() => default; // 0x00000001835169A0-0x0000000183516B30
	[DebuggerNonUserCode] // 0x000000018966DE80-0x000000018966DEC0
	// [XID] // 0x000000018966DE80-0x000000018966DEC0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835166C0-0x0000000183516800
	[DebuggerNonUserCode] // 0x0000000189678E60-0x0000000189678EA0
	// [XID] // 0x0000000189678E60-0x0000000189678EA0
	public override int CalculateSize() => default; // 0x0000000183515840-0x0000000183515970
	[DebuggerNonUserCode] // 0x0000000189683370-0x00000001896833B0
	// [XID] // 0x0000000189683370-0x00000001896833B0
	public void CopyFrom(FieldMask other) {} // 0x0000000183514E30-0x0000000183514F80
	[DebuggerNonUserCode] // 0x000000018968E190-0x000000018968E1D0
	// [XID] // 0x000000018968E190-0x000000018968E1D0
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183514B10-0x0000000183514C90
	// [XID] // 0x0000000189698B80-0x0000000189698BA0
	internal static string ToJson(IList<string> paths, bool diagnosticOnly) => default; // 0x0000000183514F80-0x0000000183515400
	// [XID] // 0x000000018969FFD0-0x000000018969FFF0
	private static bool ValidatePath(string input) => default; // 0x0000000183516230-0x0000000183516350
	// [XID] // 0x00000001896A7350-0x00000001896A7370
	public string ToDiagnosticString() => default; // 0x0000000183515DB0-0x0000000183515E90
}

