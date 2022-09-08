/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelupCityReq : MessageBase, IMessage<LevelupCityReq> // TypeDefIndex: 25058
{
	// Fields
	private static readonly MessageParser<LevelupCityReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B07E23
	private uint sceneId_; // 0x18
	public const int AreaIdFieldNumber = 2; // Metadata: 0x00B07E27
	private uint areaId_; // 0x1C
	public const int ItemNumFieldNumber = 3; // Metadata: 0x00B07E2B
	private uint itemNum_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LevelupCityReq> Parser { get => default; } // 0x000000018656F640-0x000000018656F6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018656F290-0x000000018656F320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018656EF50-0x000000018656EFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018656E750-0x000000018656E7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018656FAB0-0x000000018656FBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018656F8A0-0x000000018656F900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018656F3C0-0x000000018656F4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018656FA60-0x000000018656FAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018656F070-0x000000018656F160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x000000018656EA80-0x000000018656EB20 0x000000018656EEB0-0x000000018656EF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaId { get => default; set {} } // 0x000000018656E9E0-0x000000018656EA80 0x000000018656F320-0x000000018656F3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemNum { get => default; set {} } // 0x000000018656F5A0-0x000000018656F640 0x000000018656F6D0-0x000000018656F770

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25059
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25060
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 255
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityReq() {} // 0x000000018656FEF0-0x000000018656FF50
	static LevelupCityReq() {} // 0x000000018656FE30-0x000000018656FEF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityReq Clone() => default; // 0x000000018656F4B0-0x000000018656F5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityReq ShallowCopy() => default; // 0x000000018656EFD0-0x000000018656F070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018656E910-0x000000018656E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018656F800-0x000000018656F850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018656F850-0x000000018656F8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018656E960-0x000000018656E9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018656EC60-0x000000018656ED30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LevelupCityReq other) => default; // 0x000000018656EB20-0x000000018656EC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018656F160-0x000000018656F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018656FBA0-0x000000018656FE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018656F900-0x000000018656FA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018656ED30-0x000000018656EEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LevelupCityReq other) {} // 0x000000018656E7B0-0x000000018656E910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018656E640-0x000000018656E750
}

