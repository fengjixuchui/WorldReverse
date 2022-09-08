/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorktopInfo : MessageBase, IMessage<WorktopInfo> // TypeDefIndex: 26017
{
	// Fields
	private static readonly MessageParser<WorktopInfo> _parser; // 0x00
	public const int OptionListFieldNumber = 1; // Metadata: 0x00B0AB87
	private static readonly FieldCodec<uint> _repeated_optionList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> optionList_; // 0x18
	public const int IsGuestCanOperateFieldNumber = 2; // Metadata: 0x00B0AB8B
	private bool isGuestCanOperate_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorktopInfo> Parser { get => default; } // 0x0000000183283E00-0x0000000183283E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183283B30-0x0000000183283BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183283830-0x00000001832838B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832831F0-0x0000000183283250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832841B0-0x00000001832842A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183283FC0-0x0000000183284020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183283BC0-0x0000000183283CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183284160-0x00000001832841B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183283950-0x0000000183283A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OptionList { get => default; } // 0x0000000183283CB0-0x0000000183283D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGuestCanOperate { get => default; set {} } // 0x0000000183282FE0-0x0000000183283080 0x00000001832833D0-0x0000000183283470

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorktopInfo() {} // 0x0000000183284560-0x00000001832845F0
	static WorktopInfo() {} // 0x0000000183284480-0x0000000183284560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorktopInfo Clone() => default; // 0x0000000183283D10-0x0000000183283E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorktopInfo ShallowCopy() => default; // 0x00000001832838B0-0x0000000183283950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183283380-0x00000001832833D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183283F20-0x0000000183283F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183283F70-0x0000000183283FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183283470-0x0000000183283540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183283540-0x0000000183283610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorktopInfo other) => default; // 0x0000000183283610-0x0000000183283730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183283A40-0x0000000183283B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832842A0-0x0000000183284480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183284020-0x0000000183284160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183283730-0x0000000183283830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorktopInfo other) {} // 0x0000000183283250-0x0000000183283380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183283080-0x00000001832831F0
}

