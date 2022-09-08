/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestTransmitRsp : MessageBase, IMessage<QuestTransmitRsp> // TypeDefIndex: 24664
{
	// Fields
	private static readonly MessageParser<QuestTransmitRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06F2F
	private int retcode_; // 0x18
	public const int QuestIdFieldNumber = 2; // Metadata: 0x00B06F33
	private uint questId_; // 0x1C
	public const int PointIdFieldNumber = 3; // Metadata: 0x00B06F37
	private uint pointId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestTransmitRsp> Parser { get => default; } // 0x0000000183CCD860-0x0000000183CCD8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CCD550-0x0000000183CCD5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CCD210-0x0000000183CCD290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CCC970-0x0000000183CCC9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CCDC30-0x0000000183CCDD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CCDA20-0x0000000183CCDA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CCD680-0x0000000183CCD770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CCDBE0-0x0000000183CCDC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CCD330-0x0000000183CCD420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183CCD0D0-0x0000000183CCD170 0x0000000183CCCC00-0x0000000183CCCCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000183CCC8D0-0x0000000183CCC970 0x0000000183CCD170-0x0000000183CCD210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000183CCD5E0-0x0000000183CCD680 0x0000000183CCCCA0-0x0000000183CCCD40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24665
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24666
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 434
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestTransmitRsp() {} // 0x0000000183CCE070-0x0000000183CCE0D0
	static QuestTransmitRsp() {} // 0x0000000183CCDFB0-0x0000000183CCE070

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestTransmitRsp Clone() => default; // 0x0000000183CCD770-0x0000000183CCD860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestTransmitRsp ShallowCopy() => default; // 0x0000000183CCD290-0x0000000183CCD330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CCCB30-0x0000000183CCCB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CCD980-0x0000000183CCD9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CCD9D0-0x0000000183CCDA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CCCB80-0x0000000183CCCC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CCCD40-0x0000000183CCCE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestTransmitRsp other) => default; // 0x0000000183CCCE10-0x0000000183CCCF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CCD420-0x0000000183CCD550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CCDD20-0x0000000183CCDFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CCDA80-0x0000000183CCDBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CCCF50-0x0000000183CCD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestTransmitRsp other) {} // 0x0000000183CCC9D0-0x0000000183CCCB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CCC7C0-0x0000000183CCC8D0
}

