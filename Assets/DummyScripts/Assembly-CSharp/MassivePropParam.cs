/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassivePropParam : MessageBase, IMessage<MassivePropParam> // TypeDefIndex: 25999
{
	// Fields
	private static readonly MessageParser<MassivePropParam> _parser; // 0x00
	public const int ElementReactionTypeFieldNumber = 1; // Metadata: 0x00B0A9E7
	private int elementReactionType_; // 0x18
	public const int CasterIdFieldNumber = 2; // Metadata: 0x00B0A9EB
	private uint casterId_; // 0x1C
	public const int ParamListFieldNumber = 3; // Metadata: 0x00B0A9EF
	private static readonly FieldCodec<float> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<float> paramList_; // 0x20
	public const int SyncFlagFieldNumber = 4; // Metadata: 0x00B0A9F3
	private uint syncFlag_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassivePropParam> Parser { get => default; } // 0x0000000181A111B0-0x0000000181A11240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A10F40-0x0000000181A10FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A10B30-0x0000000181A10BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A102C0-0x0000000181A10320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A11780-0x0000000181A11870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A11410-0x0000000181A11470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A10FD0-0x0000000181A110C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A11690-0x0000000181A116E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A10C50-0x0000000181A10D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ElementReactionType { get => default; set {} } // 0x0000000181A10EA0-0x0000000181A10F40 0x0000000181A10680-0x0000000181A10720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CasterId { get => default; set {} } // 0x0000000181A10320-0x0000000181A103C0 0x0000000181A116E0-0x0000000181A11780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<float> ParamList { get => default; } // 0x0000000181A11470-0x0000000181A114D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SyncFlag { get => default; set {} } // 0x0000000181A10220-0x0000000181A102C0 0x0000000181A11370-0x0000000181A11410

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropParam() {} // 0x0000000181A11C50-0x0000000181A11CE0
	static MassivePropParam() {} // 0x0000000181A11B70-0x0000000181A11C50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropParam Clone() => default; // 0x0000000181A110C0-0x0000000181A111B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropParam ShallowCopy() => default; // 0x0000000181A10BB0-0x0000000181A10C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A10540-0x0000000181A10590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A112D0-0x0000000181A11320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A11320-0x0000000181A11370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A10590-0x0000000181A10680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A10720-0x0000000181A107F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassivePropParam other) => default; // 0x0000000181A107F0-0x0000000181A10950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A10D40-0x0000000181A10EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A11870-0x0000000181A11B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A114D0-0x0000000181A11690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A10950-0x0000000181A10B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassivePropParam other) {} // 0x0000000181A103C0-0x0000000181A10540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A10080-0x0000000181A10220
}

