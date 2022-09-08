/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairBuffEnergyNotify : MessageBase, IMessage<FleurFairBuffEnergyNotify> // TypeDefIndex: 24163
{
	// Fields
	private static readonly MessageParser<FleurFairBuffEnergyNotify> _parser; // 0x00
	public const int EnergyFieldNumber = 1; // Metadata: 0x00B05BE3
	private uint energy_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairBuffEnergyNotify> Parser { get => default; } // 0x000000018509DF20-0x000000018509DFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018509DCB0-0x000000018509DD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018509D920-0x000000018509D9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018509D390-0x000000018509D3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018509E270-0x000000018509E360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018509E0E0-0x000000018509E140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018509DD40-0x000000018509DE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018509E220-0x000000018509E270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018509DA40-0x000000018509DB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Energy { get => default; set {} } // 0x000000018509DC10-0x000000018509DCB0 0x000000018509D5C0-0x000000018509D660

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24164
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24165
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5341
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBuffEnergyNotify() {} // 0x000000018509E590-0x000000018509E5F0
	static FleurFairBuffEnergyNotify() {} // 0x000000018509E4D0-0x000000018509E590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBuffEnergyNotify Clone() => default; // 0x000000018509DE30-0x000000018509DF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBuffEnergyNotify ShallowCopy() => default; // 0x000000018509D9A0-0x000000018509DA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018509D500-0x000000018509D550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018509E040-0x000000018509E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018509E090-0x000000018509E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018509D550-0x000000018509D5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018509D660-0x000000018509D730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairBuffEnergyNotify other) => default; // 0x000000018509D730-0x000000018509D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018509DB30-0x000000018509DC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018509E360-0x000000018509E4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018509E140-0x000000018509E220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018509D830-0x000000018509D920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairBuffEnergyNotify other) {} // 0x000000018509D3F0-0x000000018509D500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018509D2B0-0x000000018509D390
}

