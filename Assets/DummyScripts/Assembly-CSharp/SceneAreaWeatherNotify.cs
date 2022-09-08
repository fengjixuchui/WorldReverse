/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAreaWeatherNotify : MessageBase, IMessage<SceneAreaWeatherNotify> // TypeDefIndex: 25023
{
	// Fields
	private static readonly MessageParser<SceneAreaWeatherNotify> _parser; // 0x00
	public const int WeatherGadgetIdFieldNumber = 1; // Metadata: 0x00B07CB7
	private uint weatherGadgetId_; // 0x18
	public const int WeatherValueMapFieldNumber = 2; // Metadata: 0x00B07CBB
	private static readonly MapField<uint, string> _map_weatherValueMap_codec; // 0x08
	private readonly MapField<uint, string> weatherValueMap_; // 0x20
	public const int WeatherAreaIdFieldNumber = 3; // Metadata: 0x00B07CBF
	private uint weatherAreaId_; // 0x28
	public const int ClimateTypeFieldNumber = 4; // Metadata: 0x00B07CC3
	private uint climateType_; // 0x2C
	public const int TransDurationFieldNumber = 5; // Metadata: 0x00B07CC7
	private float transDuration_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAreaWeatherNotify> Parser { get => default; } // 0x0000000181DBA560-0x0000000181DBA5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181DBA150-0x0000000181DBA1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181DB9D50-0x0000000181DB9DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181DB9270-0x0000000181DB92D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DBAA80-0x0000000181DBAB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181DBA720-0x0000000181DBA780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181DBA280-0x0000000181DBA370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DBAA30-0x0000000181DBAA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181DB9E70-0x0000000181DB9F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeatherGadgetId { get => default; set {} } // 0x0000000181DB9660-0x0000000181DB9700 0x0000000181DBA1E0-0x0000000181DBA280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, string> WeatherValueMap { get => default; } // 0x0000000181DBA500-0x0000000181DBA560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeatherAreaId { get => default; set {} } // 0x0000000181DB9700-0x0000000181DB97A0 0x0000000181DB9CB0-0x0000000181DB9D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClimateType { get => default; set {} } // 0x0000000181DB9C10-0x0000000181DB9CB0 0x0000000181DB95C0-0x0000000181DB9660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float TransDuration { get => default; set {} } // 0x0000000181DBA460-0x0000000181DBA500 0x0000000181DBA780-0x0000000181DBA820

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25024
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25025
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 244
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaWeatherNotify() {} // 0x0000000181DBB030-0x0000000181DBB0C0
	static SceneAreaWeatherNotify() {} // 0x0000000181DBAF00-0x0000000181DBB030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaWeatherNotify Clone() => default; // 0x0000000181DBA370-0x0000000181DBA460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaWeatherNotify ShallowCopy() => default; // 0x0000000181DB9DD0-0x0000000181DB9E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181DB9480-0x0000000181DB94D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DBA680-0x0000000181DBA6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DBA6D0-0x0000000181DBA720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181DB94D0-0x0000000181DB95C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181DB9950-0x0000000181DB9A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAreaWeatherNotify other) => default; // 0x0000000181DB97A0-0x0000000181DB9950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181DB9F60-0x0000000181DBA150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DBAB70-0x0000000181DBAF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181DBA820-0x0000000181DBAA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181DB9A20-0x0000000181DB9C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAreaWeatherNotify other) {} // 0x0000000181DB92D0-0x0000000181DB9480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181DB90B0-0x0000000181DB9270
}

