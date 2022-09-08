/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpenStateChangeNotify : MessageBase, IMessage<OpenStateChangeNotify> // TypeDefIndex: 24372
{
	// Fields
	private static readonly MessageParser<OpenStateChangeNotify> _parser; // 0x00
	public const int OpenStateMapFieldNumber = 1; // Metadata: 0x00B064B7
	private static readonly MapField<uint, uint> _map_openStateMap_codec; // 0x08
	private readonly MapField<uint, uint> openStateMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpenStateChangeNotify> Parser { get => default; } // 0x0000000182B405D0-0x0000000182B40660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B40360-0x0000000182B403F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B40060-0x0000000182B400E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B3FA50-0x0000000182B3FAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B40940-0x0000000182B40A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B40790-0x0000000182B407F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B403F0-0x0000000182B404E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B408F0-0x0000000182B40940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B40180-0x0000000182B40270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> OpenStateMap { get => default; } // 0x0000000182B40000-0x0000000182B40060 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24373
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24374
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 125
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenStateChangeNotify() {} // 0x0000000182B40CB0-0x0000000182B40D40
	static OpenStateChangeNotify() {} // 0x0000000182B40B80-0x0000000182B40CB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenStateChangeNotify Clone() => default; // 0x0000000182B404E0-0x0000000182B405D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpenStateChangeNotify ShallowCopy() => default; // 0x0000000182B400E0-0x0000000182B40180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B3FBC0-0x0000000182B3FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B406F0-0x0000000182B40740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B40740-0x0000000182B40790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B3FC10-0x0000000182B3FCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B3FE40-0x0000000182B3FF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpenStateChangeNotify other) => default; // 0x0000000182B3FCC0-0x0000000182B3FE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B40270-0x0000000182B40360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B40A30-0x0000000182B40B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B407F0-0x0000000182B408F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B3FF10-0x0000000182B40000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpenStateChangeNotify other) {} // 0x0000000182B3FAB0-0x0000000182B3FBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B3F920-0x0000000182B3FA50
}

