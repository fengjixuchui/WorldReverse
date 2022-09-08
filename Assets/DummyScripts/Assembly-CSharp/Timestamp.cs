/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Timestamp : MessageBase, IMessage<Timestamp>, ICustomDiagnosticMessage // TypeDefIndex: 26455
{
	// Fields
	private static readonly MessageParser<Timestamp> _parser; // 0x00
	public const int SecondsFieldNumber = 1; // Metadata: 0x00B0C22C
	private long seconds_; // 0x18
	public const int NanosFieldNumber = 2; // Metadata: 0x00B0C230
	private int nanos_; // 0x20
	private static readonly DateTime UnixEpoch; // 0x08
	private const long BclSecondsAtUnixEpoch = 62135596800; // Metadata: 0x00B0C234
	internal const long UnixSecondsAtBclMaxValue = 253402300799; // Metadata: 0x00B0C23C
	internal const long UnixSecondsAtBclMinValue = -62135596800; // Metadata: 0x00B0C244
	internal const int MaxNanos = 999999999; // Metadata: 0x00B0C24C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Timestamp> Parser { /* [XID] */ /* 0x0000000189729580-0x00000001897295A0 */ get => default; } // 0x00000001830CEA40-0x00000001830CEB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189730DD0-0x0000000189730DF0 */ get => default; } // 0x00000001830CE380-0x00000001830CE470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001897386A0-0x00000001897386C0 */ get => default; } // 0x00000001830CDDA0-0x00000001830CDE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189740420-0x0000000189740440 */ get => default; } // 0x00000001830CCA40-0x00000001830CCAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897477A0-0x00000001897477C0 */ get => default; } // 0x00000001830CF490-0x00000001830CF590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018974EF10-0x000000018974EF30 */ get => default; } // 0x00000001830CEE70-0x00000001830CEF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897565A0-0x00000001897565C0 */ get => default; } // 0x00000001830CE600-0x00000001830CE700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018975DA20-0x000000018975DA40 */ get => default; } // 0x00000001830CF230-0x00000001830CF2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001897650B0-0x00000001897650D0 */ get => default; } // 0x00000001830CE030-0x00000001830CE130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Seconds { /* [XID] */ /* 0x00000001897AB820-0x00000001897AB840 */ get => default; /* [XID] */ /* 0x00000001897B3730-0x00000001897B3750 */ set {} } // 0x00000001830CF2D0-0x00000001830CF3B0 0x00000001830CDB60-0x00000001830CDC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Nanos { /* [XID] */ /* 0x00000001897BB5B0-0x00000001897BB5D0 */ get => default; /* [XID] */ /* 0x00000001897C2DE0-0x00000001897C2E00 */ set {} } // 0x00000001830CD280-0x00000001830CD360 0x00000001830CDF50-0x00000001830CE030

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Timestamp() {} // 0x00000001830CF8F0-0x00000001830CF950
	static Timestamp() {} // 0x00000001830CF7D0-0x00000001830CF8F0

	// Methods
	[DebuggerNonUserCode] // 0x000000018976CB00-0x000000018976CB40
	// [XID] // 0x000000018976CB00-0x000000018976CB40
	public Timestamp Clone() => default; // 0x00000001830CE700-0x00000001830CE830
	[DebuggerNonUserCode] // 0x00000001897770A0-0x00000001897770E0
	// [XID] // 0x00000001897770A0-0x00000001897770E0
	public Timestamp ShallowCopy() => default; // 0x00000001830CDE70-0x00000001830CDF50
	[DebuggerNonUserCode] // 0x0000000189781BF0-0x0000000189781C30
	// [XID] // 0x0000000189781BF0-0x0000000189781C30
	protected override void InternalSetInPool(bool value) {} // 0x00000001830CD0B0-0x00000001830CD160
	[DebuggerNonUserCode] // 0x000000018978C040-0x000000018978C080
	// [XID] // 0x000000018978C040-0x000000018978C080
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830CED10-0x00000001830CEDC0
	[DebuggerNonUserCode] // 0x00000001897966D0-0x0000000189796710
	// [XID] // 0x00000001897966D0-0x0000000189796710
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830CEDC0-0x00000001830CEE70
	[DebuggerNonUserCode] // 0x00000001897A1370-0x00000001897A13B0
	// [XID] // 0x00000001897A1370-0x00000001897A13B0
	public override void Reset() {} // 0x00000001830CD160-0x00000001830CD210
	[DebuggerNonUserCode] // 0x00000001897CA610-0x00000001897CA660
	// [IDTag] // 0x00000001897CA610-0x00000001897CA660
	// [XID] // 0x00000001897CA610-0x00000001897CA660
	public override bool Equals(object other) => default; // 0x00000001830CD4D0-0x00000001830CD5E0
	[DebuggerNonUserCode] // 0x00000001897D83A0-0x00000001897D83F0
	// [IDTag] // 0x00000001897D83A0-0x00000001897D83F0
	// [XID] // 0x00000001897D83A0-0x00000001897D83F0
	public bool Equals(Timestamp other) => default; // 0x00000001830CD360-0x00000001830CD4D0
	[DebuggerNonUserCode] // 0x00000001897E56F0-0x00000001897E5730
	// [XID] // 0x00000001897E56F0-0x00000001897E5730
	public override int GetHashCode() => default; // 0x00000001830CE130-0x00000001830CE280
	[DebuggerNonUserCode] // 0x00000001897F0170-0x00000001897F01B0
	// [XID] // 0x00000001897F0170-0x00000001897F01B0
	public override string ToString() => default; // 0x00000001830CF590-0x00000001830CF7D0
	[DebuggerNonUserCode] // 0x00000001897FACA0-0x00000001897FACE0
	// [XID] // 0x00000001897FACA0-0x00000001897FACE0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830CEF10-0x00000001830CF070
	[DebuggerNonUserCode] // 0x0000000189804E70-0x0000000189804EB0
	// [XID] // 0x0000000189804E70-0x0000000189804EB0
	public override int CalculateSize() => default; // 0x00000001830CD5E0-0x00000001830CD760
	[DebuggerNonUserCode] // 0x000000018980F830-0x000000018980F870
	// [XID] // 0x000000018980F830-0x000000018980F870
	public void CopyFrom(Timestamp other) {} // 0x00000001830CCB50-0x00000001830CCCD0
	[DebuggerNonUserCode] // 0x000000018981A0D0-0x000000018981A110
	// [XID] // 0x000000018981A0D0-0x000000018981A110
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830CC700-0x00000001830CC840
	// [XID] // 0x00000001898243A0-0x00000001898243C0
	private static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x00000001830CF3B0-0x00000001830CF490
	// [IDTag] // 0x000000018982BEC0-0x000000018982BF00
	// [XID] // 0x000000018982BEC0-0x000000018982BF00
	public static Duration operator -(Timestamp lhs, Timestamp rhs) => default; // 0x00000001830CD760-0x00000001830CD960
	// [XID] // 0x0000000189836360-0x0000000189836380
	public static Timestamp operator +(Timestamp lhs, Duration rhs) => default; // 0x00000001830CC840-0x00000001830CCA40
	// [IDTag] // 0x000000018983D810-0x000000018983D850
	// [XID] // 0x000000018983D810-0x000000018983D850
	public static Timestamp operator -(Timestamp lhs, Duration rhs) => default; // 0x00000001830CD960-0x00000001830CDB60
	// [XID] // 0x0000000189847C50-0x0000000189847C70
	public DateTime ToDateTime() => default; // 0x00000001830CE830-0x00000001830CEA40
	// [XID] // 0x000000018984F480-0x000000018984F4A0
	public DateTimeOffset ToDateTimeOffset() => default; // 0x00000001830CEBA0-0x00000001830CED10
	// [XID] // 0x0000000189856600-0x0000000189856620
	public static Timestamp FromDateTime(DateTime dateTime) => default; // 0x00000001830CF070-0x00000001830CF230
	// [XID] // 0x000000018985D910-0x000000018985D930
	public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) => default; // 0x00000001830CE4F0-0x00000001830CE600
	// [XID] // 0x0000000189865290-0x00000001898652B0
	internal static Timestamp Normalize(long seconds, int nanoseconds) => default; // 0x00000001830CDC40-0x00000001830CDDA0
	// [XID] // 0x000000018986C7E0-0x000000018986C800
	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x00000001830CCCD0-0x00000001830CD0B0
	// [XID] // 0x0000000189873C10-0x0000000189873C30
	public string ToDiagnosticString() => default; // 0x00000001830CE280-0x00000001830CE380
}

