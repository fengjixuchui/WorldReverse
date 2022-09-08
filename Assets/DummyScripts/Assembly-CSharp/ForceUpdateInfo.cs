/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForceUpdateInfo : MessageBase, IMessage<ForceUpdateInfo> // TypeDefIndex: 25965
{
	// Fields
	private static readonly MessageParser<ForceUpdateInfo> _parser; // 0x00
	public const int ForceUpdateUrlFieldNumber = 1; // Metadata: 0x00B0A7AB
	private string forceUpdateUrl_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForceUpdateInfo> Parser { get => default; } // 0x000000018402B990-0x000000018402BA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018402B680-0x000000018402B710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018402B370-0x000000018402B3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018402AD80-0x000000018402ADE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018402BD00-0x000000018402BDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018402BB50-0x000000018402BBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018402B710-0x000000018402B800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018402BCB0-0x000000018402BD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018402B490-0x000000018402B580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ForceUpdateUrl { get => default; set {} } // 0x000000018402B8F0-0x000000018402B990 0x000000018402ADE0-0x000000018402AE90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceUpdateInfo() {} // 0x000000018402C000-0x000000018402C070
	static ForceUpdateInfo() {} // 0x000000018402BF40-0x000000018402C000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceUpdateInfo Clone() => default; // 0x000000018402B800-0x000000018402B8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceUpdateInfo ShallowCopy() => default; // 0x000000018402B3F0-0x000000018402B490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018402AFB0-0x000000018402B000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018402BAB0-0x000000018402BB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018402BB00-0x000000018402BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018402B000-0x000000018402B070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018402B070-0x000000018402B140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForceUpdateInfo other) => default; // 0x000000018402B140-0x000000018402B270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018402B580-0x000000018402B680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018402BDF0-0x000000018402BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018402BBB0-0x000000018402BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018402B270-0x000000018402B370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForceUpdateInfo other) {} // 0x000000018402AE90-0x000000018402AFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018402ACA0-0x000000018402AD80
}

