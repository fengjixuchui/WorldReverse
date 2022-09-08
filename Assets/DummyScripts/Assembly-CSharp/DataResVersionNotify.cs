/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DataResVersionNotify : MessageBase, IMessage<DataResVersionNotify> // TypeDefIndex: 24434
{
	// Fields
	private static readonly MessageParser<DataResVersionNotify> _parser; // 0x00
	public const int ClientDataVersionFieldNumber = 1; // Metadata: 0x00B066BB
	private uint clientDataVersion_; // 0x18
	public const int ClientSilenceDataVersionFieldNumber = 2; // Metadata: 0x00B066BF
	private uint clientSilenceDataVersion_; // 0x1C
	public const int ClientMd5FieldNumber = 5; // Metadata: 0x00B066C3
	private string clientMd5_; // 0x20
	public const int ClientSilenceMd5FieldNumber = 6; // Metadata: 0x00B066C7
	private string clientSilenceMd5_; // 0x28
	public const int ResVersionConfigFieldNumber = 10; // Metadata: 0x00B066CB
	private ResVersionConfig resVersionConfig_; // 0x30
	public const int ClientVersionSuffixFieldNumber = 11; // Metadata: 0x00B066CF
	private string clientVersionSuffix_; // 0x38
	public const int ClientSilenceVersionSuffixFieldNumber = 12; // Metadata: 0x00B066D3
	private string clientSilenceVersionSuffix_; // 0x40
	public const int IsDataNeedReloginFieldNumber = 14; // Metadata: 0x00B066D7
	private bool isDataNeedRelogin_; // 0x48
	public const int OpTypeFieldNumber = 15; // Metadata: 0x00B066DB
	private Types.DataResVersionOpType opType_; // 0x4C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DataResVersionNotify> Parser { get => default; } // 0x00000001842E4690-0x00000001842E4720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842E40F0-0x00000001842E4180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842E3A00-0x00000001842E3A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842E2A60-0x00000001842E2AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842E4F20-0x00000001842E5010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842E4950-0x00000001842E49B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842E4410-0x00000001842E4500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842E4E30-0x00000001842E4E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842E3B20-0x00000001842E3C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientDataVersion { get => default; set {} } // 0x00000001842E5010-0x00000001842E50B0 0x00000001842E4220-0x00000001842E42C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientSilenceDataVersion { get => default; set {} } // 0x00000001842E49B0-0x00000001842E4A50 0x00000001842E4050-0x00000001842E40F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientMd5 { get => default; set {} } // 0x00000001842E45F0-0x00000001842E4690 0x00000001842E2DC0-0x00000001842E2E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceMd5 { get => default; set {} } // 0x00000001842E4180-0x00000001842E4220 0x00000001842E3130-0x00000001842E31E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig ResVersionConfig { get => default; set {} } // 0x00000001842E3FB0-0x00000001842E4050 0x00000001842E4D90-0x00000001842E4E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientVersionSuffix { get => default; set {} } // 0x00000001842E4830-0x00000001842E48D0 0x00000001842E4360-0x00000001842E4410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceVersionSuffix { get => default; set {} } // 0x00000001842E4E80-0x00000001842E4F20 0x00000001842E3950-0x00000001842E3A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDataNeedRelogin { get => default; set {} } // 0x00000001842E42C0-0x00000001842E4360 0x00000001842E50B0-0x00000001842E5150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.DataResVersionOpType OpType { get => default; set {} } // 0x00000001842E2E70-0x00000001842E2F10 0x00000001842E29C0-0x00000001842E2A60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24435
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24436
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 145
		}

		public enum DataResVersionOpType // TypeDefIndex: 24437
		{
			OpTypeNone = 0,
			OpTypeRelogin = 1,
			OpTypeMpRelogin = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DataResVersionNotify() {} // 0x00000001842E5760-0x00000001842E5800
	static DataResVersionNotify() {} // 0x00000001842E56A0-0x00000001842E5760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DataResVersionNotify Clone() => default; // 0x00000001842E4500-0x00000001842E45F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DataResVersionNotify ShallowCopy() => default; // 0x00000001842E3A80-0x00000001842E3B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842E2F10-0x00000001842E2F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842E47B0-0x00000001842E4830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842E48D0-0x00000001842E4950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842E2F90-0x00000001842E3130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842E34B0-0x00000001842E3580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DataResVersionNotify other) => default; // 0x00000001842E31E0-0x00000001842E34B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842E3C10-0x00000001842E3FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842E5150-0x00000001842E56A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842E4A50-0x00000001842E4D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842E3580-0x00000001842E3950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DataResVersionNotify other) {} // 0x00000001842E2AC0-0x00000001842E2DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842E27B0-0x00000001842E29C0
}

