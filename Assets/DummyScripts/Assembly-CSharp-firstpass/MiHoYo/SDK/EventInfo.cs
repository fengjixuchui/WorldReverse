/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public sealed class EventInfo : IMessage<MiHoYo.SDK.EventInfo> // TypeDefIndex: 8829
	{
		// Fields
		private static readonly MessageParser<EventInfo> _parser; // 0x00
		public const int TimeFieldNumber = 1; // Metadata: 0x00AE23BF
		private string time_; // 0x10
		public const int ActionIdFieldNumber = 2; // Metadata: 0x00AE23C3
		private ActionType actionId_; // 0x18
		public const int BtnNameFieldNumber = 3; // Metadata: 0x00AE23C7
		private string btnName_; // 0x20
		public const int ModuleIdFieldNumber = 4; // Metadata: 0x00AE23CB
		private string moduleId_; // 0x28
		public const int ModuleNameFieldNumber = 5; // Metadata: 0x00AE23CF
		private string moduleName_; // 0x30
		public const int IndexFieldNumber = 6; // Metadata: 0x00AE23D3
		private string index_; // 0x38
		public const int ExtraInfoFieldNumber = 7; // Metadata: 0x00AE23D7
		private static readonly MapField<string, string> _map_extraInfo_codec; // 0x08
		private readonly MapField<string, string> extraInfo_; // 0x40
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { /* [XID] */ /* 0x00000001896E4A50-0x00000001896E4A70 */ get => default; } // 0x00000001859DBB80-0x00000001859DBC50 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageParser<EventInfo> Parser { /* [XID] */ /* 0x00000001896D5C80-0x00000001896D5CA0 */ get => default; } // 0x00000001859DC980-0x00000001859DCA50 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001896DD1D0-0x00000001896DD1F0 */ get => default; } // 0x00000001859DC600-0x00000001859DC700 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Time { /* [XID] */ /* 0x00000001896F6870-0x00000001896F6890 */ get => default; /* [XID] */ /* 0x00000001896FDFA0-0x00000001896FDFC0 */ set {} } // 0x00000001859DCA50-0x00000001859DCAF0 0x00000001859DCEA0-0x00000001859DCF60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ActionType ActionId { /* [XID] */ /* 0x0000000189705310-0x0000000189705330 */ get => default; /* [XID] */ /* 0x000000018970C9F0-0x000000018970CA10 */ set {} } // 0x00000001859DC4C0-0x00000001859DC560 0x00000001859DCAF0-0x00000001859DCBA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string BtnName { /* [XID] */ /* 0x00000001897141B0-0x00000001897141D0 */ get => default; /* [XID] */ /* 0x000000018971BCC0-0x000000018971BCE0 */ set {} } // 0x00000001859DC560-0x00000001859DC600 0x00000001859DCBA0-0x00000001859DCC60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string ModuleId { /* [XID] */ /* 0x0000000189722FF0-0x0000000189723010 */ get => default; /* [XID] */ /* 0x000000018972A720-0x000000018972A740 */ set {} } // 0x00000001859DC840-0x00000001859DC8E0 0x00000001859DCD20-0x00000001859DCDE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string ModuleName { /* [XID] */ /* 0x0000000189731EC0-0x0000000189731EE0 */ get => default; /* [XID] */ /* 0x0000000189739640-0x0000000189739660 */ set {} } // 0x00000001859DC8E0-0x00000001859DC980 0x00000001859DCDE0-0x00000001859DCEA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Index { /* [XID] */ /* 0x00000001897411C0-0x00000001897411E0 */ get => default; /* [XID] */ /* 0x0000000189748A40-0x0000000189748A60 */ set {} } // 0x00000001859DC7A0-0x00000001859DC840 0x00000001859DCC60-0x00000001859DCD20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MapField<string, string> ExtraInfo { /* [XID] */ /* 0x000000018974FF60-0x000000018974FF80 */ get => default; } // 0x00000001859DC700-0x00000001859DC7A0 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EventInfo() {} // 0x00000001859DC320-0x00000001859DC3F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EventInfo(EventInfo other) {} // 0x00000001859DC3F0-0x00000001859DC4C0
		static EventInfo() {} // 0x00000001859DC1F0-0x00000001859DC320
	
		// Methods
		[DebuggerNonUserCode] // 0x00000001896EC030-0x00000001896EC070
		// [XID] // 0x00000001896EC030-0x00000001896EC070
		public EventInfo Clone() => default; // 0x00000001859DAFD0-0x00000001859DB0A0
		[DebuggerNonUserCode] // 0x0000000189757650-0x00000001897576A0
		// [IDTag] // 0x0000000189757650-0x00000001897576A0
		// [XID] // 0x0000000189757650-0x00000001897576A0
		public override bool Equals(object other) => default; // 0x00000001859DB0A0-0x00000001859DB170
		[DebuggerNonUserCode] // 0x00000001897649C0-0x0000000189764A10
		// [IDTag] // 0x00000001897649C0-0x0000000189764A10
		// [XID] // 0x00000001897649C0-0x0000000189764A10
		public bool Equals(EventInfo other) => default; // 0x00000001859DB170-0x00000001859DB460
		[DebuggerNonUserCode] // 0x0000000189772300-0x0000000189772340
		// [XID] // 0x0000000189772300-0x0000000189772340
		public override int GetHashCode() => default; // 0x00000001859DB460-0x00000001859DB750
		[DebuggerNonUserCode] // 0x000000018977C940-0x000000018977C980
		// [XID] // 0x000000018977C940-0x000000018977C980
		public override string ToString() => default; // 0x00000001859DBC50-0x00000001859DBD20
		[DebuggerNonUserCode] // 0x0000000189787190-0x00000001897871D0
		// [XID] // 0x0000000189787190-0x00000001897871D0
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001859DBEF0-0x00000001859DC1F0
		[DebuggerNonUserCode] // 0x00000001897917A0-0x00000001897917E0
		// [XID] // 0x00000001897917A0-0x00000001897917E0
		public int CalculateSize() => default; // 0x00000001859DAC90-0x00000001859DAFD0
		[DebuggerNonUserCode] // 0x000000018979C800-0x000000018979C850
		// [IDTag] // 0x000000018979C800-0x000000018979C850
		// [XID] // 0x000000018979C800-0x000000018979C850
		public void MergeFrom(EventInfo other) {} // 0x00000001859DB750-0x00000001859DB980
		[DebuggerNonUserCode] // 0x00000001897A9B30-0x00000001897A9B80
		// [IDTag] // 0x00000001897A9B30-0x00000001897A9B80
		// [XID] // 0x00000001897A9B30-0x00000001897A9B80
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001859DB980-0x00000001859DBB80
	}
}
