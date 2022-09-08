/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerRecordHandbookRsp : MessageBase, IMessage<TowerRecordHandbookRsp> // TypeDefIndex: 25763
{
	// Fields
	private static readonly MessageParser<TowerRecordHandbookRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0985F
	private int retcode_; // 0x18
	public const int MonthlyDetailListFieldNumber = 2; // Metadata: 0x00B09863
	private static readonly FieldCodec<TowerMonthlyDetail> _repeated_monthlyDetailList_codec; // 0x08
	private readonly RepeatedMessageField<TowerMonthlyDetail> monthlyDetailList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerRecordHandbookRsp> Parser { get => default; } // 0x0000000183162F90-0x0000000183163020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183162D20-0x0000000183162DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183162A10-0x0000000183162A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831622A0-0x0000000183162300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183163420-0x0000000183163510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183163230-0x0000000183163290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183162DB0-0x0000000183162EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831633D0-0x0000000183163420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183162B30-0x0000000183162C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183162970-0x0000000183162A10 0x0000000183162590-0x0000000183162630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerMonthlyDetail> MonthlyDetailList { get => default; } // 0x00000001831631D0-0x0000000183163230 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25764
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25765
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2434
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerRecordHandbookRsp() {} // 0x0000000183163800-0x00000001831638B0
	static TowerRecordHandbookRsp() {} // 0x00000001831636F0-0x0000000183163800

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerRecordHandbookRsp Clone() => default; // 0x0000000183162EA0-0x0000000183162F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerRecordHandbookRsp ShallowCopy() => default; // 0x0000000183162A90-0x0000000183162B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183162460-0x00000001831624B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831630B0-0x0000000183163140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183163140-0x00000001831631D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831624B0-0x0000000183162590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183162760-0x0000000183162830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerRecordHandbookRsp other) => default; // 0x0000000183162630-0x0000000183162760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183162C20-0x0000000183162D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183163510-0x00000001831636F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183163290-0x00000001831633D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183162830-0x0000000183162970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerRecordHandbookRsp other) {} // 0x0000000183162300-0x0000000183162460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183162140-0x00000001831622A0
}

