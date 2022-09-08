/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class H5ActivityIdsNotify : MessageBase, IMessage<H5ActivityIdsNotify> // TypeDefIndex: 23303
{
	// Fields
	private static readonly MessageParser<H5ActivityIdsNotify> _parser; // 0x00
	public const int H5ActivityMapFieldNumber = 1; // Metadata: 0x00B03B93
	private static readonly MapField<uint, uint> _map_h5ActivityMap_codec; // 0x08
	private readonly MapField<uint, uint> h5ActivityMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<H5ActivityIdsNotify> Parser { get => default; } // 0x0000000184277080-0x0000000184277110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184276E10-0x0000000184276EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184276B10-0x0000000184276B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184276500-0x0000000184276560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842773F0-0x00000001842774E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184277240-0x00000001842772A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184276EA0-0x0000000184276F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842773A0-0x00000001842773F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184276C30-0x0000000184276D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> H5ActivityMap { get => default; } // 0x0000000184276AB0-0x0000000184276B10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23304
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23305
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5653
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityIdsNotify() {} // 0x0000000184277760-0x00000001842777F0
	static H5ActivityIdsNotify() {} // 0x0000000184277630-0x0000000184277760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityIdsNotify Clone() => default; // 0x0000000184276F90-0x0000000184277080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public H5ActivityIdsNotify ShallowCopy() => default; // 0x0000000184276B90-0x0000000184276C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184276670-0x00000001842766C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842771A0-0x00000001842771F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842771F0-0x0000000184277240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842766C0-0x0000000184276770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184276770-0x0000000184276840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(H5ActivityIdsNotify other) => default; // 0x0000000184276840-0x00000001842769C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184276D20-0x0000000184276E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842774E0-0x0000000184277630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842772A0-0x00000001842773A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842769C0-0x0000000184276AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(H5ActivityIdsNotify other) {} // 0x0000000184276560-0x0000000184276670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842763D0-0x0000000184276500
}

