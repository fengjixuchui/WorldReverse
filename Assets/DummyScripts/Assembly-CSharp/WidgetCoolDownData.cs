/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WidgetCoolDownData : MessageBase, IMessage<WidgetCoolDownData> // TypeDefIndex: 25840
{
	// Fields
	private static readonly MessageParser<WidgetCoolDownData> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B09B13
	private uint id_; // 0x18
	public const int CoolDownTimeFieldNumber = 2; // Metadata: 0x00B09B17
	private ulong coolDownTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WidgetCoolDownData> Parser { get => default; } // 0x0000000181EDADC0-0x0000000181EDAE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EDAB50-0x0000000181EDABE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EDA830-0x0000000181EDA8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EDA0E0-0x0000000181EDA140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EDB1F0-0x0000000181EDB2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EDB020-0x0000000181EDB080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EDABE0-0x0000000181EDACD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EDB1A0-0x0000000181EDB1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EDA950-0x0000000181EDAA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000181EDA790-0x0000000181EDA830 0x0000000181EDAE50-0x0000000181EDAEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CoolDownTime { get => default; set {} } // 0x0000000181EDA270-0x0000000181EDA310 0x0000000181EDA5C0-0x0000000181EDA660

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownData() {} // 0x0000000181EDB5A0-0x0000000181EDB600
	static WidgetCoolDownData() {} // 0x0000000181EDB4E0-0x0000000181EDB5A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownData Clone() => default; // 0x0000000181EDACD0-0x0000000181EDADC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WidgetCoolDownData ShallowCopy() => default; // 0x0000000181EDA8B0-0x0000000181EDA950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EDA310-0x0000000181EDA360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EDAF80-0x0000000181EDAFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EDAFD0-0x0000000181EDB020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EDA360-0x0000000181EDA3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EDA3D0-0x0000000181EDA4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WidgetCoolDownData other) => default; // 0x0000000181EDA4A0-0x0000000181EDA5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EDAA40-0x0000000181EDAB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EDB2E0-0x0000000181EDB4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EDB080-0x0000000181EDB1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EDA660-0x0000000181EDA790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WidgetCoolDownData other) {} // 0x0000000181EDA140-0x0000000181EDA270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181ED9FE0-0x0000000181EDA0E0
}

