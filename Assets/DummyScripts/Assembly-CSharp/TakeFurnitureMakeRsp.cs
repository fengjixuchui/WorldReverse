/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeFurnitureMakeRsp : MessageBase, IMessage<TakeFurnitureMakeRsp> // TypeDefIndex: 23454
{
	// Fields
	private static readonly MessageParser<TakeFurnitureMakeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04103
	private int retcode_; // 0x18
	public const int MakeIdFieldNumber = 2; // Metadata: 0x00B04107
	private uint makeId_; // 0x1C
	public const int FurnitureMakeSlotFieldNumber = 3; // Metadata: 0x00B0410B
	private FurnitureMakeSlot furnitureMakeSlot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeFurnitureMakeRsp> Parser { get => default; } // 0x0000000183AF0050-0x0000000183AF00E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183AEFDE0-0x0000000183AEFE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183AEF980-0x0000000183AEFA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183AEEFD0-0x0000000183AEF030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AF0520-0x0000000183AF0610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AF0310-0x0000000183AF0370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183AEFE70-0x0000000183AEFF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AF04D0-0x0000000183AF0520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183AEFAA0-0x0000000183AEFB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183AEF8E0-0x0000000183AEF980 0x0000000183AEF440-0x0000000183AEF4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MakeId { get => default; set {} } // 0x0000000183AEF1E0-0x0000000183AEF280 0x0000000183AEEF30-0x0000000183AEEFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeSlot FurnitureMakeSlot { get => default; set {} } // 0x0000000183AF01F0-0x0000000183AF0290 0x0000000183AEFD40-0x0000000183AEFDE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23455
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23456
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4604
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeRsp() {} // 0x0000000183AF0940-0x0000000183AF09A0
	static TakeFurnitureMakeRsp() {} // 0x0000000183AF0880-0x0000000183AF0940

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeRsp Clone() => default; // 0x0000000183AEFF60-0x0000000183AF0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeRsp ShallowCopy() => default; // 0x0000000183AEFA00-0x0000000183AEFAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183AEF280-0x0000000183AEF300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AF0170-0x0000000183AF01F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AF0290-0x0000000183AF0310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183AEF300-0x0000000183AEF440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183AEF4E0-0x0000000183AEF5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeFurnitureMakeRsp other) => default; // 0x0000000183AEF5B0-0x0000000183AEF700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183AEFB90-0x0000000183AEFD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AF0610-0x0000000183AF0880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AF0370-0x0000000183AF04D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183AEF700-0x0000000183AEF8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeFurnitureMakeRsp other) {} // 0x0000000183AEF030-0x0000000183AEF1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183AEEDD0-0x0000000183AEEF30
}

