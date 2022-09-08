/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetSceneWeatherAreaReq : MessageBase, IMessage<SetSceneWeatherAreaReq> // TypeDefIndex: 25173
{
	// Fields
	private static readonly MessageParser<SetSceneWeatherAreaReq> _parser; // 0x00
	public const int WeatherGadgetIdFieldNumber = 1; // Metadata: 0x00B08237
	private uint weatherGadgetId_; // 0x18
	public const int WeatherValueMapFieldNumber = 2; // Metadata: 0x00B0823B
	private static readonly MapField<uint, string> _map_weatherValueMap_codec; // 0x08
	private readonly MapField<uint, string> weatherValueMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetSceneWeatherAreaReq> Parser { get => default; } // 0x00000001843DC3A0-0x00000001843DC430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843DC030-0x00000001843DC0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843DBCE0-0x00000001843DBD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843DB650-0x00000001843DB6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843DC750-0x00000001843DC840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843DC560-0x00000001843DC5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843DC160-0x00000001843DC250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843DC700-0x00000001843DC750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843DBE00-0x00000001843DBEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeatherGadgetId { get => default; set {} } // 0x00000001843DB8F0-0x00000001843DB990 0x00000001843DC0C0-0x00000001843DC160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, string> WeatherValueMap { get => default; } // 0x00000001843DC340-0x00000001843DC3A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25174
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25175
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 291
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetSceneWeatherAreaReq() {} // 0x00000001843DCB50-0x00000001843DCBE0
	static SetSceneWeatherAreaReq() {} // 0x00000001843DCA20-0x00000001843DCB50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetSceneWeatherAreaReq Clone() => default; // 0x00000001843DC250-0x00000001843DC340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetSceneWeatherAreaReq ShallowCopy() => default; // 0x00000001843DBD60-0x00000001843DBE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843DB7E0-0x00000001843DB830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843DC4C0-0x00000001843DC510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843DC510-0x00000001843DC560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843DB830-0x00000001843DB8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843DB990-0x00000001843DBA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetSceneWeatherAreaReq other) => default; // 0x00000001843DBA60-0x00000001843DBBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843DBEF0-0x00000001843DC030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843DC840-0x00000001843DCA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843DC5C0-0x00000001843DC700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843DBBA0-0x00000001843DBCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetSceneWeatherAreaReq other) {} // 0x00000001843DB6B0-0x00000001843DB7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843DB4F0-0x00000001843DB650
}

