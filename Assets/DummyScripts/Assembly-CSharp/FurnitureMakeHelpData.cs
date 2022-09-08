/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeHelpData : MessageBase, IMessage<FurnitureMakeHelpData> // TypeDefIndex: 23443
{
	// Fields
	private static readonly MessageParser<FurnitureMakeHelpData> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0409B
	private uint uid_; // 0x18
	public const int TimesFieldNumber = 2; // Metadata: 0x00B0409F
	private uint times_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeHelpData> Parser { get => default; } // 0x0000000184E71EE0-0x0000000184E71F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E71B30-0x0000000184E71BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E71780-0x0000000184E71800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E71170-0x0000000184E711D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E72270-0x0000000184E72360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E720A0-0x0000000184E72100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E71C60-0x0000000184E71D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E72220-0x0000000184E72270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E718A0-0x0000000184E71990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184E716E0-0x0000000184E71780 0x0000000184E71BC0-0x0000000184E71C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Times { get => default; set {} } // 0x0000000184E71E40-0x0000000184E71EE0 0x0000000184E71A90-0x0000000184E71B30

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpData() {} // 0x0000000184E72620-0x0000000184E72680
	static FurnitureMakeHelpData() {} // 0x0000000184E72560-0x0000000184E72620

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpData Clone() => default; // 0x0000000184E71D50-0x0000000184E71E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeHelpData ShallowCopy() => default; // 0x0000000184E71800-0x0000000184E718A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E71300-0x0000000184E71350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E72000-0x0000000184E72050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E72050-0x0000000184E720A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E71350-0x0000000184E713C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E713C0-0x0000000184E71490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeHelpData other) => default; // 0x0000000184E71490-0x0000000184E715B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E71990-0x0000000184E71A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E72360-0x0000000184E72560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E72100-0x0000000184E72220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E715B0-0x0000000184E716E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeHelpData other) {} // 0x0000000184E711D0-0x0000000184E71300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E71070-0x0000000184E71170
}

