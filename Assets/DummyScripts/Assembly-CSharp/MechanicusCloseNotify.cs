/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusCloseNotify : MessageBase, IMessage<MechanicusCloseNotify> // TypeDefIndex: 23892
{
	// Fields
	private static readonly MessageParser<MechanicusCloseNotify> _parser; // 0x00
	public const int MechanicusIdFieldNumber = 1; // Metadata: 0x00B05123
	private uint mechanicusId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusCloseNotify> Parser { get => default; } // 0x0000000181A21380-0x0000000181A21410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A21070-0x0000000181A21100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A20D80-0x0000000181A20E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A207F0-0x0000000181A20850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A216D0-0x0000000181A217C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A21540-0x0000000181A215A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A211A0-0x0000000181A21290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A21680-0x0000000181A216D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A20EA0-0x0000000181A20F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x0000000181A21100-0x0000000181A211A0 0x0000000181A20A20-0x0000000181A20AC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23893
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23894
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3906
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCloseNotify() {} // 0x0000000181A219F0-0x0000000181A21A50
	static MechanicusCloseNotify() {} // 0x0000000181A21930-0x0000000181A219F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCloseNotify Clone() => default; // 0x0000000181A21290-0x0000000181A21380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCloseNotify ShallowCopy() => default; // 0x0000000181A20E00-0x0000000181A20EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A20960-0x0000000181A209B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A214A0-0x0000000181A214F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A214F0-0x0000000181A21540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A209B0-0x0000000181A20A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A20AC0-0x0000000181A20B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusCloseNotify other) => default; // 0x0000000181A20B90-0x0000000181A20C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A20F90-0x0000000181A21070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A217C0-0x0000000181A21930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A215A0-0x0000000181A21680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A20C90-0x0000000181A20D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusCloseNotify other) {} // 0x0000000181A20850-0x0000000181A20960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A20710-0x0000000181A207F0
}

