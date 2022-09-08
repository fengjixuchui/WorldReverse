/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExhibitionDisplayInfo : MessageBase, IMessage<ExhibitionDisplayInfo> // TypeDefIndex: 26104
{
	// Fields
	private static readonly MessageParser<ExhibitionDisplayInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0B233
	private uint id_; // 0x18
	public const int ParamFieldNumber = 2; // Metadata: 0x00B0B237
	private uint param_; // 0x1C
	public const int DetailParamFieldNumber = 3; // Metadata: 0x00B0B23B
	private uint detailParam_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExhibitionDisplayInfo> Parser { get => default; } // 0x000000018220C040-0x000000018220C0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018220BDD0-0x000000018220BE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018220B9F0-0x000000018220BA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018220B290-0x000000018220B2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018220C5F0-0x000000018220C6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018220C2A0-0x000000018220C300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018220BE60-0x000000018220BF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018220C5A0-0x000000018220C5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018220BBB0-0x000000018220BCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018220B950-0x000000018220B9F0 0x000000018220C0D0-0x000000018220C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x000000018220C300-0x000000018220C3A0 0x000000018220C3A0-0x000000018220C440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DetailParam { get => default; set {} } // 0x000000018220BA70-0x000000018220BB10 0x000000018220B2F0-0x000000018220B390

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExhibitionDisplayInfo() {} // 0x000000018220CA30-0x000000018220CA90
	static ExhibitionDisplayInfo() {} // 0x000000018220C970-0x000000018220CA30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExhibitionDisplayInfo Clone() => default; // 0x000000018220BF50-0x000000018220C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExhibitionDisplayInfo ShallowCopy() => default; // 0x000000018220BB10-0x000000018220BBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018220B4F0-0x000000018220B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018220C200-0x000000018220C250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018220C250-0x000000018220C2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018220B540-0x000000018220B5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018220B5C0-0x000000018220B690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExhibitionDisplayInfo other) => default; // 0x000000018220B690-0x000000018220B7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018220BCA0-0x000000018220BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018220C6E0-0x000000018220C970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018220C440-0x000000018220C5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018220B7D0-0x000000018220B950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExhibitionDisplayInfo other) {} // 0x000000018220B390-0x000000018220B4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018220B180-0x000000018220B290
}

