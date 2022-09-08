/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrackingIOInfo : MessageBase, IMessage<TrackingIOInfo> // TypeDefIndex: 24303
{
	// Fields
	private static readonly MessageParser<TrackingIOInfo> _parser; // 0x00
	public const int AppidFieldNumber = 1; // Metadata: 0x00B06177
	private string appid_; // 0x18
	public const int DeviceidFieldNumber = 2; // Metadata: 0x00B0617B
	private string deviceid_; // 0x20
	public const int MacFieldNumber = 3; // Metadata: 0x00B0617F
	private string mac_; // 0x28
	public const int RydevicetypeFieldNumber = 4; // Metadata: 0x00B06183
	private string rydevicetype_; // 0x30
	public const int ClientTzFieldNumber = 5; // Metadata: 0x00B06187
	private string clientTz_; // 0x38
	public const int CurrentCaidFieldNumber = 6; // Metadata: 0x00B0618B
	private string currentCaid_; // 0x40
	public const int CachedCaidFieldNumber = 7; // Metadata: 0x00B0618F
	private string cachedCaid_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrackingIOInfo> Parser { get => default; } // 0x0000000180B29A80-0x0000000180B29B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180B292E0-0x0000000180B29370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180B28BD0-0x0000000180B28C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180B28050-0x0000000180B280B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180B2A1F0-0x0000000180B2A2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180B29D80-0x0000000180B29DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180B29560-0x0000000180B29650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180B2A1A0-0x0000000180B2A1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180B28CF0-0x0000000180B28DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Appid { get => default; set {} } // 0x0000000180B29370-0x0000000180B29410 0x0000000180B29700-0x0000000180B297B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Deviceid { get => default; set {} } // 0x0000000180B29940-0x0000000180B299E0 0x0000000180B29410-0x0000000180B294C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Mac { get => default; set {} } // 0x0000000180B29CE0-0x0000000180B29D80 0x0000000180B29180-0x0000000180B29230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Rydevicetype { get => default; set {} } // 0x0000000180B298A0-0x0000000180B29940 0x0000000180B290D0-0x0000000180B29180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientTz { get => default; set {} } // 0x0000000180B299E0-0x0000000180B29A80 0x0000000180B29650-0x0000000180B29700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CurrentCaid { get => default; set {} } // 0x0000000180B294C0-0x0000000180B29560 0x0000000180B29DE0-0x0000000180B29E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CachedCaid { get => default; set {} } // 0x0000000180B29C40-0x0000000180B29CE0 0x0000000180B29230-0x0000000180B292E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrackingIOInfo() {} // 0x0000000180B2A7A0-0x0000000180B2A850
	static TrackingIOInfo() {} // 0x0000000180B2A6E0-0x0000000180B2A7A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrackingIOInfo Clone() => default; // 0x0000000180B297B0-0x0000000180B298A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrackingIOInfo ShallowCopy() => default; // 0x0000000180B28C50-0x0000000180B28CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180B28350-0x0000000180B283A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180B29BA0-0x0000000180B29BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180B29BF0-0x0000000180B29C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180B283A0-0x0000000180B28480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180B287A0-0x0000000180B28870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrackingIOInfo other) => default; // 0x0000000180B28480-0x0000000180B287A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180B28DE0-0x0000000180B290D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180B2A2E0-0x0000000180B2A6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180B29E90-0x0000000180B2A1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180B28870-0x0000000180B28BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrackingIOInfo other) {} // 0x0000000180B280B0-0x0000000180B28350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180B27EC0-0x0000000180B28050
}

