/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DropSubfieldReq : MessageBase, IMessage<DropSubfieldReq> // TypeDefIndex: 25046
{
	// Fields
	private static readonly MessageParser<DropSubfieldReq> _parser; // 0x00
	public const int DropTypeFieldNumber = 1; // Metadata: 0x00B07DAB
	private DropSubfieldType dropType_; // 0x18
	public const int DropParamFieldNumber = 2; // Metadata: 0x00B07DAF
	private uint dropParam_; // 0x1C
	public const int EntityIdFieldNumber = 3; // Metadata: 0x00B07DB3
	private uint entityId_; // 0x20
	public const int SubfieldNameFieldNumber = 4; // Metadata: 0x00B07DB7
	private string subfieldName_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DropSubfieldReq> Parser { get => default; } // 0x00000001836306B0-0x0000000183630740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836302F0-0x0000000183630380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018362FF10-0x000000018362FF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018362F750-0x000000018362F7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183630C10-0x0000000183630D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836309B0-0x0000000183630A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836304D0-0x00000001836305C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183630BC0-0x0000000183630C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183630030-0x0000000183630120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropSubfieldType DropType { get => default; set {} } // 0x000000018362F6B0-0x000000018362F750 0x000000018362F4F0-0x000000018362F590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DropParam { get => default; set {} } // 0x000000018362F7B0-0x000000018362F850 0x0000000183630430-0x00000001836304D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183630910-0x00000001836309B0 0x0000000183630D00-0x0000000183630DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SubfieldName { get => default; set {} } // 0x0000000183630870-0x0000000183630910 0x0000000183630380-0x0000000183630430

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25047
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25048
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 251
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropSubfieldReq() {} // 0x0000000183631160-0x0000000183631210
	static DropSubfieldReq() {} // 0x00000001836310A0-0x0000000183631160

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropSubfieldReq Clone() => default; // 0x00000001836305C0-0x00000001836306B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropSubfieldReq ShallowCopy() => default; // 0x000000018362FF90-0x0000000183630030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018362F9F0-0x000000018362FA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836307D0-0x0000000183630820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183630820-0x0000000183630870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018362FA40-0x000000018362FAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018362FC60-0x000000018362FD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DropSubfieldReq other) => default; // 0x000000018362FAD0-0x000000018362FC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183630120-0x00000001836302F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183630DA0-0x00000001836310A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183630A10-0x0000000183630BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018362FD30-0x000000018362FF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DropSubfieldReq other) {} // 0x000000018362F850-0x000000018362F9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018362F590-0x000000018362F6B0
}

