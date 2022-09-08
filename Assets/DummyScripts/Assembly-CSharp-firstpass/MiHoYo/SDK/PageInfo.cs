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
	public sealed class PageInfo : IMessage<MiHoYo.SDK.PageInfo> // TypeDefIndex: 8827
	{
		// Fields
		private static readonly MessageParser<PageInfo> _parser; // 0x00
		public const int PagePathFieldNumber = 1; // Metadata: 0x00AE2383
		private string pagePath_; // 0x10
		public const int PageNameFieldNumber = 2; // Metadata: 0x00AE2387
		private string pageName_; // 0x18
		public const int SubPagePathFieldNumber = 3; // Metadata: 0x00AE238B
		private string subPagePath_; // 0x20
		public const int SubPageNameFieldNumber = 4; // Metadata: 0x00AE238F
		private string subPageName_; // 0x28
		public const int SourcePathFieldNumber = 5; // Metadata: 0x00AE2393
		private string sourcePath_; // 0x30
		public const int SourceNameFieldNumber = 6; // Metadata: 0x00AE2397
		private string sourceName_; // 0x38
		public const int ExtraInfoFieldNumber = 7; // Metadata: 0x00AE239B
		private static readonly MapField<string, string> _map_extraInfo_codec; // 0x08
		private readonly MapField<string, string> extraInfo_; // 0x40
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { /* [XID] */ /* 0x00000001899F6DD0-0x00000001899F6DF0 */ get => default; } // 0x0000000185A875D0-0x0000000185A876A0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageParser<PageInfo> Parser { /* [XID] */ /* 0x0000000189A34230-0x0000000189A34250 */ get => default; } // 0x0000000185A88210-0x0000000185A882E0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A3B940-0x0000000189A3B960 */ get => default; } // 0x0000000185A87F30-0x0000000185A88030 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string PagePath { /* [XID] */ /* 0x0000000189A55320-0x0000000189A55340 */ get => default; /* [XID] */ /* 0x0000000189A5CAE0-0x0000000189A5CB00 */ set {} } // 0x0000000185A88170-0x0000000185A88210 0x0000000185A88620-0x0000000185A886E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string PageName { /* [XID] */ /* 0x0000000189A64450-0x0000000189A64470 */ get => default; /* [XID] */ /* 0x0000000189A6BD20-0x0000000189A6BD40 */ set {} } // 0x0000000185A880D0-0x0000000185A88170 0x0000000185A88560-0x0000000185A88620
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string SubPagePath { /* [XID] */ /* 0x0000000189A73420-0x0000000189A73440 */ get => default; /* [XID] */ /* 0x0000000189A7B010-0x0000000189A7B030 */ set {} } // 0x0000000185A884C0-0x0000000185A88560 0x0000000185A88920-0x0000000185A889E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string SubPageName { /* [XID] */ /* 0x0000000189A82660-0x0000000189A82680 */ get => default; /* [XID] */ /* 0x00000001898E5A20-0x00000001898E5A40 */ set {} } // 0x0000000185A88420-0x0000000185A884C0 0x0000000185A88860-0x0000000185A88920
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string SourcePath { /* [XID] */ /* 0x0000000189A91720-0x0000000189A91740 */ get => default; /* [XID] */ /* 0x0000000189A99310-0x0000000189A99330 */ set {} } // 0x0000000185A88380-0x0000000185A88420 0x0000000185A887A0-0x0000000185A88860
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string SourceName { /* [XID] */ /* 0x0000000189AA0350-0x0000000189AA0370 */ get => default; /* [XID] */ /* 0x0000000189AA7B00-0x0000000189AA7B20 */ set {} } // 0x0000000185A882E0-0x0000000185A88380 0x0000000185A886E0-0x0000000185A887A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MapField<string, string> ExtraInfo { /* [XID] */ /* 0x0000000189AAF480-0x0000000189AAF4A0 */ get => default; } // 0x0000000185A88030-0x0000000185A880D0 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public PageInfo() {} // 0x0000000185A87E60-0x0000000185A87F30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public PageInfo(PageInfo other) {} // 0x0000000185A87D90-0x0000000185A87E60
		static PageInfo() {} // 0x0000000185A87C60-0x0000000185A87D90
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189A4A950-0x0000000189A4A990
		// [XID] // 0x0000000189A4A950-0x0000000189A4A990
		public PageInfo Clone() => default; // 0x0000000185A869E0-0x0000000185A86AB0
		[DebuggerNonUserCode] // 0x0000000189AB6CD0-0x0000000189AB6D20
		// [IDTag] // 0x0000000189AB6CD0-0x0000000189AB6D20
		// [XID] // 0x0000000189AB6CD0-0x0000000189AB6D20
		public override bool Equals(object other) => default; // 0x0000000185A86DD0-0x0000000185A86EA0
		[DebuggerNonUserCode] // 0x0000000189AC4890-0x0000000189AC48E0
		// [IDTag] // 0x0000000189AC4890-0x0000000189AC48E0
		// [XID] // 0x0000000189AC4890-0x0000000189AC48E0
		public bool Equals(PageInfo other) => default; // 0x0000000185A86AB0-0x0000000185A86DD0
		[DebuggerNonUserCode] // 0x0000000189AD2130-0x0000000189AD2170
		// [XID] // 0x0000000189AD2130-0x0000000189AD2170
		public override int GetHashCode() => default; // 0x0000000185A86EA0-0x0000000185A87170
		[DebuggerNonUserCode] // 0x0000000189ADD010-0x0000000189ADD050
		// [XID] // 0x0000000189ADD010-0x0000000189ADD050
		public override string ToString() => default; // 0x0000000185A876A0-0x0000000185A87770
		[DebuggerNonUserCode] // 0x0000000189AE7690-0x0000000189AE76D0
		// [XID] // 0x0000000189AE7690-0x0000000189AE76D0
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000185A87940-0x0000000185A87C60
		[DebuggerNonUserCode] // 0x0000000189AF2050-0x0000000189AF2090
		// [XID] // 0x0000000189AF2050-0x0000000189AF2090
		public int CalculateSize() => default; // 0x0000000185A86680-0x0000000185A869E0
		[DebuggerNonUserCode] // 0x0000000189AFC4F0-0x0000000189AFC540
		// [IDTag] // 0x0000000189AFC4F0-0x0000000189AFC540
		// [XID] // 0x0000000189AFC4F0-0x0000000189AFC540
		public void MergeFrom(PageInfo other) {} // 0x0000000185A87380-0x0000000185A875D0
		[DebuggerNonUserCode] // 0x0000000189B09DB0-0x0000000189B09E00
		// [IDTag] // 0x0000000189B09DB0-0x0000000189B09E00
		// [XID] // 0x0000000189B09DB0-0x0000000189B09E00
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000185A87170-0x0000000185A87380
	}
}
