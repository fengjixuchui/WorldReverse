/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterLittleDetailInfo : MessageBase, IMessage<AsterLittleDetailInfo> // TypeDefIndex: 21998
{
	// Fields
	private static readonly MessageParser<AsterLittleDetailInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B0088B
	private bool isOpen_; // 0x18
	public const int StageIdFieldNumber = 2; // Metadata: 0x00B0088F
	private uint stageId_; // 0x1C
	public const int StageStateFieldNumber = 3; // Metadata: 0x00B00893
	private AsterLittleStageState stageState_; // 0x20
	public const int BeginTimeFieldNumber = 4; // Metadata: 0x00B00897
	private uint beginTime_; // 0x24
	public const int StageBeginTimeFieldNumber = 5; // Metadata: 0x00B0089B
	private uint stageBeginTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterLittleDetailInfo> Parser { get => default; } // 0x0000000182C0E390-0x0000000182C0E420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C0E120-0x0000000182C0E1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C0DBF0-0x0000000182C0DC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C0D2F0-0x0000000182C0D350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C0EB00-0x0000000182C0EBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C0E690-0x0000000182C0E6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C0E1B0-0x0000000182C0E2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C0EAB0-0x0000000182C0EB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C0DDB0-0x0000000182C0DEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000182C0E6F0-0x0000000182C0E790 0x0000000182C0D350-0x0000000182C0D3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageId { get => default; set {} } // 0x0000000182C0E4B0-0x0000000182C0E550 0x0000000182C0E080-0x0000000182C0E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleStageState StageState { get => default; set {} } // 0x0000000182C0DB50-0x0000000182C0DBF0 0x0000000182C0EA10-0x0000000182C0EAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000182C0E970-0x0000000182C0EA10 0x0000000182C0E5F0-0x0000000182C0E690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageBeginTime { get => default; set {} } // 0x0000000182C0D690-0x0000000182C0D730 0x0000000182C0DD10-0x0000000182C0DDB0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleDetailInfo() {} // 0x0000000182C0F050-0x0000000182C0F0C0
	static AsterLittleDetailInfo() {} // 0x0000000182C0EF90-0x0000000182C0F050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleDetailInfo Clone() => default; // 0x0000000182C0E2A0-0x0000000182C0E390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleDetailInfo ShallowCopy() => default; // 0x0000000182C0DC70-0x0000000182C0DD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C0D5A0-0x0000000182C0D5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C0E550-0x0000000182C0E5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C0E5A0-0x0000000182C0E5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C0D5F0-0x0000000182C0D690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C0D8A0-0x0000000182C0D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterLittleDetailInfo other) => default; // 0x0000000182C0D730-0x0000000182C0D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C0DEA0-0x0000000182C0E080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C0EBF0-0x0000000182C0EF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C0E790-0x0000000182C0E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C0D970-0x0000000182C0DB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterLittleDetailInfo other) {} // 0x0000000182C0D3F0-0x0000000182C0D5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C0D1A0-0x0000000182C0D2F0
}

