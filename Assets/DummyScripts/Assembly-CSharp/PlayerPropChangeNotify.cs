/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerPropChangeNotify : MessageBase, IMessage<PlayerPropChangeNotify> // TypeDefIndex: 24354
{
	// Fields
	private static readonly MessageParser<PlayerPropChangeNotify> _parser; // 0x00
	public const int PropTypeFieldNumber = 1; // Metadata: 0x00B06423
	private uint propType_; // 0x18
	public const int PropDeltaFieldNumber = 2; // Metadata: 0x00B06427
	private uint propDelta_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerPropChangeNotify> Parser { get => default; } // 0x0000000182D98820-0x0000000182D988B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D98470-0x0000000182D98500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D98160-0x0000000182D981E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D97B50-0x0000000182D97BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D98C50-0x0000000182D98D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D989E0-0x0000000182D98A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D98500-0x0000000182D985F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D98C00-0x0000000182D98C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D98280-0x0000000182D98370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropType { get => default; set {} } // 0x0000000182D986E0-0x0000000182D98780 0x0000000182D97DA0-0x0000000182D97E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropDelta { get => default; set {} } // 0x0000000182D98780-0x0000000182D98820 0x0000000182D98A40-0x0000000182D98AE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24355
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24356
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 119
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeNotify() {} // 0x0000000182D99000-0x0000000182D99060
	static PlayerPropChangeNotify() {} // 0x0000000182D98F40-0x0000000182D99000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeNotify Clone() => default; // 0x0000000182D985F0-0x0000000182D986E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeNotify ShallowCopy() => default; // 0x0000000182D981E0-0x0000000182D98280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D97CE0-0x0000000182D97D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D98940-0x0000000182D98990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D98990-0x0000000182D989E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D97D30-0x0000000182D97DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D97F60-0x0000000182D98030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerPropChangeNotify other) => default; // 0x0000000182D97E40-0x0000000182D97F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D98370-0x0000000182D98470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D98D40-0x0000000182D98F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D98AE0-0x0000000182D98C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D98030-0x0000000182D98160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerPropChangeNotify other) {} // 0x0000000182D97BB0-0x0000000182D97CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D97A50-0x0000000182D97B50
}

