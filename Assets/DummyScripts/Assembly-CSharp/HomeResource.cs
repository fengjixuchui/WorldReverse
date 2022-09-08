/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeResource : MessageBase, IMessage<HomeResource> // TypeDefIndex: 23511
{
	// Fields
	private static readonly MessageParser<HomeResource> _parser; // 0x00
	public const int StoreValueFieldNumber = 1; // Metadata: 0x00B042DF
	private uint storeValue_; // 0x18
	public const int StoreLimitFieldNumber = 2; // Metadata: 0x00B042E3
	private uint storeLimit_; // 0x1C
	public const int NextRefreshTimeFieldNumber = 3; // Metadata: 0x00B042E7
	private uint nextRefreshTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeResource> Parser { get => default; } // 0x0000000184A84E50-0x0000000184A84EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A84A00-0x0000000184A84A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A846C0-0x0000000184A84740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A84030-0x0000000184A84090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A852C0-0x0000000184A853B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A850B0-0x0000000184A85110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A84B30-0x0000000184A84C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A85270-0x0000000184A852C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A847E0-0x0000000184A848D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StoreValue { get => default; set {} } // 0x0000000184A842C0-0x0000000184A84360 0x0000000184A85010-0x0000000184A850B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StoreLimit { get => default; set {} } // 0x0000000184A84D10-0x0000000184A84DB0 0x0000000184A84A90-0x0000000184A84B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x0000000184A84DB0-0x0000000184A84E50 0x0000000184A853B0-0x0000000184A85450

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource() {} // 0x0000000184A857A0-0x0000000184A85800
	static HomeResource() {} // 0x0000000184A856E0-0x0000000184A857A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource Clone() => default; // 0x0000000184A84C20-0x0000000184A84D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource ShallowCopy() => default; // 0x0000000184A84740-0x0000000184A847E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A841F0-0x0000000184A84240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A84F70-0x0000000184A84FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A84FC0-0x0000000184A85010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A84240-0x0000000184A842C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A84360-0x0000000184A84430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeResource other) => default; // 0x0000000184A84430-0x0000000184A84570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A848D0-0x0000000184A84A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A85450-0x0000000184A856E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A85110-0x0000000184A85270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A84570-0x0000000184A846C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeResource other) {} // 0x0000000184A84090-0x0000000184A841F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A83F20-0x0000000184A84030
}

