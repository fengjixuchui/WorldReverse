/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayProduct : MessageBase, IMessage<PlayProduct> // TypeDefIndex: 26099
{
	// Fields
	private static readonly MessageParser<PlayProduct> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B0B1FF
	private string productId_; // 0x18
	public const int PriceTierFieldNumber = 2; // Metadata: 0x00B0B203
	private string priceTier_; // 0x20
	public const int ScheduleIdFieldNumber = 3; // Metadata: 0x00B0B207
	private uint scheduleId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayProduct> Parser { get => default; } // 0x00000001831A3C50-0x00000001831A3CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831A37F0-0x00000001831A3880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831A3460-0x00000001831A34E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831A2C10-0x00000001831A2C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831A40F0-0x00000001831A41E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831A3E10-0x00000001831A3E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831A3880-0x00000001831A3970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831A40A0-0x00000001831A40F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831A3580-0x00000001831A3670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x00000001831A3A60-0x00000001831A3B00 0x00000001831A3B00-0x00000001831A3BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PriceTier { get => default; set {} } // 0x00000001831A3BB0-0x00000001831A3C50 0x00000001831A2F80-0x00000001831A3030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001831A2EE0-0x00000001831A2F80 0x00000001831A3E70-0x00000001831A3F10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayProduct() {} // 0x00000001831A4500-0x00000001831A4580
	static PlayProduct() {} // 0x00000001831A4440-0x00000001831A4500

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayProduct Clone() => default; // 0x00000001831A3970-0x00000001831A3A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayProduct ShallowCopy() => default; // 0x00000001831A34E0-0x00000001831A3580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831A2E00-0x00000001831A2E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A3D70-0x00000001831A3DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831A3DC0-0x00000001831A3E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831A2E50-0x00000001831A2EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831A31D0-0x00000001831A32A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayProduct other) => default; // 0x00000001831A3030-0x00000001831A31D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831A3670-0x00000001831A37F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831A41E0-0x00000001831A4440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831A3F10-0x00000001831A40A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831A32A0-0x00000001831A3460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayProduct other) {} // 0x00000001831A2C70-0x00000001831A2E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831A2B00-0x00000001831A2C10
}

