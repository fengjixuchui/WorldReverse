/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayInfo : MessageBase, IMessage<GadgetPlayInfo> // TypeDefIndex: 26034
{
	// Fields
	private static readonly MessageParser<GadgetPlayInfo> _parser; // 0x00
	public const int PlayTypeFieldNumber = 1; // Metadata: 0x00B0AC9B
	private uint playType_; // 0x18
	public const int DurationFieldNumber = 2; // Metadata: 0x00B0AC9F
	private uint duration_; // 0x1C
	public const int ProgressStageListFieldNumber = 3; // Metadata: 0x00B0ACA3
	private static readonly FieldCodec<uint> _repeated_progressStageList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> progressStageList_; // 0x20
	public const int StartCdFieldNumber = 4; // Metadata: 0x00B0ACA7
	private uint startCd_; // 0x28
	public const int StartTimeFieldNumber = 5; // Metadata: 0x00B0ACAB
	private uint startTime_; // 0x2C
	public const int ProgressFieldNumber = 6; // Metadata: 0x00B0ACAF
	private uint progress_; // 0x30
	public const int CrucibleInfoFieldNumber = 21; // Metadata: 0x00B0ACB3
	private object playInfo_; // 0x38
	private PlayInfoOneofCase playInfoCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayInfo> Parser { get => default; } // 0x0000000182CDBA00-0x0000000182CDBA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182CDB5B0-0x0000000182CDB640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182CDB110-0x0000000182CDB190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182CDA3E0-0x0000000182CDA440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182CDC1F0-0x0000000182CDC2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182CDBE20-0x0000000182CDBE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182CDB820-0x0000000182CDB910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182CDC1A0-0x0000000182CDC1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182CDB2D0-0x0000000182CDB3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000182CDBE80-0x0000000182CDBF20 0x0000000182CDA9C0-0x0000000182CDAA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Duration { get => default; set {} } // 0x0000000182CDC3B0-0x0000000182CDC450 0x0000000182CDA440-0x0000000182CDA4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ProgressStageList { get => default; } // 0x0000000182CDA960-0x0000000182CDA9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartCd { get => default; set {} } // 0x0000000182CDAA60-0x0000000182CDAB00 0x0000000182CDB640-0x0000000182CDB6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000182CDC450-0x0000000182CDC4F0 0x0000000182CDB780-0x0000000182CDB820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x0000000182CDB6E0-0x0000000182CDB780 0x0000000182CDB230-0x0000000182CDB2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetCrucibleInfo CrucibleInfo { get => default; set {} } // 0x0000000182CDC2E0-0x0000000182CDC3B0 0x0000000182CDB070-0x0000000182CDB110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayInfoOneofCase PlayInfoCase { get => default; } // 0x0000000182CDBA90-0x0000000182CDBAF0 

	// Nested types
	public enum PlayInfoOneofCase // TypeDefIndex: 26035
	{
		None = 0,
		CrucibleInfo = 21
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayInfo() {} // 0x0000000182CDCB20-0x0000000182CDCBC0
	static GadgetPlayInfo() {} // 0x0000000182CDCA40-0x0000000182CDCB20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayInfo Clone() => default; // 0x0000000182CDB910-0x0000000182CDBA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayInfo ShallowCopy() => default; // 0x0000000182CDB190-0x0000000182CDB230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182CDA790-0x0000000182CDA850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CDBCA0-0x0000000182CDBD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CDBD60-0x0000000182CDBE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182CDA850-0x0000000182CDA960
	public void resetPlayInfo() {} // 0x0000000182CDBB80-0x0000000182CDBCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearPlayInfo() {} // 0x0000000182CDA730-0x0000000182CDA790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182CDACF0-0x0000000182CDADC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayInfo other) => default; // 0x0000000182CDAB00-0x0000000182CDACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182CDB3C0-0x0000000182CDB5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182CDC4F0-0x0000000182CDCA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182CDBF20-0x0000000182CDC1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182CDADC0-0x0000000182CDB070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayInfo other) {} // 0x0000000182CDA4E0-0x0000000182CDA730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182CDA160-0x0000000182CDA3E0
}

