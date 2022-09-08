/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionSearchChangeRegionNotify : MessageBase, IMessage<RegionSearchChangeRegionNotify> // TypeDefIndex: 24730
{
	// Fields
	private static readonly MessageParser<RegionSearchChangeRegionNotify> _parser; // 0x00
	public const int RegionIdFieldNumber = 1; // Metadata: 0x00B07197
	private uint regionId_; // 0x18
	public const int EventFieldNumber = 2; // Metadata: 0x00B0719B
	private Types.RegionEvent event_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionSearchChangeRegionNotify> Parser { get => default; } // 0x0000000181D50FE0-0x0000000181D51070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D50CD0-0x0000000181D50D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D508D0-0x0000000181D50950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D50360-0x0000000181D503C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D51410-0x0000000181D51500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D511A0-0x0000000181D51200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D50D60-0x0000000181D50E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D513C0-0x0000000181D51410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D509F0-0x0000000181D50AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionId { get => default; set {} } // 0x0000000181D51320-0x0000000181D513C0 0x0000000181D50C30-0x0000000181D50CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.RegionEvent Event { get => default; set {} } // 0x0000000181D51500-0x0000000181D515A0 0x0000000181D50F40-0x0000000181D50FE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24731
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24732
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5602
		}

		public enum RegionEvent // TypeDefIndex: 24733
		{
			None = 0,
			Enter = 1,
			Leave = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchChangeRegionNotify() {} // 0x0000000181D51860-0x0000000181D518D0
	static RegionSearchChangeRegionNotify() {} // 0x0000000181D517A0-0x0000000181D51860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchChangeRegionNotify Clone() => default; // 0x0000000181D50E50-0x0000000181D50F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchChangeRegionNotify ShallowCopy() => default; // 0x0000000181D50950-0x0000000181D509F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D504F0-0x0000000181D50540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D51100-0x0000000181D51150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D51150-0x0000000181D511A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D50540-0x0000000181D505B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D505B0-0x0000000181D50680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionSearchChangeRegionNotify other) => default; // 0x0000000181D50680-0x0000000181D507A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D50AE0-0x0000000181D50C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D515A0-0x0000000181D517A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D51200-0x0000000181D51320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D507A0-0x0000000181D508D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionSearchChangeRegionNotify other) {} // 0x0000000181D503C0-0x0000000181D504F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D50270-0x0000000181D50360
}

