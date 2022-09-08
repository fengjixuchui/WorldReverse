/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampFlyLampNotify : MessageBase, IMessage<SeaLampFlyLampNotify> // TypeDefIndex: 21919
{
	// Fields
	private static readonly MessageParser<SeaLampFlyLampNotify> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B005A3
	private uint itemId_; // 0x18
	public const int ItemNumFieldNumber = 2; // Metadata: 0x00B005A7
	private uint itemNum_; // 0x1C
	public const int PosFieldNumber = 3; // Metadata: 0x00B005AB
	private Vector pos_; // 0x20
	public const int ParamFieldNumber = 4; // Metadata: 0x00B005AF
	private int param_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampFlyLampNotify> Parser { get => default; } // 0x0000000183DEA050-0x0000000183DEA0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DE9D40-0x0000000183DE9DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DE9940-0x0000000183DE99C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DE90C0-0x0000000183DE9120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DEA920-0x0000000183DEAA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DEA450-0x0000000183DEA4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DE9DD0-0x0000000183DE9EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DEA830-0x0000000183DEA880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DE9A60-0x0000000183DE9B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000183DEA210-0x0000000183DEA2B0 0x0000000183DEA880-0x0000000183DEA920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemNum { get => default; set {} } // 0x0000000183DE9FB0-0x0000000183DEA050 0x0000000183DEA0E0-0x0000000183DEA180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000183DEA3B0-0x0000000183DEA450 0x0000000183DEA790-0x0000000183DEA830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param { get => default; set {} } // 0x0000000183DEA4B0-0x0000000183DEA550 0x0000000183DEA550-0x0000000183DEA5F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21920
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21921
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2028
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampNotify() {} // 0x0000000183DEADD0-0x0000000183DEAE30
	static SeaLampFlyLampNotify() {} // 0x0000000183DEAD10-0x0000000183DEADD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampNotify Clone() => default; // 0x0000000183DE9EC0-0x0000000183DE9FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampFlyLampNotify ShallowCopy() => default; // 0x0000000183DE99C0-0x0000000183DE9A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DE9300-0x0000000183DE9380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DEA2B0-0x0000000183DEA330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DEA330-0x0000000183DEA3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DE9380-0x0000000183DE94D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DE9640-0x0000000183DE9710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampFlyLampNotify other) => default; // 0x0000000183DE94D0-0x0000000183DE9640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DE9B50-0x0000000183DE9D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DEAA10-0x0000000183DEAD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DEA5F0-0x0000000183DEA790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DE9710-0x0000000183DE9940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampFlyLampNotify other) {} // 0x0000000183DE9120-0x0000000183DE9300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DE8F40-0x0000000183DE90C0
}

