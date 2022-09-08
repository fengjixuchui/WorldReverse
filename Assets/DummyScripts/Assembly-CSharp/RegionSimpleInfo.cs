/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionSimpleInfo : MessageBase, IMessage<RegionSimpleInfo> // TypeDefIndex: 25963
{
	// Fields
	private static readonly MessageParser<RegionSimpleInfo> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0A787
	private string name_; // 0x18
	public const int TitleFieldNumber = 2; // Metadata: 0x00B0A78B
	private string title_; // 0x20
	public const int TypeFieldNumber = 3; // Metadata: 0x00B0A78F
	private string type_; // 0x28
	public const int DispatchUrlFieldNumber = 4; // Metadata: 0x00B0A793
	private string dispatchUrl_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionSimpleInfo> Parser { get => default; } // 0x0000000181F2CDB0-0x0000000181F2CE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F2CAA0-0x0000000181F2CB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F2C5F0-0x0000000181F2C670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F2BAF0-0x0000000181F2BB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F2D2D0-0x0000000181F2D3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F2CF70-0x0000000181F2CFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F2CB30-0x0000000181F2CC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F2D1D0-0x0000000181F2D220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F2C710-0x0000000181F2C800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { get => default; set {} } // 0x0000000181F2C550-0x0000000181F2C5F0 0x0000000181F2BEC0-0x0000000181F2BF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Title { get => default; set {} } // 0x0000000181F2BB50-0x0000000181F2BBF0 0x0000000181F2C9F0-0x0000000181F2CAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Type { get => default; set {} } // 0x0000000181F2B910-0x0000000181F2B9B0 0x0000000181F2D220-0x0000000181F2D2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DispatchUrl { get => default; set {} } // 0x0000000181F2CD10-0x0000000181F2CDB0 0x0000000181F2C4A0-0x0000000181F2C550

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSimpleInfo() {} // 0x0000000181F2D720-0x0000000181F2D7B0
	static RegionSimpleInfo() {} // 0x0000000181F2D660-0x0000000181F2D720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSimpleInfo Clone() => default; // 0x0000000181F2CC20-0x0000000181F2CD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSimpleInfo ShallowCopy() => default; // 0x0000000181F2C670-0x0000000181F2C710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F2BDD0-0x0000000181F2BE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F2CED0-0x0000000181F2CF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F2CF20-0x0000000181F2CF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F2BE20-0x0000000181F2BEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F2BF70-0x0000000181F2C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionSimpleInfo other) => default; // 0x0000000181F2C040-0x0000000181F2C270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F2C800-0x0000000181F2C9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F2D3C0-0x0000000181F2D660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F2CFD0-0x0000000181F2D1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F2C270-0x0000000181F2C4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionSimpleInfo other) {} // 0x0000000181F2BBF0-0x0000000181F2BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F2B9B0-0x0000000181F2BAF0
}

