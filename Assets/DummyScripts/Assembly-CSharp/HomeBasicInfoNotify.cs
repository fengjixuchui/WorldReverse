/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeBasicInfoNotify : MessageBase, IMessage<HomeBasicInfoNotify> // TypeDefIndex: 23322
{
	// Fields
	private static readonly MessageParser<HomeBasicInfoNotify> _parser; // 0x00
	public const int BasicInfoFieldNumber = 1; // Metadata: 0x00B03C33
	private HomeBasicInfo basicInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeBasicInfoNotify> Parser { get => default; } // 0x00000001854A1B20-0x00000001854A1BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001854A18B0-0x00000001854A1940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001854A1550-0x00000001854A15D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001854A0EC0-0x00000001854A0F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001854A2010-0x00000001854A2100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001854A1D40-0x00000001854A1DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001854A1940-0x00000001854A1A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001854A1F20-0x00000001854A1F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001854A1670-0x00000001854A1760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfo BasicInfo { get => default; set {} } // 0x00000001854A1DA0-0x00000001854A1E40 0x00000001854A1F70-0x00000001854A2010

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23323
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23324
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4456
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfoNotify() {} // 0x00000001854A2310-0x00000001854A2370
	static HomeBasicInfoNotify() {} // 0x00000001854A2250-0x00000001854A2310

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfoNotify Clone() => default; // 0x00000001854A1A30-0x00000001854A1B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicInfoNotify ShallowCopy() => default; // 0x00000001854A15D0-0x00000001854A1670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001854A1080-0x00000001854A1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854A1C40-0x00000001854A1CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854A1CC0-0x00000001854A1D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001854A1100-0x00000001854A1220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001854A1220-0x00000001854A12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeBasicInfoNotify other) => default; // 0x00000001854A12F0-0x00000001854A1400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001854A1760-0x00000001854A18B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001854A2100-0x00000001854A2250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001854A1E40-0x00000001854A1F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001854A1400-0x00000001854A1550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeBasicInfoNotify other) {} // 0x00000001854A0F20-0x00000001854A1080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001854A0DB0-0x00000001854A0EC0
}

