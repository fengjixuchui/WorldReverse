/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Duration : MessageBase, IMessage<Duration>, ICustomDiagnosticMessage // TypeDefIndex: 26440
{
	// Fields
	private static readonly MessageParser<Duration> _parser; // 0x00
	public const int SecondsFieldNumber = 1; // Metadata: 0x00B0C1BC
	private long seconds_; // 0x18
	public const int NanosFieldNumber = 2; // Metadata: 0x00B0C1C0
	private int nanos_; // 0x20
	public const int NanosecondsPerSecond = 1000000000; // Metadata: 0x00B0C1C4
	public const int NanosecondsPerTick = 100; // Metadata: 0x00B0C1C8
	public const long MaxSeconds = 315576000000; // Metadata: 0x00B0C1CC
	public const long MinSeconds = -315576000000; // Metadata: 0x00B0C1D4
	internal const int MaxNanoseconds = 999999999; // Metadata: 0x00B0C1DC
	internal const int MinNanoseconds = -999999999; // Metadata: 0x00B0C1E0

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Duration> Parser { /* [XID] */ /* 0x00000001898BC920-0x00000001898BC940 */ get => default; } // 0x00000001853BEFB0-0x00000001853BF080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898C3F40-0x00000001898C3F60 */ get => default; } // 0x00000001853BEA40-0x00000001853BEB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898CB700-0x00000001898CB720 */ get => default; } // 0x00000001853BE460-0x00000001853BE530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001898D2E30-0x00000001898D2E50 */ get => default; } // 0x00000001853BD180-0x00000001853BD220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001898DA780-0x00000001898DA7A0 */ get => default; } // 0x00000001853BF890-0x00000001853BF990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001898E2540-0x00000001898E2560 */ get => default; } // 0x00000001853BF270-0x00000001853BF310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001898EA060-0x00000001898EA080 */ get => default; } // 0x00000001853BED80-0x00000001853BEE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001898F1840-0x00000001898F1860 */ get => default; } // 0x00000001853BF610-0x00000001853BF6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001898F8FC0-0x00000001898F8FE0 */ get => default; } // 0x00000001853BE6F0-0x00000001853BE7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Seconds { /* [XID] */ /* 0x000000018993F7F0-0x000000018993F810 */ get => default; /* [XID] */ /* 0x0000000189946E20-0x0000000189946E40 */ set {} } // 0x00000001853BF6B0-0x00000001853BF790 0x00000001853BE200-0x00000001853BE2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Nanos { /* [XID] */ /* 0x000000018994E4B0-0x000000018994E4D0 */ get => default; /* [XID] */ /* 0x0000000189955B20-0x0000000189955B40 */ set {} } // 0x00000001853BDB20-0x00000001853BDC00 0x00000001853BE610-0x00000001853BE6F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Duration() {} // 0x00000001853BFC90-0x00000001853BFCF0
	static Duration() {} // 0x00000001853BFBD0-0x00000001853BFC90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189900900-0x0000000189900940
	// [XID] // 0x0000000189900900-0x0000000189900940
	public Duration Clone() => default; // 0x00000001853BEE80-0x00000001853BEFB0
	[DebuggerNonUserCode] // 0x000000018990AE00-0x000000018990AE40
	// [XID] // 0x000000018990AE00-0x000000018990AE40
	public Duration ShallowCopy() => default; // 0x00000001853BE530-0x00000001853BE610
	[DebuggerNonUserCode] // 0x0000000189915790-0x00000001899157D0
	// [XID] // 0x0000000189915790-0x00000001899157D0
	protected override void InternalSetInPool(bool value) {} // 0x00000001853BD7B0-0x00000001853BD860
	[DebuggerNonUserCode] // 0x0000000189920020-0x0000000189920060
	// [XID] // 0x0000000189920020-0x0000000189920060
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BF110-0x00000001853BF1C0
	[DebuggerNonUserCode] // 0x000000018992A910-0x000000018992A950
	// [XID] // 0x000000018992A910-0x000000018992A950
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BF1C0-0x00000001853BF270
	[DebuggerNonUserCode] // 0x0000000189934E30-0x0000000189934E70
	// [XID] // 0x0000000189934E30-0x0000000189934E70
	public override void Reset() {} // 0x00000001853BDA00-0x00000001853BDAB0
	[DebuggerNonUserCode] // 0x000000018995D540-0x000000018995D590
	// [IDTag] // 0x000000018995D540-0x000000018995D590
	// [XID] // 0x000000018995D540-0x000000018995D590
	public override bool Equals(object other) => default; // 0x00000001853BDC00-0x00000001853BDD10
	[DebuggerNonUserCode] // 0x000000018996A9A0-0x000000018996A9F0
	// [IDTag] // 0x000000018996A9A0-0x000000018996A9F0
	// [XID] // 0x000000018996A9A0-0x000000018996A9F0
	public bool Equals(Duration other) => default; // 0x00000001853BDD10-0x00000001853BDE80
	[DebuggerNonUserCode] // 0x00000001899788E0-0x0000000189978920
	// [XID] // 0x00000001899788E0-0x0000000189978920
	public override int GetHashCode() => default; // 0x00000001853BE7F0-0x00000001853BE940
	[DebuggerNonUserCode] // 0x0000000189982EC0-0x0000000189982F00
	// [XID] // 0x0000000189982EC0-0x0000000189982F00
	public override string ToString() => default; // 0x00000001853BF990-0x00000001853BFBD0
	[DebuggerNonUserCode] // 0x000000018998D690-0x000000018998D6D0
	// [XID] // 0x000000018998D690-0x000000018998D6D0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001853BF4B0-0x00000001853BF610
	[DebuggerNonUserCode] // 0x00000001899981D0-0x0000000189998210
	// [XID] // 0x00000001899981D0-0x0000000189998210
	public override int CalculateSize() => default; // 0x00000001853BDE80-0x00000001853BE000
	[DebuggerNonUserCode] // 0x00000001899A2B40-0x00000001899A2B80
	// [XID] // 0x00000001899A2B40-0x00000001899A2B80
	public void CopyFrom(Duration other) {} // 0x00000001853BD290-0x00000001853BD410
	[DebuggerNonUserCode] // 0x00000001899AD4F0-0x00000001899AD530
	// [XID] // 0x00000001899AD4F0-0x00000001899AD530
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001853BCC10-0x00000001853BCD50
	// [XID] // 0x00000001899B7AE0-0x00000001899B7B00
	internal static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x00000001853BF790-0x00000001853BF890
	// [XID] // 0x00000001899BF560-0x00000001899BF580
	public TimeSpan ToTimeSpan() => default; // 0x00000001853BCD50-0x00000001853BCF80
	// [XID] // 0x00000001899C6E70-0x00000001899C6E90
	public static Duration FromTimeSpan(TimeSpan timeSpan) => default; // 0x00000001853BF310-0x00000001853BF4B0
	// [XID] // 0x00000001899CE380-0x00000001899CE3A0
	public static Duration operator -(Duration value) => default; // 0x00000001853BD860-0x00000001853BDA00
	// [XID] // 0x00000001899D5B20-0x00000001899D5B40
	public static Duration operator +(Duration lhs, Duration rhs) => default; // 0x00000001853BCF80-0x00000001853BD180
	// [XID] // 0x00000001899DCF10-0x00000001899DCF30
	public static Duration operator -(Duration lhs, Duration rhs) => default; // 0x00000001853BE000-0x00000001853BE200
	// [XID] // 0x00000001899E4A70-0x00000001899E4A90
	internal static Duration Normalize(long seconds, int nanoseconds) => default; // 0x00000001853BE2E0-0x00000001853BE460
	// [XID] // 0x00000001899EBFC0-0x00000001899EBFE0
	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x00000001853BD410-0x00000001853BD7B0
	// [XID] // 0x00000001899F39B0-0x00000001899F39D0
	public string ToDiagnosticString() => default; // 0x00000001853BE940-0x00000001853BEA40
	// [XID] // 0x00000001899FB2C0-0x00000001899FB2E0
	internal static void AppendNanoseconds(StringBuilder builder, int nanos) {} // 0x00000001853BEBB0-0x00000001853BED80
}

