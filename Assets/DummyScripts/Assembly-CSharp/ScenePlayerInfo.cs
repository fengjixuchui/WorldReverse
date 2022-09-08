/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayerInfo : MessageBase, IMessage<ScenePlayerInfo> // TypeDefIndex: 25026
{
	// Fields
	private static readonly MessageParser<ScenePlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B07CDB
	private uint uid_; // 0x18
	public const int PeerIdFieldNumber = 2; // Metadata: 0x00B07CDF
	private uint peerId_; // 0x1C
	public const int NameFieldNumber = 3; // Metadata: 0x00B07CE3
	private string name_; // 0x20
	public const int IsConnectedFieldNumber = 4; // Metadata: 0x00B07CE7
	private bool isConnected_; // 0x28
	public const int SceneIdFieldNumber = 5; // Metadata: 0x00B07CEB
	private uint sceneId_; // 0x2C
	public const int OnlinePlayerInfoFieldNumber = 6; // Metadata: 0x00B07CEF
	private OnlinePlayerInfo onlinePlayerInfo_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayerInfo> Parser { get => default; } // 0x0000000181A37360-0x0000000181A373F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A37050-0x0000000181A370E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A36AA0-0x0000000181A36B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A35C50-0x0000000181A35CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A37860-0x0000000181A37950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A37580-0x0000000181A375E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A37180-0x0000000181A37270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A37810-0x0000000181A37860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A36C60-0x0000000181A36D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000181A368C0-0x0000000181A36960 0x0000000181A370E0-0x0000000181A37180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PeerId { get => default; set {} } // 0x0000000181A36BC0-0x0000000181A36C60 0x0000000181A35D50-0x0000000181A35DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { get => default; set {} } // 0x0000000181A36960-0x0000000181A36A00 0x0000000181A362B0-0x0000000181A36360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsConnected { get => default; set {} } // 0x0000000181A37950-0x0000000181A379F0 0x0000000181A35BB0-0x0000000181A35C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181A36210-0x0000000181A362B0 0x0000000181A36A00-0x0000000181A36AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo OnlinePlayerInfo { get => default; set {} } // 0x0000000181A35CB0-0x0000000181A35D50 0x0000000181A36FB0-0x0000000181A37050

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfo() {} // 0x0000000181A37EB0-0x0000000181A37F20
	static ScenePlayerInfo() {} // 0x0000000181A37DF0-0x0000000181A37EB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfo Clone() => default; // 0x0000000181A37270-0x0000000181A37360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayerInfo ShallowCopy() => default; // 0x0000000181A36B20-0x0000000181A36BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A36020-0x0000000181A360A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A37480-0x0000000181A37500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A37500-0x0000000181A37580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A360A0-0x0000000181A36210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A36540-0x0000000181A36610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayerInfo other) => default; // 0x0000000181A36360-0x0000000181A36540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A36D50-0x0000000181A36FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A379F0-0x0000000181A37DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A375E0-0x0000000181A37810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A36610-0x0000000181A368C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayerInfo other) {} // 0x0000000181A35DF0-0x0000000181A36020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A359F0-0x0000000181A35BB0
}

