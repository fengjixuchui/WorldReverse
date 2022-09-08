/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using MoleMole.Audio.Music.Miiha;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Logging
{
	public static class AudioLog // TypeDefIndex: 11109
	{
		// Fields
		private static readonly List<LogRecord> _stashedRecords; // 0x00
		private static readonly LogRecordPrinter _recordPrinter; // 0x08
		private static readonly Dictionary<TextColor, string> _textColorLiterals; // 0x28
		private static readonly char[] _hexDigits; // 0x30
		private static readonly Dictionary<System.Type, AudioLogModuleControlNode> _typeLogLut; // 0x38
		private static readonly Dictionary<int, AudioLogMethodControlNode> _methodLogLut; // 0x40
		private static readonly AudioLogModuleControlNode _rootTypeStatusNode; // 0x48
	
		// Properties
		private static DateTime _initializationTimestamp { /* [XID] */ /* 0x000000018991CAF0-0x000000018991CB30 */ get; /* [XID] */ /* 0x00000001899271E0-0x0000000189927220 */ set; } // 0x0000000184E80130-0x0000000184E801C0 0x0000000184E80410-0x0000000184E804B0
		public static int frameCount { /* [XID] */ /* 0x00000001899316F0-0x0000000189931720 */ get; /* [XID] */ /* 0x000000018993C0F0-0x000000018993C130 */ set; } // 0x0000000184E802B0-0x0000000184E80340 0x0000000184E804B0-0x0000000184E80540
		public static bool enabled { /* [XID] */ /* 0x00000001899464B0-0x00000001899464D0 */ get; } // 0x0000000184E801C0-0x0000000184E802B0 
		public static AudioLogModuleControlNode logStatusRootNode { /* [XID] */ /* 0x00000001896C8710-0x00000001896C8730 */ get; } // 0x0000000184E80340-0x0000000184E80410 
	
		// Nested types
		public static class CompilationSymbols // TypeDefIndex: 11110
		{
			// Fields
			public const string EDITOR = "UNITY_EDITOR"; // Metadata: 0x00AE8BA1
			public const string DEBUG = "NG_HSOD_DEBUG"; // Metadata: 0x00AE8BB1
		}
	
		private struct ReusedStringBuilder : IDisposable // TypeDefIndex: 11111
		{
			// Fields
			private readonly StringBuilder _builder; // 0x00
	
			// Properties
			public StringBuilder builder { /* [XID] */ /* 0x0000000189A2B390-0x0000000189A2B3B0 */ get => default; } // 0x0000000186732BE0-0x0000000186732C00 
	
			// Constructors
			public ReusedStringBuilder(bool doesntMatter) : this() {
				_builder = default;
			} // 0x0000000186732B30-0x0000000186732BE0
	
			// Methods
			// [IDTag] // 0x0000000189A6BC00-0x0000000189A6BC40
			// [XID] // 0x0000000189A6BC00-0x0000000189A6BC40
			public ReusedStringBuilder Append(char value, int repeatCount) => default; // 0x0000000186731840-0x0000000186731920
			// [IDTag] // 0x0000000189A76330-0x0000000189A76370
			// [XID] // 0x0000000189A76330-0x0000000189A76370
			public ReusedStringBuilder Append(char value) => default; // 0x0000000186732160-0x0000000186732240
			// [IDTag] // 0x0000000189A80AE0-0x0000000189A80B20
			// [XID] // 0x0000000189A80AE0-0x0000000189A80B20
			public ReusedStringBuilder Append(ulong value) => default; // 0x0000000186731920-0x0000000186731A00
			// [IDTag] // 0x0000000189A8B700-0x0000000189A8B740
			// [XID] // 0x0000000189A8B700-0x0000000189A8B740
			public ReusedStringBuilder Append(uint value) => default; // 0x00000001867325E0-0x00000001867326C0
			// [IDTag] // 0x0000000189A95B50-0x0000000189A95B90
			// [XID] // 0x0000000189A95B50-0x0000000189A95B90
			public ReusedStringBuilder Append(ushort value) => default; // 0x00000001867327A0-0x0000000186732880
			// [IDTag] // 0x0000000189AA01D0-0x0000000189AA0210
			// [XID] // 0x0000000189AA01D0-0x0000000189AA0210
			public ReusedStringBuilder Append(float value) => default; // 0x0000000186732080-0x0000000186732160
			// [IDTag] // 0x0000000189AAA5D0-0x0000000189AAA610
			// [XID] // 0x0000000189AAA5D0-0x0000000189AAA610
			public ReusedStringBuilder Append(sbyte value) => default; // 0x0000000186731BC0-0x0000000186731CD0
			// [IDTag] // 0x0000000189A67780-0x0000000189A677C0
			// [XID] // 0x0000000189A67780-0x0000000189A677C0
			public ReusedStringBuilder Append(object value) => default; // 0x0000000186731A00-0x0000000186731AE0
			// [IDTag] // 0x0000000189ABFC00-0x0000000189ABFC40
			// [XID] // 0x0000000189ABFC00-0x0000000189ABFC40
			public ReusedStringBuilder Append(long value) => default; // 0x0000000186731FA0-0x0000000186732080
			// [IDTag] // 0x0000000189ACA550-0x0000000189ACA590
			// [XID] // 0x0000000189ACA550-0x0000000189ACA590
			public ReusedStringBuilder Append(int value) => default; // 0x0000000186732240-0x0000000186732320
			// [IDTag] // 0x0000000189AD54E0-0x0000000189AD5520
			// [XID] // 0x0000000189AD54E0-0x0000000189AD5520
			public ReusedStringBuilder Append(short value) => default; // 0x0000000186731EC0-0x0000000186731FA0
			// [IDTag] // 0x0000000189ADFEE0-0x0000000189ADFF20
			// [XID] // 0x0000000189ADFEE0-0x0000000189ADFF20
			public ReusedStringBuilder Append(double value) => default; // 0x0000000186732400-0x00000001867324F0
			// [IDTag] // 0x0000000189AEA450-0x0000000189AEA490
			// [XID] // 0x0000000189AEA450-0x0000000189AEA490
			public ReusedStringBuilder Append(decimal value) => default; // 0x00000001867324F0-0x00000001867325E0
			// [IDTag] // 0x0000000189AF4DE0-0x0000000189AF4E20
			// [XID] // 0x0000000189AF4DE0-0x0000000189AF4E20
			public ReusedStringBuilder Append(byte value) => default; // 0x00000001867326C0-0x00000001867327A0
			// [IDTag] // 0x0000000189AFF4D0-0x0000000189AFF510
			// [XID] // 0x0000000189AFF4D0-0x0000000189AFF510
			public ReusedStringBuilder Append(bool value) => default; // 0x0000000186732880-0x0000000186732930
			// [IDTag] // 0x0000000189B09CA0-0x0000000189B09CE0
			// [XID] // 0x0000000189B09CA0-0x0000000189B09CE0
			public ReusedStringBuilder Append(string value) => default; // 0x0000000186732320-0x0000000186732400
			// [IDTag] // 0x0000000189B14060-0x0000000189B140A0
			// [XID] // 0x0000000189B14060-0x0000000189B140A0
			public ReusedStringBuilder Append(char[] value) => default; // 0x0000000186731AE0-0x0000000186731BC0
			// [IDTag] // 0x0000000189B1E580-0x0000000189B1E5C0
			// [XID] // 0x0000000189B1E580-0x0000000189B1E5C0
			public ReusedStringBuilder Append(char[] value, int startIndex, int charCount) => default; // 0x0000000186731DE0-0x0000000186731EC0
			// [IDTag] // 0x0000000189B28C20-0x0000000189B28C60
			// [XID] // 0x0000000189B28C20-0x0000000189B28C60
			public ReusedStringBuilder Append(string value, int startIndex, int count) => default; // 0x0000000186731CD0-0x0000000186731DE0
			// [IDTag] // 0x0000000189B32F90-0x0000000189B32FD0
			// [XID] // 0x0000000189B32F90-0x0000000189B32FD0
			public ReusedStringBuilder AppendWithColor(char value, int repeatCount, TextColor color) => default; // 0x0000000186730C20-0x0000000186730D80
			// [IDTag] // 0x0000000189B3D6A0-0x0000000189B3D6E0
			// [XID] // 0x0000000189B3D6A0-0x0000000189B3D6E0
			public ReusedStringBuilder AppendWithColor(char value, TextColor color) => default; // 0x00000001867300E0-0x0000000186730240
			// [IDTag] // 0x0000000189B48330-0x0000000189B48370
			// [XID] // 0x0000000189B48330-0x0000000189B48370
			public ReusedStringBuilder AppendWithColor(ulong value, TextColor color) => default; // 0x00000001867307F0-0x0000000186730950
			// [IDTag] // 0x0000000189B52940-0x0000000189B52980
			// [XID] // 0x0000000189B52940-0x0000000189B52980
			public ReusedStringBuilder AppendWithColor(uint value, TextColor color) => default; // 0x0000000186731300-0x0000000186731460
			// [IDTag] // 0x0000000189B5D3F0-0x0000000189B5D430
			// [XID] // 0x0000000189B5D3F0-0x0000000189B5D430
			public ReusedStringBuilder AppendWithColor(ushort value, TextColor color) => default; // 0x0000000186731460-0x00000001867315F0
			// [IDTag] // 0x0000000189B67C30-0x0000000189B67C70
			// [XID] // 0x0000000189B67C30-0x0000000189B67C70
			public ReusedStringBuilder AppendWithColor(float value, TextColor color) => default; // 0x00000001867303A0-0x0000000186730500
			// [IDTag] // 0x0000000189B722C0-0x0000000189B72300
			// [XID] // 0x0000000189B722C0-0x0000000189B72300
			public ReusedStringBuilder AppendWithColor(sbyte value, TextColor color) => default; // 0x0000000186730D80-0x0000000186730EE0
			// [IDTag] // 0x0000000189B7C3F0-0x0000000189B7C430
			// [XID] // 0x0000000189B7C3F0-0x0000000189B7C430
			public ReusedStringBuilder AppendWithColor(object value, TextColor color) => default; // 0x000000018672FF80-0x00000001867300E0
			// [IDTag] // 0x0000000189B86FD0-0x0000000189B87010
			// [XID] // 0x0000000189B86FD0-0x0000000189B87010
			public ReusedStringBuilder AppendWithColor(long value, TextColor color) => default; // 0x0000000186730500-0x0000000186730680
			// [IDTag] // 0x0000000189B913E0-0x0000000189B91420
			// [XID] // 0x0000000189B913E0-0x0000000189B91420
			public ReusedStringBuilder AppendWithColor(int value, TextColor color) => default; // 0x0000000186731750-0x0000000186731840
			// [IDTag] // 0x0000000189B9B670-0x0000000189B9B6B0
			// [XID] // 0x0000000189B9B670-0x0000000189B9B6B0
			public ReusedStringBuilder AppendWithColor(short value, TextColor color) => default; // 0x0000000186730AB0-0x0000000186730C20
			// [IDTag] // 0x0000000189BA5BB0-0x0000000189BA5BF0
			// [XID] // 0x0000000189BA5BB0-0x0000000189BA5BF0
			public ReusedStringBuilder AppendWithColor(double value, TextColor color) => default; // 0x0000000186731040-0x00000001867311A0
			// [IDTag] // 0x0000000189BAFC40-0x0000000189BAFC80
			// [XID] // 0x0000000189BAFC40-0x0000000189BAFC80
			public ReusedStringBuilder AppendWithColor(decimal value, TextColor color) => default; // 0x0000000186730680-0x00000001867307F0
			// [IDTag] // 0x0000000189BBA300-0x0000000189BBA340
			// [XID] // 0x0000000189BBA300-0x0000000189BBA340
			public ReusedStringBuilder AppendWithColor(byte value, TextColor color) => default; // 0x00000001867311A0-0x0000000186731300
			// [IDTag] // 0x0000000189BC4FA0-0x0000000189BC4FE0
			// [XID] // 0x0000000189BC4FA0-0x0000000189BC4FE0
			public ReusedStringBuilder AppendWithColor(bool value, TextColor color) => default; // 0x0000000186730EE0-0x0000000186731040
			// [IDTag] // 0x0000000189BCF990-0x0000000189BCF9D0
			// [XID] // 0x0000000189BCF990-0x0000000189BCF9D0
			public ReusedStringBuilder AppendWithColor(string value, TextColor color) => default; // 0x0000000186730240-0x00000001867303A0
			// [IDTag] // 0x0000000189BD9EF0-0x0000000189BD9F30
			// [XID] // 0x0000000189BD9EF0-0x0000000189BD9F30
			public ReusedStringBuilder AppendWithColor(char[] value, TextColor color) => default; // 0x0000000186730950-0x0000000186730AB0
			// [IDTag] // 0x00000001895E9C00-0x00000001895E9C40
			// [XID] // 0x00000001895E9C00-0x00000001895E9C40
			public ReusedStringBuilder AppendWithColor(char[] value, int startIndex, int charCount, TextColor color) => default; // 0x00000001867315F0-0x0000000186731750
			// [IDTag] // 0x00000001895F43B0-0x00000001895F43F0
			// [XID] // 0x00000001895F43B0-0x00000001895F43F0
			public ReusedStringBuilder AppendFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x000000018672F960-0x000000018672FA70
			// [IDTag] // 0x0000000189606370-0x00000001896063B0
			// [XID] // 0x0000000189606370-0x00000001896063B0
			public ReusedStringBuilder AppendFormat(IFormatProvider provider, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x000000018672FA70-0x000000018672FB60
			// [IDTag] // 0x0000000189617FD0-0x0000000189618010
			// [XID] // 0x0000000189617FD0-0x0000000189618010
			public ReusedStringBuilder AppendFormat(string format, object arg0) => default; // 0x000000018672FB60-0x000000018672FC70
			// [IDTag] // 0x0000000189622840-0x0000000189622880
			// [XID] // 0x0000000189622840-0x0000000189622880
			public ReusedStringBuilder AppendFormat(string format, object arg0, object arg1) => default; // 0x000000018672FC70-0x000000018672FD40
			// [IDTag] // 0x000000018962CFD0-0x000000018962D010
			// [XID] // 0x000000018962CFD0-0x000000018962D010
			public ReusedStringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) => default; // 0x000000018672F870-0x000000018672F960
			// [IDTag] // 0x0000000189637E40-0x0000000189637E80
			// [XID] // 0x0000000189637E40-0x0000000189637E80
			public ReusedStringBuilder AppendLine(string value) => default; // 0x000000018672FE20-0x000000018672FF80
			// [IDTag] // 0x0000000189A5CCD0-0x0000000189A5CD10
			// [XID] // 0x0000000189A5CCD0-0x0000000189A5CD10
			public ReusedStringBuilder AppendLine() => default; // 0x000000018672FD40-0x000000018672FE20
			// [XID] // 0x0000000189A79610-0x0000000189A79630
			public void Dispose() {} // 0x0000000186732930-0x0000000186732A00
			// [XID] // 0x0000000189654010-0x0000000189654030
			public override string ToString() => default; // 0x0000000186732A00-0x0000000186732AA0
		}
	
		private enum TextColor // TypeDefIndex: 11112
		{
			Lime = 0,
			Green = 1,
			Orange = 2,
			Magenta = 3,
			Yellow = 4,
			Red = 5,
			Blue = 6,
			Cyan = 7,
			White = 8
		}
	
		private class TextColorEqualityComparer : IEqualityComparer<TextColor> // TypeDefIndex: 11113
		{
			// Constructors
			public TextColorEqualityComparer() {} // 0x00000001867372C0-0x0000000186737320
	
			// Methods
			// [XID] // 0x000000018965BA50-0x000000018965BA70
			public bool Equals(TextColor x, TextColor y) => default; // 0x0000000186737140-0x0000000186737210
			// [XID] // 0x00000001897C9D20-0x00000001897C9D40
			public int GetHashCode(TextColor obj) => default; // 0x0000000186737210-0x00000001867372C0
		}
	
		private struct TemparoryTextColor : IDisposable // TypeDefIndex: 11114
		{
			// Fields
			private readonly StringBuilder _builder; // 0x00
	
			// Constructors
			public TemparoryTextColor(StringBuilder builder, TextColor color) {
				_builder = default;
			} // 0x0000000186737110-0x0000000186737140
	
			// Methods
			// [XID] // 0x0000000189B24830-0x0000000189B24850
			public void Dispose() {} // 0x0000000186736F90-0x0000000186737110
		}
	
		public struct Int32BytesUnion // TypeDefIndex: 11115
		{
			// Fields
			public int iValue; // 0x00
			public byte b0; // 0x00
			public byte b1; // 0x01
			public byte b2; // 0x02
			public byte b3; // 0x03
		}
	
		private class MemberInfoComparer<T> : IComparer<T> // TypeDefIndex: 11116
			where T : MemberInfo
		{
			// Constructors
			public MemberInfoComparer() {}
	
			// Methods
			public int Compare(T x, T y) => default;
		}
	
		private struct LogMethodAttributes : IDisposable // TypeDefIndex: 11117
		{
			// Fields
			private readonly MethodBase _method; // 0x00
	
			// Properties
			public bool enabled { /* [XID] */ /* 0x0000000189672590-0x00000001896725B0 */ get => default; } // 0x0000000184E921E0-0x0000000184E92290 
			public MethodBase method { /* [XID] */ /* 0x0000000189679E20-0x0000000189679E40 */ get => default; } // 0x0000000184E92290-0x0000000184E922C0 
	
			// Constructors
			public LogMethodAttributes(MethodBase method) : this() {
				_method = default;
			} // 0x0000000184E920B0-0x0000000184E921E0
	
			// Methods
			// [XID] // 0x0000000189681500-0x0000000189681520
			public void Dispose() {} // 0x0000000184E92040-0x0000000184E920B0
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Ambience // TypeDefIndex: 11118
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Area2D // TypeDefIndex: 11119
			{
				// Methods
				[AudioLogMethod] // 0x00000001896983C0-0x0000000189698420
				// [Conditional] // 0x00000001896983C0-0x0000000189698420
				// [XID] // 0x00000001896983C0-0x0000000189698420
				public static void LogEnterArea(string areaName) {} // 0x0000000184E7C6A0-0x0000000184E7C9A0
				[AudioLogMethod] // 0x00000001896A5230-0x00000001896A5290
				// [Conditional] // 0x00000001896A5230-0x00000001896A5290
				// [XID] // 0x00000001896A5230-0x00000001896A5290
				public static void LogLeaveArea(string areaName) {} // 0x0000000184E7C9A0-0x0000000184E7CCA0
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Dynamic // TypeDefIndex: 11120
			{
				// Methods
				[AudioLogMethod] // 0x00000001896B9C80-0x00000001896B9CE0
				// [Conditional] // 0x00000001896B9C80-0x00000001896B9CE0
				// [XID] // 0x00000001896B9C80-0x00000001896B9CE0
				public static void LogUnstablePlaceholder(MonoAmbientAudioPlaceholder mono, Vector3 previousPosition) {} // 0x0000000184E8AA20-0x0000000184E8AE90
				[AudioLogMethod] // 0x00000001896C70B0-0x00000001896C7110
				// [Conditional] // 0x00000001896C70B0-0x00000001896C7110
				// [XID] // 0x00000001896C70B0-0x00000001896C7110
				public static void LogSelectedPlaceholder(MonoAmbientAudioPlaceholder mono) {} // 0x0000000184E893B0-0x0000000184E89760
				[AudioLogMethod] // 0x00000001896D4180-0x00000001896D41E0
				// [Conditional] // 0x00000001896D4180-0x00000001896D41E0
				// [XID] // 0x00000001896D4180-0x00000001896D41E0
				public static void LogAddDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000184E832A0-0x0000000184E83780
				[AudioLogMethod] // 0x00000001896E1B00-0x00000001896E1B60
				// [Conditional] // 0x00000001896E1B00-0x00000001896E1B60
				// [XID] // 0x00000001896E1B00-0x00000001896E1B60
				public static void LogReviveOutfieldDynamicObject(int id, bool illegalIntrusion) {} // 0x0000000184E89090-0x0000000184E893B0
				[AudioLogMethod] // 0x00000001896EECE0-0x00000001896EED40
				// [Conditional] // 0x00000001896EECE0-0x00000001896EED40
				// [XID] // 0x00000001896EECE0-0x00000001896EED40
				public static void LogSkipSamePosition() {} // 0x0000000184E89760-0x0000000184E899B0
				[AudioLogMethod] // 0x00000001896FC4B0-0x00000001896FC510
				// [Conditional] // 0x00000001896FC4B0-0x00000001896FC510
				// [XID] // 0x00000001896FC4B0-0x00000001896FC510
				public static void LogInconsistentPrefabHash(ulong previous, ulong current) {} // 0x0000000184E85D10-0x0000000184E85FE0
				[AudioLogMethod] // 0x0000000189709A60-0x0000000189709AC0
				// [Conditional] // 0x0000000189709A60-0x0000000189709AC0
				// [XID] // 0x0000000189709A60-0x0000000189709AC0
				public static void LogOptimisticDrop(int id) {} // 0x0000000184E876D0-0x0000000184E87920
				[AudioLogMethod] // 0x0000000189716ED0-0x0000000189716F30
				// [Conditional] // 0x0000000189716ED0-0x0000000189716F30
				// [XID] // 0x0000000189716ED0-0x0000000189716F30
				public static void LogUpdatePositionResult(int id, bool result) {} // 0x0000000184E8B3D0-0x0000000184E8B700
				[AudioLogMethod] // 0x00000001897245D0-0x0000000189724630
				// [Conditional] // 0x00000001897245D0-0x0000000189724630
				// [XID] // 0x00000001897245D0-0x0000000189724630
				public static void LogInvalidPrefab() {} // 0x0000000184E86660-0x0000000184E86950
				[AudioLogMethod] // 0x0000000189731D60-0x0000000189731DC0
				// [Conditional] // 0x0000000189731D60-0x0000000189731DC0
				// [XID] // 0x0000000189731D60-0x0000000189731DC0
				public static void LogOutcastDynamicObject(int id) {} // 0x0000000184E87920-0x0000000184E87C30
				[AudioLogMethod] // 0x000000018973FA40-0x000000018973FAA0
				// [Conditional] // 0x000000018973FA40-0x000000018973FAA0
				// [XID] // 0x000000018973FA40-0x000000018973FAA0
				public static void LogAddedDynamicObject(int id) {} // 0x0000000184E83DD0-0x0000000184E840D0
				[AudioLogMethod] // 0x000000018974D130-0x000000018974D190
				// [Conditional] // 0x000000018974D130-0x000000018974D190
				// [XID] // 0x000000018974D130-0x000000018974D190
				public static void LogUnknownId(int id) {} // 0x0000000184E8A720-0x0000000184E8AA20
				[AudioLogMethod] // 0x0000000189759FE0-0x000000018975A040
				// [Conditional] // 0x0000000189759FE0-0x000000018975A040
				// [XID] // 0x0000000189759FE0-0x000000018975A040
				public static void LogRemoveDynamicObject(int id) {} // 0x0000000184E88410-0x0000000184E88730
				[AudioLogMethod] // 0x00000001897677A0-0x0000000189767800
				// [Conditional] // 0x00000001897677A0-0x0000000189767800
				// [XID] // 0x00000001897677A0-0x0000000189767800
				public static void LogRemoveOutfieldDynamicObject(int id) {} // 0x0000000184E88A70-0x0000000184E88D80
				[AudioLogMethod] // 0x0000000189774E20-0x0000000189774E80
				// [Conditional] // 0x0000000189774E20-0x0000000189774E80
				// [XID] // 0x0000000189774E20-0x0000000189774E80
				public static void LogRemoveResult(bool result) {} // 0x0000000184E88D80-0x0000000184E89090
				[AudioLogMethod] // 0x0000000189782B20-0x0000000189782B80
				// [Conditional] // 0x0000000189782B20-0x0000000189782B80
				// [XID] // 0x0000000189782B20-0x0000000189782B80
				public static void LogTickUpdate(Vector3 listenerPosition) {} // 0x0000000184E899B0-0x0000000184E89CE0
				[AudioLogMethod] // 0x000000018978FDC0-0x000000018978FE20
				// [Conditional] // 0x000000018978FDC0-0x000000018978FE20
				// [XID] // 0x000000018978FDC0-0x000000018978FE20
				public static void LogClearDynamicObjects() {} // 0x0000000184E84F00-0x0000000184E85150
				[AudioLogMethod] // 0x000000018979DF70-0x000000018979DFD0
				// [Conditional] // 0x000000018979DF70-0x000000018979DFD0
				// [XID] // 0x000000018979DF70-0x000000018979DFD0
				public static void LogQueryResult(HashSet<AudioDynamicAmbientObject> activeSet, HashSet<AudioDynamicAmbientObject> challengerSet) {} // 0x0000000184E87C30-0x0000000184E88410
				[AudioLogMethod] // 0x00000001897AAF00-0x00000001897AAF60
				// [Conditional] // 0x00000001897AAF00-0x00000001897AAF60
				// [XID] // 0x00000001897AAF00-0x00000001897AAF60
				public static void LogChanges(HashSet<AudioDynamicAmbientObject> instantiateList, HashSet<AudioDynamicAmbientObject> recycleList) {} // 0x0000000184E84720-0x0000000184E84F00
				[AudioLogMethod] // 0x00000001897B8E00-0x00000001897B8E60
				// [Conditional] // 0x00000001897B8E00-0x00000001897B8E60
				// [XID] // 0x00000001897B8E00-0x00000001897B8E60
				public static void LogTryInstantiate(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E89CE0-0x0000000184E8A030
				[AudioLogMethod] // 0x00000001897C7090-0x00000001897C70F0
				// [Conditional] // 0x00000001897C7090-0x00000001897C70F0
				// [XID] // 0x00000001897C7090-0x00000001897C70F0
				public static void LogInstanceExist(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E85FE0-0x0000000184E86320
				[AudioLogMethod] // 0x00000001897D44A0-0x00000001897D4500
				// [Conditional] // 0x00000001897D44A0-0x00000001897D4500
				// [XID] // 0x00000001897D44A0-0x00000001897D4500
				public static void LogAlreadyWating(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E840D0-0x0000000184E84410
				[AudioLogMethod] // 0x00000001897E1E80-0x00000001897E1EE0
				// [Conditional] // 0x00000001897E1E80-0x00000001897E1EE0
				// [XID] // 0x00000001897E1E80-0x00000001897E1EE0
				public static void LogInvalidPathHash(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E86320-0x0000000184E86660
				[AudioLogMethod] // 0x00000001897EF8A0-0x00000001897EF900
				// [Conditional] // 0x00000001897EF8A0-0x00000001897EF900
				// [XID] // 0x00000001897EF8A0-0x00000001897EF900
				public static void LogAddRequest(AmbientSpawnRequest request) {} // 0x0000000184E83AC0-0x0000000184E83DD0
				[AudioLogMethod] // 0x00000001897FD020-0x00000001897FD080
				// [Conditional] // 0x00000001897FD020-0x00000001897FD080
				// [XID] // 0x00000001897FD020-0x00000001897FD080
				public static void LogTryUpdate(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E8A380-0x0000000184E8A720
				[AudioLogMethod] // 0x000000018980A6A0-0x000000018980A700
				// [Conditional] // 0x000000018980A6A0-0x000000018980A700
				// [XID] // 0x000000018980A6A0-0x000000018980A700
				public static void LogUpdateInstance() {} // 0x0000000184E8B180-0x0000000184E8B3D0
				[AudioLogMethod] // 0x0000000189817DE0-0x0000000189817E40
				// [Conditional] // 0x0000000189817DE0-0x0000000189817E40
				// [XID] // 0x0000000189817DE0-0x0000000189817E40
				public static void LogUpdateWaitingRequest() {} // 0x0000000184E8B700-0x0000000184E8B9C0
				[AudioLogMethod] // 0x0000000189825380-0x00000001898253E0
				// [Conditional] // 0x0000000189825380-0x00000001898253E0
				// [XID] // 0x0000000189825380-0x00000001898253E0
				public static void LogUpdateFailed() {} // 0x0000000184E8AE90-0x0000000184E8B180
				[AudioLogMethod] // 0x0000000189832980-0x00000001898329E0
				// [Conditional] // 0x0000000189832980-0x00000001898329E0
				// [XID] // 0x0000000189832980-0x00000001898329E0
				public static void LogTryRemove(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E8A030-0x0000000184E8A380
				[AudioLogMethod] // 0x000000018983FF00-0x000000018983FF60
				// [Conditional] // 0x000000018983FF00-0x000000018983FF60
				// [XID] // 0x000000018983FF00-0x000000018983FF60
				public static void LogCancelRequest(AmbientSpawnRequest request) {} // 0x0000000184E84410-0x0000000184E84720
				[AudioLogMethod] // 0x000000018984D480-0x000000018984D4E0
				// [Conditional] // 0x000000018984D480-0x000000018984D4E0
				// [XID] // 0x000000018984D480-0x000000018984D4E0
				public static void LogNoSuchInstance(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E87390-0x0000000184E876D0
				[AudioLogMethod] // 0x000000018985A8A0-0x000000018985A900
				// [Conditional] // 0x000000018985A8A0-0x000000018985A900
				// [XID] // 0x000000018985A8A0-0x000000018985A900
				public static void LogRemoveInstance(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E88730-0x0000000184E88A70
				[AudioLogMethod] // 0x0000000189867970-0x00000001898679D0
				// [Conditional] // 0x0000000189867970-0x00000001898679D0
				// [XID] // 0x0000000189867970-0x00000001898679D0
				public static void LogLoadCallback(ulong pathHash, bool success, uint handle, GameObject go) {} // 0x0000000184E86950-0x0000000184E86D90
				[AudioLogMethod] // 0x0000000189874B50-0x0000000189874BB0
				// [Conditional] // 0x0000000189874B50-0x0000000189874BB0
				// [XID] // 0x0000000189874B50-0x0000000189874BB0
				public static void LogNoRequestWaiting() {} // 0x0000000184E870A0-0x0000000184E87390
				[AudioLogMethod] // 0x00000001898820C0-0x0000000189882120
				// [Conditional] // 0x00000001898820C0-0x0000000189882120
				// [XID] // 0x00000001898820C0-0x0000000189882120
				public static void LogFailedMinimum() {} // 0x0000000184E85A20-0x0000000184E85D10
				[AudioLogMethod] // 0x000000018988F600-0x000000018988F660
				// [Conditional] // 0x000000018988F600-0x000000018988F660
				// [XID] // 0x000000018988F600-0x000000018988F660
				public static void LogMinimumKey(AmbientSpawnRequest request) {} // 0x0000000184E86D90-0x0000000184E870A0
				[AudioLogMethod] // 0x000000018989C9D0-0x000000018989CA30
				// [Conditional] // 0x000000018989C9D0-0x000000018989CA30
				// [XID] // 0x000000018989C9D0-0x000000018989CA30
				public static void LogAbandonPrefab() {} // 0x0000000184E82FB0-0x0000000184E832A0
				[AudioLogMethod] // 0x00000001898A9E40-0x00000001898A9EA0
				// [Conditional] // 0x00000001898A9E40-0x00000001898A9EA0
				// [XID] // 0x00000001898A9E40-0x00000001898A9EA0
				public static void LogCreateFolding() {} // 0x0000000184E85760-0x0000000184E85A20
				[AudioLogMethod] // 0x00000001898B7590-0x00000001898B75F0
				// [Conditional] // 0x00000001898B7590-0x00000001898B75F0
				// [XID] // 0x00000001898B7590-0x00000001898B75F0
				public static void LogAddInstance(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E83780-0x0000000184E83AC0
				[AudioLogMethod] // 0x00000001898C4F60-0x00000001898C4FC0
				// [Conditional] // 0x00000001898C4F60-0x00000001898C4FC0
				// [XID] // 0x00000001898C4F60-0x00000001898C4FC0
				public static void LogCollectionCounts(int instanceCount, int requestCount) {} // 0x0000000184E85440-0x0000000184E85760
				[AudioLogMethod] // 0x00000001898D2670-0x00000001898D26D0
				// [Conditional] // 0x00000001898D2670-0x00000001898D26D0
				// [XID] // 0x00000001898D2670-0x00000001898D26D0
				public static void LogClear() {} // 0x0000000184E85150-0x0000000184E85440
				// [XID] // 0x00000001898E0460-0x00000001898E0480
				private static void AppendDynamicObjectSpecifics(ReusedStringBuilder reused, AudioDynamicAmbientObject dynamicObject) {} // 0x0000000184E82B70-0x0000000184E82E70
				// [XID] // 0x00000001898417C0-0x00000001898417E0
				private static void AppendSpawnRequest(ReusedStringBuilder reused, AmbientSpawnRequest request) {} // 0x0000000184E82E70-0x0000000184E82FB0
			}
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Entity // TypeDefIndex: 11121
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class AnimatorEvent // TypeDefIndex: 11122
			{
				// Nested types
				public struct AnimatorStateInfoBundle // TypeDefIndex: 11123
				{
					// Properties
					public AnimatorStateInfo current { /* [XID] */ /* 0x000000018996E720-0x000000018996E760 */ get; /* [XID] */ /* 0x00000001899798A0-0x00000001899798E0 */ set; } // 0x0000000184E7C170-0x0000000184E7C260 0x0000000184E7C3C0-0x0000000184E7C4B0
					public AnimatorStateInfo next { /* [XID] */ /* 0x0000000189983CB0-0x0000000189983CF0 */ get; /* [XID] */ /* 0x000000018998E4B0-0x000000018998E4F0 */ set; } // 0x0000000184E7C2C0-0x0000000184E7C3C0 0x0000000184E7C590-0x0000000184E7C6A0
					public bool hasNext { /* [XID] */ /* 0x0000000189999240-0x0000000189999280 */ get; /* [XID] */ /* 0x00000001899A3B80-0x00000001899A3BC0 */ set; } // 0x0000000184E7C260-0x0000000184E7C2C0 0x0000000184E7C4B0-0x0000000184E7C590
	
					// Methods
					// [XID] // 0x00000001899AE450-0x00000001899AE470
					public static bool Disagree(AnimatorStateInfoBundle a, AnimatorStateInfoBundle b) => default; // 0x0000000184E7BD70-0x0000000184E7C170
				}
	
				// Methods
				[AudioLogMethod] // 0x00000001898FE720-0x00000001898FE780
				// [Conditional] // 0x00000001898FE720-0x00000001898FE780
				// [XID] // 0x00000001898FE720-0x00000001898FE780
				public static void LogAnimatorEvent(AnimatorEventAudio animEvent, Animator animator, AnimatorController controller4hi) {} // 0x0000000184E7A1F0-0x0000000184E7A910
				[AudioLogMethod] // 0x000000018990BF80-0x000000018990BFE0
				// [Conditional] // 0x000000018990BF80-0x000000018990BFE0
				// [XID] // 0x000000018990BF80-0x000000018990BFE0
				public static void LogRejectAnimatorEvent(AnimatorEventAudio animEvent, Animator _animator) {} // 0x0000000184E7A910-0x0000000184E7ABC0
				[AudioLogMethod] // 0x0000000189919A20-0x0000000189919A80
				// [Conditional] // 0x0000000189919A20-0x0000000189919A80
				// [XID] // 0x0000000189919A20-0x0000000189919A80
				public static void LogTransitionEvent(int fromStateHash, int toStateHash, NamedStateAudioEvent<int> stateEvent, Animator animator, AnimatorController controller4hi) {} // 0x0000000184E7B110-0x0000000184E7B550
				[AudioLogMethod] // 0x0000000189927180-0x00000001899271E0
				// [Conditional] // 0x0000000189927180-0x00000001899271E0
				// [XID] // 0x0000000189927180-0x00000001899271E0
				public static void LogStateChange(AnimatorStateInfoBundle lastFrame, AnimatorStateInfoBundle thisFrame, Animator animator, AnimatorController controller4hi) {} // 0x0000000184E7ABC0-0x0000000184E7B110
				[AudioLogMethod] // 0x00000001899343E0-0x0000000189934440
				// [Conditional] // 0x00000001899343E0-0x0000000189934440
				// [XID] // 0x00000001899343E0-0x0000000189934440
				private static void WriteAnimatorStateInfoBundle(AnimatorStateInfoBundle states, ReusedStringBuilder reused, Animator animator, AnimatorController controller4hi) {} // 0x0000000184E7B7B0-0x0000000184E7BA10
				[AudioLogMethod] // 0x00000001899419F0-0x0000000189941A50
				// [Conditional] // 0x00000001899419F0-0x0000000189941A50
				// [XID] // 0x00000001899419F0-0x0000000189941A50
				private static void WriteAnimatorStateInfo(AnimatorStateInfo info, ReusedStringBuilder reused, Animator animator, AnimatorController controller4hi) {} // 0x0000000184E7BA10-0x0000000184E7BC80
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Avatar // TypeDefIndex: 11124
			{
				// Methods
				[AudioLogMethod] // 0x00000001899BD320-0x00000001899BD380
				// [Conditional] // 0x00000001899BD320-0x00000001899BD380
				// [XID] // 0x00000001899BD320-0x00000001899BD380
				public static void LogCheckAllowPutawayEvent(string stateName, bool allowed) {} // 0x0000000184E80540-0x0000000184E80880
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Gadget // TypeDefIndex: 11125
			{
				// Methods
				[AudioLogMethod] // 0x00000001899D21F0-0x00000001899D2250
				// [Conditional] // 0x00000001899D21F0-0x00000001899D2250
				// [XID] // 0x00000001899D21F0-0x00000001899D2250
				public static void LogPlayDropSound(uint id, string eventName, string gadgetName, string gadgetDesc, string jsonName) {} // 0x0000000184E917A0-0x0000000184E91C60
			}
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Manager // TypeDefIndex: 11126
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Banks // TypeDefIndex: 11127
			{
				// Methods
				[AudioLogMethod] // 0x00000001899EE5D0-0x00000001899EE630
				// [Conditional] // 0x00000001899EE5D0-0x00000001899EE630
				// [XID] // 0x00000001899EE5D0-0x00000001899EE630
				public static void LogPushLoadBank(uint bankId, DateTime dueBefore, DateTime dueAfter) {} // 0x0000000184E80880-0x0000000184E80C40
				[AudioLogMethod] // 0x00000001899FC100-0x00000001899FC160
				// [Conditional] // 0x00000001899FC100-0x00000001899FC160
				// [XID] // 0x00000001899FC100-0x00000001899FC160
				public static void LogPushUnloadBank(uint bankId, DateTime dueBefore, DateTime dueAfter) {} // 0x0000000184E80C40-0x0000000184E81000
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Control // TypeDefIndex: 11128
			{
				// Methods
				[AudioLogMethod] // 0x0000000189A10A00-0x0000000189A10A60
				// [Conditional] // 0x0000000189A10A00-0x0000000189A10A60
				// [XID] // 0x0000000189A10A00-0x0000000189A10A60
				public static void LogStopPlayingId(uint playingId) {} // 0x0000000184E824B0-0x0000000184E827C0
				[AudioLogMethod] // 0x0000000189A1DD00-0x0000000189A1DD60
				// [Conditional] // 0x0000000189A1DD00-0x0000000189A1DD60
				// [XID] // 0x0000000189A1DD00-0x0000000189A1DD60
				public static void LogStopAll(SyncId syncId) {} // 0x0000000184E82180-0x0000000184E824B0
				[AudioLogMethod] // 0x0000000189A2B180-0x0000000189A2B1E0
				// [Conditional] // 0x0000000189A2B180-0x0000000189A2B1E0
				// [XID] // 0x0000000189A2B180-0x0000000189A2B1E0
				public static void LogSyncIsNotRegistered(SyncId syncId) {} // 0x0000000184E827C0-0x0000000184E82B10
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Event // TypeDefIndex: 11129
			{
				// Methods
				[AudioLogMethod] // 0x0000000189A401A0-0x0000000189A40200
				// [Conditional] // 0x0000000189A401A0-0x0000000189A40200
				// [XID] // 0x0000000189A401A0-0x0000000189A40200
				public static void LogInvalidOneTimeEventStart() {} // 0x0000000184E8F720-0x0000000184E8F970
				[AudioLogMethod] // 0x0000000189A4D890-0x0000000189A4D8F0
				// [Conditional] // 0x0000000189A4D890-0x0000000189A4D8F0
				// [XID] // 0x0000000189A4D890-0x0000000189A4D8F0
				public static void LogOneTimeEventParams(OneTimeEventParams @params) {} // 0x0000000184E903A0-0x0000000184E90810
				[AudioLogMethod] // 0x0000000189A5AE20-0x0000000189A5AE80
				// [Conditional] // 0x0000000189A5AE20-0x0000000189A5AE80
				// [XID] // 0x0000000189A5AE20-0x0000000189A5AE80
				public static void LogCombinedSwitches(AudioCombinedSwitches switches, SyncId syncId) {} // 0x0000000184E8B9C0-0x0000000184E8BD40
				[AudioLogMethod] // 0x0000000189A68F10-0x0000000189A68F70
				// [Conditional] // 0x0000000189A68F10-0x0000000189A68F70
				// [XID] // 0x0000000189A68F10-0x0000000189A68F70
				public static void LogUnpreparedMultiPositionEvent(uint eventId) {} // 0x0000000184E91490-0x0000000184E917A0
				[AudioLogMethod] // 0x0000000189A762D0-0x0000000189A76330
				// [Conditional] // 0x0000000189A762D0-0x0000000189A76330
				// [XID] // 0x0000000189A762D0-0x0000000189A76330
				public static void LogMultiPositionEventAlreadyPlaying(uint eventId) {} // 0x0000000184E8F970-0x0000000184E8FC80
				[AudioLogMethod] // 0x0000000189A83CE0-0x0000000189A83D40
				// [Conditional] // 0x0000000189A83CE0-0x0000000189A83D40
				// [XID] // 0x0000000189A83CE0-0x0000000189A83D40
				public static void LogRequestToAbortPendingEvent(uint postId) {} // 0x0000000184E90E00-0x0000000184E91180
				[AudioLogMethod] // 0x0000000189A91540-0x0000000189A915A0
				// [Conditional] // 0x0000000189A91540-0x0000000189A915A0
				// [XID] // 0x0000000189A91540-0x0000000189A915A0
				public static void LogEngineNoInitialized() {} // 0x0000000184E8BD40-0x0000000184E8BF90
				[AudioLogMethod] // 0x0000000189A9E910-0x0000000189A9E970
				// [Conditional] // 0x0000000189A9E910-0x0000000189A9E970
				// [XID] // 0x0000000189A9E910-0x0000000189A9E970
				public static void LogInvalidEventId() {} // 0x0000000184E8F4D0-0x0000000184E8F720
				[AudioLogMethod] // 0x0000000189AAC130-0x0000000189AAC190
				// [Conditional] // 0x0000000189AAC130-0x0000000189AAC190
				// [XID] // 0x0000000189AAC130-0x0000000189AAC190
				public static void LogExternalSourcesUnavailable() {} // 0x0000000184E8EAD0-0x0000000184E8ED20
				[AudioLogMethod] // 0x0000000189AB9880-0x0000000189AB98E0
				// [Conditional] // 0x0000000189AB9880-0x0000000189AB98E0
				// [XID] // 0x0000000189AB9880-0x0000000189AB98E0
				public static void LogEventRejectedForUnregisteredGameObject(EventParams @params) {} // 0x0000000184E8E100-0x0000000184E8E4D0
				[AudioLogMethod] // 0x0000000189AC7750-0x0000000189AC77B0
				// [Conditional] // 0x0000000189AC7750-0x0000000189AC77B0
				// [XID] // 0x0000000189AC7750-0x0000000189AC77B0
				public static void LogEventRejectedForMutalExclusion(EventParams @params) {} // 0x0000000184E8DD30-0x0000000184E8E100
				[AudioLogMethod] // 0x0000000189AD5480-0x0000000189AD54E0
				// [Conditional] // 0x0000000189AD5480-0x0000000189AD54E0
				// [XID] // 0x0000000189AD5480-0x0000000189AD54E0
				public static void LogNecessarySoundBanksForEvent(List<uint> soundBankIds, uint eventId, ulong akId) {} // 0x0000000184E8FC80-0x0000000184E900B0
				[AudioLogMethod] // 0x0000000189AE2900-0x0000000189AE2960
				// [Conditional] // 0x0000000189AE2900-0x0000000189AE2960
				// [XID] // 0x0000000189AE2900-0x0000000189AE2960
				public static void LogEventWaitingForLoadSoundBanks(uint eventId) {} // 0x0000000184E8E7C0-0x0000000184E8EAD0
				[AudioLogMethod] // 0x0000000189AF0920-0x0000000189AF0980
				// [Conditional] // 0x0000000189AF0920-0x0000000189AF0980
				// [XID] // 0x0000000189AF0920-0x0000000189AF0980
				public static void LogEventRejectedForLoadSoundBankFailure(uint eventId) {} // 0x0000000184E8DA20-0x0000000184E8DD30
				[AudioLogMethod] // 0x0000000189AFDC30-0x0000000189AFDC90
				// [Conditional] // 0x0000000189AFDC30-0x0000000189AFDC90
				// [XID] // 0x0000000189AFDC30-0x0000000189AFDC90
				public static void LogEventParams(EventParams @params) {} // 0x0000000184E8C2D0-0x0000000184E8C7A0
				[AudioLogMethod] // 0x0000000189B0B2C0-0x0000000189B0B320
				// [Conditional] // 0x0000000189B0B2C0-0x0000000189B0B320
				// [XID] // 0x0000000189B0B2C0-0x0000000189B0B320
				public static void LogPlayingId(uint playingId) {} // 0x0000000184E90B00-0x0000000184E90E00
				[AudioLogMethod] // 0x0000000189B18830-0x0000000189B18890
				// [Conditional] // 0x0000000189B18830-0x0000000189B18890
				// [XID] // 0x0000000189B18830-0x0000000189B18890
				public static void LogEventCallback(AkCallbackType type, EventCallbackAdditionalInfo info) {} // 0x0000000184E8BF90-0x0000000184E8C2D0
				[AudioLogMethod] // 0x0000000189B25F00-0x0000000189B25F60
				// [Conditional] // 0x0000000189B25F00-0x0000000189B25F60
				// [XID] // 0x0000000189B25F00-0x0000000189B25F60
				public static void LogEventSoundBankUsageCount(uint eventId, int nBanks) {} // 0x0000000184E8E4D0-0x0000000184E8E7C0
				[AudioLogMethod] // 0x0000000189B32F30-0x0000000189B32F90
				// [Conditional] // 0x0000000189B32F30-0x0000000189B32F90
				// [XID] // 0x0000000189B32F30-0x0000000189B32F90
				public static void LogTryAbortPendingEvent(uint postId) {} // 0x0000000184E91180-0x0000000184E91490
				[AudioLogMethod] // 0x0000000189B40A90-0x0000000189B40AF0
				// [Conditional] // 0x0000000189B40A90-0x0000000189B40AF0
				// [XID] // 0x0000000189B40A90-0x0000000189B40AF0
				public static void LogPendingEventListEmpty() {} // 0x0000000184E90810-0x0000000184E90B00
				[AudioLogMethod] // 0x0000000189B4E390-0x0000000189B4E3F0
				// [Conditional] // 0x0000000189B4E390-0x0000000189B4E3F0
				// [XID] // 0x0000000189B4E390-0x0000000189B4E3F0
				public static void LogFoundPendingEventToAbort() {} // 0x0000000184E8EF70-0x0000000184E8F1C0
				[AudioLogMethod] // 0x0000000189B5BD80-0x0000000189B5BDE0
				// [Conditional] // 0x0000000189B5BD80-0x0000000189B5BDE0
				// [XID] // 0x0000000189B5BD80-0x0000000189B5BDE0
				public static void LogNeedLookupPostHistory() {} // 0x0000000184E900B0-0x0000000184E903A0
				[AudioLogMethod] // 0x0000000189B69410-0x0000000189B69470
				// [Conditional] // 0x0000000189B69410-0x0000000189B69470
				// [XID] // 0x0000000189B69410-0x0000000189B69470
				public static void LogFailedFindCorrespondingPlayingId() {} // 0x0000000184E8ED20-0x0000000184E8EF70
				[AudioLogMethod] // 0x0000000189B76610-0x0000000189B76670
				// [Conditional] // 0x0000000189B76610-0x0000000189B76670
				// [XID] // 0x0000000189B76610-0x0000000189B76670
				public static void LogFoundPlayingIdAndWillStop(uint playingId) {} // 0x0000000184E8F1C0-0x0000000184E8F4D0
				[AudioLogMethod] // 0x0000000189B83F20-0x0000000189B83F80
				// [Conditional] // 0x0000000189B83F20-0x0000000189B83F80
				// [XID] // 0x0000000189B83F20-0x0000000189B83F80
				public static void LogEventRejectedForCullingOutOfRange(uint eventId, SyncId syncId) {} // 0x0000000184E8D680-0x0000000184E8DA20
				[AudioLogMethod] // 0x0000000189B91380-0x0000000189B913E0
				// [Conditional] // 0x0000000189B91380-0x0000000189B913E0
				// [XID] // 0x0000000189B91380-0x0000000189B913E0
				public static void LogEventRejectedForCullingLimitFrame(uint eventId, SyncId syncId) {} // 0x0000000184E8CB40-0x0000000184E8CEE0
				[AudioLogMethod] // 0x0000000189B9E250-0x0000000189B9E2B0
				// [Conditional] // 0x0000000189B9E250-0x0000000189B9E2B0
				// [XID] // 0x0000000189B9E250-0x0000000189B9E2B0
				public static void LogEventRejectedForCullingNameContainPattern(uint eventId, SyncId syncId, string pattern) {} // 0x0000000184E8CEE0-0x0000000184E8D2B0
				[AudioLogMethod] // 0x0000000189BAB930-0x0000000189BAB990
				// [Conditional] // 0x0000000189BAB930-0x0000000189BAB990
				// [XID] // 0x0000000189BAB930-0x0000000189BAB990
				public static void LogEventRejectedForCullingNameNotContainPattern(uint eventId, SyncId syncId, string pattern) {} // 0x0000000184E8D2B0-0x0000000184E8D680
				[AudioLogMethod] // 0x0000000189BB8A00-0x0000000189BB8A60
				// [Conditional] // 0x0000000189BB8A00-0x0000000189BB8A60
				// [XID] // 0x0000000189BB8A00-0x0000000189BB8A60
				public static void LogEventRejectedForCullingDirect(uint eventId, SyncId syncId) {} // 0x0000000184E8C7A0-0x0000000184E8CB40
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Listener // TypeDefIndex: 11130
			{
				// Methods
				[AudioLogMethod] // 0x0000000189BCE310-0x0000000189BCE370
				// [Conditional] // 0x0000000189BCE310-0x0000000189BCE370
				// [XID] // 0x0000000189BCE310-0x0000000189BCE370
				public static void LogSetAlignment(ListenerAlignmentReason mask, TailingTarget tailingTarget) {} // 0x0000000184E91C60-0x0000000184E92040
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Syncs // TypeDefIndex: 11131
			{
				// Methods
				[AudioLogMethod] // 0x00000001895E83B0-0x00000001895E8410
				// [Conditional] // 0x00000001895E83B0-0x00000001895E8410
				// [XID] // 0x00000001895E83B0-0x00000001895E8410
				public static void LogIncreaseUnregistrationPrevention(SyncId syncId, int count) {} // 0x0000000184E97440-0x0000000184E977B0
				[AudioLogMethod] // 0x00000001895F5CB0-0x00000001895F5D10
				// [Conditional] // 0x00000001895F5CB0-0x00000001895F5D10
				// [XID] // 0x00000001895F5CB0-0x00000001895F5D10
				public static void LogDecreaseUnregistrationPreventionFailure(SyncId syncId) {} // 0x0000000184E96D80-0x0000000184E970D0
				[AudioLogMethod] // 0x0000000189603360-0x00000001896033C0
				// [Conditional] // 0x0000000189603360-0x00000001896033C0
				// [XID] // 0x0000000189603360-0x00000001896033C0
				public static void LogDecreaseUnregistrationPrevention(SyncId syncId, int count) {} // 0x0000000184E970D0-0x0000000184E97440
				[AudioLogMethod] // 0x0000000189610C20-0x0000000189610C80
				// [Conditional] // 0x0000000189610C20-0x0000000189610C80
				// [XID] // 0x0000000189610C20-0x0000000189610C80
				public static void LogCancelDelayedUnregistration(SyncId syncId) {} // 0x0000000184E96A30-0x0000000184E96D80
				[AudioLogMethod] // 0x000000018961E220-0x000000018961E280
				// [Conditional] // 0x000000018961E220-0x000000018961E280
				// [XID] // 0x000000018961E220-0x000000018961E280
				public static void LogAddDelayedUnregistration(SyncId syncId) {} // 0x0000000184E966E0-0x0000000184E96A30
				[AudioLogMethod] // 0x000000018962B830-0x000000018962B890
				// [Conditional] // 0x000000018962B830-0x000000018962B890
				// [XID] // 0x000000018962B830-0x000000018962B890
				public static void LogPerformDelayedUnregistration(SyncId syncId) {} // 0x0000000184E977B0-0x0000000184E97B00
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class UI // TypeDefIndex: 11132
			{
				// Methods
				[AudioLogMethod] // 0x0000000189640820-0x0000000189640880
				// [Conditional] // 0x0000000189640820-0x0000000189640880
				// [XID] // 0x0000000189640820-0x0000000189640880
				public static void LogOpenPage(string name) {} // 0x0000000184E99AA0-0x0000000184E99DA0
				[AudioLogMethod] // 0x000000018964E1A0-0x000000018964E200
				// [Conditional] // 0x000000018964E1A0-0x000000018964E200
				// [XID] // 0x000000018964E1A0-0x000000018964E200
				public static void LogClosePage(string name) {} // 0x0000000184E98B60-0x0000000184E98E60
				[AudioLogMethod] // 0x000000018965B9F0-0x000000018965BA50
				// [Conditional] // 0x000000018965B9F0-0x000000018965BA50
				// [XID] // 0x000000018965B9F0-0x000000018965BA50
				public static void LogAvatarEnterFocus() {} // 0x0000000184E983C0-0x0000000184E98610
				[AudioLogMethod] // 0x00000001896691D0-0x0000000189669230
				// [Conditional] // 0x00000001896691D0-0x0000000189669230
				// [XID] // 0x00000001896691D0-0x0000000189669230
				public static void LogAvatarExitFocus() {} // 0x0000000184E98610-0x0000000184E98860
				[AudioLogMethod] // 0x0000000189676BB0-0x0000000189676C10
				// [Conditional] // 0x0000000189676BB0-0x0000000189676C10
				// [XID] // 0x0000000189676BB0-0x0000000189676C10
				public static void LogAvatarChange() {} // 0x0000000184E98170-0x0000000184E983C0
				[AudioLogMethod] // 0x00000001896842E0-0x0000000189684340
				// [Conditional] // 0x00000001896842E0-0x0000000189684340
				// [XID] // 0x00000001896842E0-0x0000000189684340
				public static void LogOpenMenu(string name) {} // 0x0000000184E997A0-0x0000000184E99AA0
				[AudioLogMethod] // 0x00000001896924D0-0x0000000189692530
				// [Conditional] // 0x00000001896924D0-0x0000000189692530
				// [XID] // 0x00000001896924D0-0x0000000189692530
				public static void LogCloseMenu(string name) {} // 0x0000000184E98860-0x0000000184E98B60
				[AudioLogMethod] // 0x000000018969F700-0x000000018969F760
				// [Conditional] // 0x000000018969F700-0x000000018969F760
				// [XID] // 0x000000018969F700-0x000000018969F760
				public static void LogSneakingStart() {} // 0x0000000184E9AA90-0x0000000184E9ACE0
				[AudioLogMethod] // 0x00000001896ACB20-0x00000001896ACB80
				// [Conditional] // 0x00000001896ACB20-0x00000001896ACB80
				// [XID] // 0x00000001896ACB20-0x00000001896ACB80
				public static void LogSneakingStop() {} // 0x0000000184E9ACE0-0x0000000184E9AF30
				[AudioLogMethod] // 0x00000001896B9C20-0x00000001896B9C80
				// [Conditional] // 0x00000001896B9C20-0x00000001896B9C80
				// [XID] // 0x00000001896B9C20-0x00000001896B9C80
				public static void LogSetViewState(GameViewState from, GameViewState to) {} // 0x0000000184E9A730-0x0000000184E9AA90
				[AudioLogMethod] // 0x00000001896C7050-0x00000001896C70B0
				// [Conditional] // 0x00000001896C7050-0x00000001896C70B0
				// [XID] // 0x00000001896C7050-0x00000001896C70B0
				public static void LogDialogStart() {} // 0x0000000184E99550-0x0000000184E997A0
				[AudioLogMethod] // 0x00000001896D4120-0x00000001896D4180
				// [Conditional] // 0x00000001896D4120-0x00000001896D4180
				// [XID] // 0x00000001896D4120-0x00000001896D4180
				public static void LogDialogFinish() {} // 0x0000000184E99300-0x0000000184E99550
				[AudioLogMethod] // 0x00000001896E1AA0-0x00000001896E1B00
				// [Conditional] // 0x00000001896E1AA0-0x00000001896E1B00
				// [XID] // 0x00000001896E1AA0-0x00000001896E1B00
				public static void LogCoopStart() {} // 0x0000000184E990B0-0x0000000184E99300
				[AudioLogMethod] // 0x00000001896EEC80-0x00000001896EECE0
				// [Conditional] // 0x00000001896EEC80-0x00000001896EECE0
				// [XID] // 0x00000001896EEC80-0x00000001896EECE0
				public static void LogCoopFinish() {} // 0x0000000184E98E60-0x0000000184E990B0
				[AudioLogMethod] // 0x00000001896FC450-0x00000001896FC4B0
				// [Conditional] // 0x00000001896FC450-0x00000001896FC4B0
				// [XID] // 0x00000001896FC450-0x00000001896FC4B0
				public static void LogPerformReactionsWithDialogId(uint dialogId, bool start) {} // 0x0000000184E99DA0-0x0000000184E9A0B0
				[AudioLogMethod] // 0x0000000189709A00-0x0000000189709A60
				// [Conditional] // 0x0000000189709A00-0x0000000189709A60
				// [XID] // 0x0000000189709A00-0x0000000189709A60
				public static void LogPostEventByDialog(ConfigWwiseString eventName) {} // 0x0000000184E9A0B0-0x0000000184E9A3D0
				[AudioLogMethod] // 0x0000000189716E70-0x0000000189716ED0
				// [Conditional] // 0x0000000189716E70-0x0000000189716ED0
				// [XID] // 0x0000000189716E70-0x0000000189716ED0
				public static void LogSetStateByDialog(ConfigWwiseString stateGroup, ConfigWwiseString stateValue) {} // 0x0000000184E9A3D0-0x0000000184E9A730
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Spatial // TypeDefIndex: 11133
			{
				// Methods
				[AudioLogMethod] // 0x000000018972BD00-0x000000018972BD60
				// [Conditional] // 0x000000018972BD00-0x000000018972BD60
				// [XID] // 0x000000018972BD00-0x000000018972BD60
				public static void LogRegisterSpatialEmitter(SyncId syncId) {} // 0x0000000184E94370-0x0000000184E946C0
				[AudioLogMethod] // 0x00000001897392E0-0x0000000189739340
				// [Conditional] // 0x00000001897392E0-0x0000000189739340
				// [XID] // 0x00000001897392E0-0x0000000189739340
				public static void LogUnregisterSpatialEmitter(SyncId syncId) {} // 0x0000000184E96390-0x0000000184E966E0
				[AudioLogMethod] // 0x0000000189746FA0-0x0000000189747000
				// [Conditional] // 0x0000000189746FA0-0x0000000189747000
				// [XID] // 0x0000000189746FA0-0x0000000189747000
				public static void LogSetGlobalRoom(Room room) {} // 0x0000000184E94CE0-0x0000000184E94FF0
				[AudioLogMethod] // 0x00000001897546F0-0x0000000189754750
				// [Conditional] // 0x00000001897546F0-0x0000000189754750
				// [XID] // 0x00000001897546F0-0x0000000189754750
				public static void LogClearGlobalRoom() {} // 0x0000000184E936C0-0x0000000184E93980
				[AudioLogMethod] // 0x0000000189761DE0-0x0000000189761E40
				// [Conditional] // 0x0000000189761DE0-0x0000000189761E40
				// [XID] // 0x0000000189761DE0-0x0000000189761E40
				public static void LogEmitterRoomChanged(SpatialEmitterSync emitter, Room room) {} // 0x0000000184E93CD0-0x0000000184E94020
				[AudioLogMethod] // 0x000000018976EED0-0x000000018976EF30
				// [Conditional] // 0x000000018976EED0-0x000000018976EF30
				// [XID] // 0x000000018976EED0-0x000000018976EF30
				public static void LogEmitterOutdoor(SpatialEmitterSync emitter) {} // 0x0000000184E93980-0x0000000184E93CD0
				[AudioLogMethod] // 0x000000018977C6C0-0x000000018977C720
				// [Conditional] // 0x000000018977C6C0-0x000000018977C720
				// [XID] // 0x000000018977C6C0-0x000000018977C720
				public static void LogAddRoom(Room room) {} // 0x0000000184E933A0-0x0000000184E936C0
				[AudioLogMethod] // 0x0000000189789D90-0x0000000189789DF0
				// [Conditional] // 0x0000000189789D90-0x0000000189789DF0
				// [XID] // 0x0000000189789D90-0x0000000189789DF0
				public static void LogRemoveRoom(Room room) {} // 0x0000000184E949D0-0x0000000184E94CE0
				[AudioLogMethod] // 0x0000000189797610-0x0000000189797670
				// [Conditional] // 0x0000000189797610-0x0000000189797670
				// [XID] // 0x0000000189797610-0x0000000189797670
				public static void LogRegisterListener(SyncId syncId) {} // 0x0000000184E94020-0x0000000184E94370
				[AudioLogMethod] // 0x00000001897A54D0-0x00000001897A5530
				// [Conditional] // 0x00000001897A54D0-0x00000001897A5530
				// [XID] // 0x00000001897A54D0-0x00000001897A5530
				public static void LogUnregisterListener(SyncId syncId) {} // 0x0000000184E96040-0x0000000184E96390
				[AudioLogMethod] // 0x00000001897B2B70-0x00000001897B2BD0
				// [Conditional] // 0x00000001897B2B70-0x00000001897B2BD0
				// [XID] // 0x00000001897B2B70-0x00000001897B2BD0
				public static void LogSetPortal(RoomPortal portal) {} // 0x0000000184E94FF0-0x0000000184E953D0
				[AudioLogMethod] // 0x00000001897C0EB0-0x00000001897C0F10
				// [Conditional] // 0x00000001897C0EB0-0x00000001897C0F10
				// [XID] // 0x00000001897C0EB0-0x00000001897C0F10
				public static void LogRemovePortal(RoomPortal portal) {} // 0x0000000184E946C0-0x0000000184E949D0
				[AudioLogMethod] // 0x00000001897CE6C0-0x00000001897CE720
				// [Conditional] // 0x00000001897CE6C0-0x00000001897CE720
				// [XID] // 0x00000001897CE6C0-0x00000001897CE720
				public static void LogSpatialDisableIgnoreCmd() {} // 0x0000000184E95700-0x0000000184E95A20
				[AudioLogMethod] // 0x00000001897DBC30-0x00000001897DBC90
				// [Conditional] // 0x00000001897DBC30-0x00000001897DBC90
				// [XID] // 0x00000001897DBC30-0x00000001897DBC90
				public static void LogSpatialWorkerEnableChanged(bool enable) {} // 0x0000000184E95D10-0x0000000184E96040
				[AudioLogMethod] // 0x00000001897E95F0-0x00000001897E9650
				// [Conditional] // 0x00000001897E95F0-0x00000001897E9650
				// [XID] // 0x00000001897E95F0-0x00000001897E9650
				public static void LogSpatialCommandEnableChanged(bool enable) {} // 0x0000000184E953D0-0x0000000184E95700
				[AudioLogMethod] // 0x00000001897F6FA0-0x00000001897F7000
				// [Conditional] // 0x00000001897F6FA0-0x00000001897F7000
				// [XID] // 0x00000001897F6FA0-0x00000001897F7000
				public static void LogSpatialRemoveGlobalRoom() {} // 0x0000000184E95A20-0x0000000184E95D10
			}
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Mono // TypeDefIndex: 11134
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class ExDriven // TypeDefIndex: 11135
			{
				// Methods
				[AudioLogMethod] // 0x0000000189813400-0x0000000189813460
				// [Conditional] // 0x0000000189813400-0x0000000189813460
				// [XID] // 0x0000000189813400-0x0000000189813460
				public static void LogReceiveUnityMessage(AudioUnityMessageType messageType, ExDrivenAudioEvents.Event @event, ExDrivenAudioEvents exEvents, UnitySync monoSync) {} // 0x00000001867247B0-0x0000000186724B10
				// [XID] // 0x000000018964FA90-0x000000018964FAB0
				private static string FormatExDrivenEventsName(ExDrivenAudioEvents exEvents, UnitySync unitySync) => default; // 0x0000000186724120-0x0000000186724560
				// [XID] // 0x00000001899C6850-0x00000001899C6870
				private static string FormatEvent(ExDrivenAudioEvents.Event e, ExDrivenAudioEvents exEvents) => default; // 0x0000000186723CF0-0x0000000186724120
				// [IDTag] // 0x000000018982FA50-0x000000018982FA90
				// [XID] // 0x000000018982FA50-0x000000018982FA90
				private static string FormatDerivedEvent(ExDrivenAudioEvents.TimedEvent te, ExDrivenAudioEvents exEvents) => default; // 0x00000001867232D0-0x0000000186723600
				// [IDTag] // 0x0000000189839FF0-0x000000018983A030
				// [XID] // 0x0000000189839FF0-0x000000018983A030
				private static string FormatDerivedEvent(ExDrivenAudioEvents3D.DurableEvent de, ExDrivenAudioEvents exEvents) => default; // 0x0000000186723600-0x0000000186723930
				// [IDTag] // 0x0000000189844890-0x00000001898448D0
				// [XID] // 0x0000000189844890-0x00000001898448D0
				private static string FormatDerivedEvent(ExDrivenAudioEvents3D.MultiPositionEvent mpe, ExDrivenAudioEvents exEvents) => default; // 0x0000000186723930-0x0000000186723CF0
				// [XID] // 0x000000018984ECA0-0x000000018984ECC0
				private static void AppendCommonEventProperties(ReusedStringBuilder builder, ExDrivenAudioEvents.Event e, ExDrivenAudioEvents exEvents) {} // 0x00000001867230C0-0x00000001867232D0
				// [IDTag] // 0x0000000189855DF0-0x0000000189855E30
				// [XID] // 0x0000000189855DF0-0x0000000189855E30
				private static string GetPlaceholderName(ExDrivenAudioEvents.Event e, ExDrivenAudioEvents exEvents) => default; // 0x0000000186724560-0x0000000186724660
				// [IDTag] // 0x0000000189860390-0x00000001898603D0
				// [XID] // 0x0000000189860390-0x00000001898603D0
				private static string GetPlaceholderName(int index, ExDrivenAudioEvents exEvents) => default; // 0x0000000186724660-0x00000001867247B0
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class EnableDelay // TypeDefIndex: 11136
			{
				// Methods
				[AudioLogMethod] // 0x0000000189871E50-0x0000000189871E90
				// [Conditional] // 0x0000000189871E50-0x0000000189871E90
				public static void LogMonoOnEnable<T>(T mono)
					where T : MonoBehaviour {}
				[AudioLogMethod] // 0x000000018987C6C0-0x000000018987C710
				// [Conditional] // 0x000000018987C6C0-0x000000018987C710
				public static void LogMonoOnDisable<T>(T mono)
					where T : MonoBehaviour {}
				[AudioLogMethod] // 0x000000018987C6C0-0x000000018987C710
				// [Conditional] // 0x000000018987C6C0-0x000000018987C710
				public static void LogWillAllocate<THost, TWorker>(AudioEnableDelayParams @params, THost host)
					where THost : IAudioUiTickable {}
				[AudioLogMethod] // 0x0000000189890CE0-0x0000000189890D40
				// [Conditional] // 0x0000000189890CE0-0x0000000189890D40
				// [XID] // 0x0000000189890CE0-0x0000000189890D40
				public static void LogDidAllocate(AudioEnableDelay instance) {} // 0x000000018671DB80-0x000000018671DE60
				[AudioLogMethod] // 0x000000018989DF90-0x000000018989DFF0
				// [Conditional] // 0x000000018989DF90-0x000000018989DFF0
				// [XID] // 0x000000018989DF90-0x000000018989DFF0
				public static void LogWillDeallocate(AudioEnableDelay instance) {} // 0x000000018671F540-0x000000018671F820
				[AudioLogMethod] // 0x00000001898AB3E0-0x00000001898AB440
				// [Conditional] // 0x00000001898AB3E0-0x00000001898AB440
				// [XID] // 0x00000001898AB3E0-0x00000001898AB440
				public static void LogTick(AudioEnableDelay instance) {} // 0x000000018671ECC0-0x000000018671EFA0
				[AudioLogMethod] // 0x00000001898B9220-0x00000001898B9280
				// [Conditional] // 0x00000001898B9220-0x00000001898B9280
				// [XID] // 0x00000001898B9220-0x00000001898B9280
				public static void LogRemainingCountLessThanOrEqualToZero(AudioEnableDelay instance, int remainingFrameCount) {} // 0x000000018671E3F0-0x000000018671E6F0
				[AudioLogMethod] // 0x00000001898C65C0-0x00000001898C6620
				// [Conditional] // 0x00000001898C65C0-0x00000001898C6620
				// [XID] // 0x00000001898C65C0-0x00000001898C6620
				public static void LogTickRemainingCount(AudioEnableDelay instance, int remainingFrameCount) {} // 0x000000018671E9C0-0x000000018671ECC0
				[AudioLogMethod] // 0x00000001898D3DD0-0x00000001898D3E30
				// [Conditional] // 0x00000001898D3DD0-0x00000001898D3E30
				// [XID] // 0x00000001898D3DD0-0x00000001898D3E30
				public static void LogWorkerMissing(AudioEnableDelay instance) {} // 0x000000018671F820-0x000000018671FB00
				[AudioLogMethod] // 0x00000001898E1BA0-0x00000001898E1C00
				// [Conditional] // 0x00000001898E1BA0-0x00000001898E1C00
				// [XID] // 0x00000001898E1BA0-0x00000001898E1C00
				public static void LogDoWork(AudioEnableDelay instance) {} // 0x000000018671DE60-0x000000018671E130
				[AudioLogMethod] // 0x00000001898EF680-0x00000001898EF6F0
				// [Conditional] // 0x00000001898EF680-0x00000001898EF6F0
				// [IDTag] // 0x00000001898EF680-0x00000001898EF6F0
				// [XID] // 0x00000001898EF680-0x00000001898EF6F0
				public static void LogUnregisterTickable(AudioEnableDelay instance) {} // 0x000000018671EFA0-0x000000018671F280
				[AudioLogMethod] // 0x0000000189900010-0x0000000189900070
				// [Conditional] // 0x0000000189900010-0x0000000189900070
				// [XID] // 0x0000000189900010-0x0000000189900070
				public static void LogSetRemainingCount(AudioEnableDelay instance, int remainingFrameCount) {} // 0x000000018671E6F0-0x000000018671E9C0
				[AudioLogMethod] // 0x000000018990D800-0x000000018990D860
				// [Conditional] // 0x000000018990D800-0x000000018990D860
				// [XID] // 0x000000018990D800-0x000000018990D860
				public static void LogRegisterTickable(IAudioUiTickable tickable) {} // 0x000000018671E130-0x000000018671E3F0
				[AudioLogMethod] // 0x000000018991B2E0-0x000000018991B350
				// [Conditional] // 0x000000018991B2E0-0x000000018991B350
				// [IDTag] // 0x000000018991B2E0-0x000000018991B350
				// [XID] // 0x000000018991B2E0-0x000000018991B350
				public static void LogUnregisterTickable(IAudioUiTickable tickable) {} // 0x000000018671F280-0x000000018671F540
				// [XID] // 0x000000018992B8E0-0x000000018992B900
				public static string GetHostNameAsMonoBehaviour(IAudioUiTickable host) => default; // 0x000000018671DA40-0x000000018671DB80
			}
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Music // TypeDefIndex: 11137
		{
			// Nested types
			private interface ILiteralizer<T> // TypeDefIndex: 11138
			{
				// Methods
				string Literalize(T t);
			}
	
			private class Literalizer<T> : ILiteralizer<T> // TypeDefIndex: 11139
			{
				// Properties
				public static Literalizer<T> default { get => default; }
	
				// Constructors
				public Literalizer() {}
	
				// Methods
				public string Literalize(T t) => default;
			}
	
			private static class MusicGameParamLegalRange // TypeDefIndex: 11140
			{
				// Fields
				private static readonly uint _min; // 0x00
				private static readonly uint _max; // 0x04
	
				// Properties
				public static uint min { /* [XID] */ /* 0x0000000189A30F20-0x0000000189A30F40 */ get; } // 0x000000018672ADC0-0x000000018672AE90 
				public static uint max { /* [XID] */ /* 0x0000000189A38BF0-0x0000000189A38C10 */ get; } // 0x000000018672ACF0-0x000000018672ADC0 
	
				// Constructors
				static MusicGameParamLegalRange() {} // 0x000000018672AC80-0x000000018672ACF0
	
				// Methods
				// [XID] // 0x0000000189ACA7F0-0x0000000189ACA810
				private static void GetMusicGameParamMaxValue(out uint min, out uint max) {
					min = default;
					max = default;
				} // 0x000000018672A9E0-0x000000018672AC80
			}
	
			// Methods
			[AudioLogMethod] // 0x000000018993A920-0x000000018993A980
			// [Conditional] // 0x000000018993A920-0x000000018993A980
			// [XID] // 0x000000018993A920-0x000000018993A980
			public static void LogConfigRetrievalFailure(int id) {} // 0x000000018672C310-0x000000018672C5C0
			[AudioLogMethod] // 0x0000000189947C70-0x0000000189947CD0
			// [Conditional] // 0x0000000189947C70-0x0000000189947CD0
			// [XID] // 0x0000000189947C70-0x0000000189947CD0
			public static void LogStartMusic() {} // 0x000000018672DD60-0x000000018672E000
			[AudioLogMethod] // 0x0000000189955200-0x0000000189955260
			// [Conditional] // 0x0000000189955200-0x0000000189955260
			// [XID] // 0x0000000189955200-0x0000000189955260
			public static void LogStopMusic() {} // 0x000000018672E000-0x000000018672E2A0
			[AudioLogMethod] // 0x0000000189962EB0-0x0000000189962F10
			// [Conditional] // 0x0000000189962EB0-0x0000000189962F10
			// [XID] // 0x0000000189962EB0-0x0000000189962F10
			public static void LogActualMusicStart() {} // 0x000000018672C070-0x000000018672C310
			[AudioLogMethod] // 0x000000018996FFE0-0x0000000189970040
			// [Conditional] // 0x000000018996FFE0-0x0000000189970040
			// [XID] // 0x000000018996FFE0-0x0000000189970040
			public static void LogMusicSync(AkCallbackType callbackType) {} // 0x000000018672CF40-0x000000018672D210
			[AudioLogMethod] // 0x000000018997D560-0x000000018997D5C0
			// [Conditional] // 0x000000018997D560-0x000000018997D5C0
			// [XID] // 0x000000018997D560-0x000000018997D5C0
			public static void LogUserCue(AkCallbackType callbackType, MmoronCallbackInfo info) {} // 0x000000018672EDB0-0x000000018672F140
			[AudioLogMethod] // 0x000000018998B640-0x000000018998B6A0
			// [Conditional] // 0x000000018998B640-0x000000018998B6A0
			// [XID] // 0x000000018998B640-0x000000018998B6A0
			public static void LogSyncCallbackInfo(AkCallbackType type, MmoronCallbackInfo info) {} // 0x000000018672E2A0-0x000000018672E960
			[AudioLogMethod] // 0x000000018987C6C0-0x000000018987C710
			// [Conditional] // 0x000000018987C6C0-0x000000018987C710
			public static void LogHandleStimulus<T>(MusicStimulus stimulus, IStimulusParameter<T> parameter) {}
			[AudioLogMethod] // 0x00000001899A3B20-0x00000001899A3B80
			// [Conditional] // 0x00000001899A3B20-0x00000001899A3B80
			// [XID] // 0x00000001899A3B20-0x00000001899A3B80
			public static void LogHandleStimulusWithLocalSong(ConfigSong song) {} // 0x000000018672C960-0x000000018672CC30
			[AudioLogMethod] // 0x00000001899B1640-0x00000001899B16A0
			// [Conditional] // 0x00000001899B1640-0x00000001899B16A0
			// [XID] // 0x00000001899B1640-0x00000001899B16A0
			public static void LogCurrentParamStorage(GameParamStorage gameParamStorage, TransitionProposer proposer) {} // 0x000000018672C5C0-0x000000018672C960
			[AudioLogMethod] // 0x00000001899BEC00-0x00000001899BEC60
			// [Conditional] // 0x00000001899BEC00-0x00000001899BEC60
			// [XID] // 0x00000001899BEC00-0x00000001899BEC60
			public static void LogTransitionParamMask(MusicGameParam gameParamMask) {} // 0x000000018672E960-0x000000018672EDB0
			[AudioLogMethod] // 0x00000001899CC330-0x00000001899CC390
			// [Conditional] // 0x00000001899CC330-0x00000001899CC390
			// [XID] // 0x00000001899CC330-0x00000001899CC390
			public static void LogInspectingShifter(ConfigMusicShifter shifter) {} // 0x000000018672CC30-0x000000018672CF40
			[AudioLogMethod] // 0x00000001899D9940-0x00000001899D99A0
			// [Conditional] // 0x00000001899D9940-0x00000001899D99A0
			// [XID] // 0x00000001899D9940-0x00000001899D99A0
			public static void LogShiftToNextSong(int songId) {} // 0x000000018672DAA0-0x000000018672DD60
			[AudioLogMethod] // 0x00000001899E7190-0x00000001899E71F0
			// [Conditional] // 0x00000001899E7190-0x00000001899E71F0
			// [XID] // 0x00000001899E7190-0x00000001899E71F0
			public static void LogSetCurrentSong(ConfigSong song) {} // 0x000000018672D210-0x000000018672D4E0
			[AudioLogMethod] // 0x00000001899F4B60-0x00000001899F4BC0
			// [Conditional] // 0x00000001899F4B60-0x00000001899F4BC0
			// [XID] // 0x00000001899F4B60-0x00000001899F4BC0
			public static void LogSetNextSong(ConfigSong song) {} // 0x000000018672D4E0-0x000000018672D7B0
			[AudioLogMethod] // 0x0000000189A01A60-0x0000000189A01AC0
			// [Conditional] // 0x0000000189A01A60-0x0000000189A01AC0
			// [XID] // 0x0000000189A01A60-0x0000000189A01AC0
			public static void LogSetSwitchValue(ConfigWwiseString switchValue) {} // 0x000000018672D7B0-0x000000018672DAA0
			[AudioLogMethod] // 0x0000000189A0F1E0-0x0000000189A0F240
			// [Conditional] // 0x0000000189A0F1E0-0x0000000189A0F240
			// [XID] // 0x0000000189A0F1E0-0x0000000189A0F240
			public static void LogAbortTransition(ConfigSong song) {} // 0x000000018672BD80-0x000000018672C070
			// [IDTag] // 0x0000000189A1C510-0x0000000189A1C550
			// [XID] // 0x0000000189A1C510-0x0000000189A1C550
			private static void AppendGameParam(ReusedStringBuilder reused, MusicGameParam gameParam, GameParamStorage paramStorage) {} // 0x000000018672BB70-0x000000018672BD80
			private static void AppendGameParam<TValue>(ReusedStringBuilder reused, MusicGameParam gameParam, GameParamStorage parmStorage) {}
			// [IDTag] // 0x0000000189A26B30-0x0000000189A26B70
			// [XID] // 0x0000000189A26B30-0x0000000189A26B70
			private static void AppendGameParam(ReusedStringBuilder reused, MusicGameParam gameParam, string valueText, TextColor valueTextColor) {} // 0x000000018672BA40-0x000000018672BB70
			private static void AppendArray<T>(ReusedStringBuilder reused, T[] items) {}
			private static void AppendArray<T>(ReusedStringBuilder reused, T[] items, ILiteralizer<T> literalizer) {}
			private static string LiteralizeList<T>(IList<T> list) => default;
			private static string LiteralizeList<T>(IList<T> list, ILiteralizer<T> literalizer) => default;
			private static string LiteralizeAvlTree<T>(AVLTreeOnArray<T> tree)
				where T : struct => default;
			private static string LiteralizeAvlTree<T>(AVLTreeOnArray<T> tree, ILiteralizer<T> literalizer)
				where T : struct => default;
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Timeline // TypeDefIndex: 11141
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Event // TypeDefIndex: 11142
			{
				// Methods
				[AudioLogMethod] // 0x0000000189A97590-0x0000000189A975F0
				// [Conditional] // 0x0000000189A97590-0x0000000189A975F0
				// [XID] // 0x0000000189A97590-0x0000000189A975F0
				public static void LogBehaviourPostEvent(object playable, uint eventId) {} // 0x0000000186721BF0-0x0000000186721F90
				[AudioLogMethod] // 0x0000000189AA4A80-0x0000000189AA4AE0
				// [Conditional] // 0x0000000189AA4A80-0x0000000189AA4AE0
				// [XID] // 0x0000000189AA4A80-0x0000000189AA4AE0
				public static void LogCallOnRegisterMonoWwiseAudio(MonoWwiseAudio mono) {} // 0x0000000186721F90-0x0000000186722250
				[AudioLogMethod] // 0x0000000189AB2430-0x0000000189AB2490
				// [Conditional] // 0x0000000189AB2430-0x0000000189AB2490
				// [XID] // 0x0000000189AB2430-0x0000000189AB2490
				public static void LogRegisterMonoWwiseAudio(MonoWwiseAudio mono) {} // 0x0000000186722B40-0x0000000186722E00
				[AudioLogMethod] // 0x0000000189ABFBA0-0x0000000189ABFC00
				// [Conditional] // 0x0000000189ABFBA0-0x0000000189ABFC00
				// [XID] // 0x0000000189ABFBA0-0x0000000189ABFC00
				public static void LogCallOnUnregisterMonoWwiseAudio(MonoWwiseAudio mono) {} // 0x0000000186722250-0x0000000186722510
				[AudioLogMethod] // 0x0000000189ACD6C0-0x0000000189ACD720
				// [Conditional] // 0x0000000189ACD6C0-0x0000000189ACD720
				// [XID] // 0x0000000189ACD6C0-0x0000000189ACD720
				public static void LogUnregisterMonoWwiseAudio(MonoWwiseAudio mono) {} // 0x0000000186722E00-0x00000001867230C0
				[AudioLogMethod] // 0x0000000189ADB210-0x0000000189ADB270
				// [Conditional] // 0x0000000189ADB210-0x0000000189ADB270
				// [XID] // 0x0000000189ADB210-0x0000000189ADB270
				public static void LogMonoWwiseAudioPostEvent(MonoWwiseAudio mono, uint eventId) {} // 0x0000000186722510-0x0000000186722880
				[AudioLogMethod] // 0x0000000189AE8A90-0x0000000189AE8AF0
				// [Conditional] // 0x0000000189AE8A90-0x0000000189AE8AF0
				// [XID] // 0x0000000189AE8A90-0x0000000189AE8AF0
				public static void LogMonoWwiseAudioStopAll(MonoWwiseAudio mono) {} // 0x0000000186722880-0x0000000186722B40
				// [XID] // 0x0000000189B2A700-0x0000000189B2A720
				private static void AppendMonoWwiseAudioTypeName(ReusedStringBuilder reused) {} // 0x0000000186721AC0-0x0000000186721BF0
				// [XID] // 0x0000000189B31C10-0x0000000189B31C30
				private static void AppendMonoWwiseAudioInstanceName(ReusedStringBuilder reused, MonoWwiseAudio mono, TextColor color) {} // 0x0000000186721930-0x0000000186721AC0
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class State // TypeDefIndex: 11143
			{
				// Methods
				[AudioLogMethod] // 0x0000000189B0CAE0-0x0000000189B0CB40
				// [Conditional] // 0x0000000189B0CAE0-0x0000000189B0CB40
				// [XID] // 0x0000000189B0CAE0-0x0000000189B0CB40
				public static void LogCallOnFireEvent() {} // 0x0000000186734A30-0x0000000186734BD0
				[AudioLogMethod] // 0x0000000189B19EA0-0x0000000189B19F00
				// [Conditional] // 0x0000000189B19EA0-0x0000000189B19F00
				// [XID] // 0x0000000189B19EA0-0x0000000189B19F00
				public static void LogWillFireEvent(string stateGroup, string stateValue) {} // 0x0000000186734BD0-0x0000000186734EB0
			}
	
			// Methods
			[AudioLogMethod] // 0x0000000189871E50-0x0000000189871E90
			// [Conditional] // 0x0000000189871E50-0x0000000189871E90
			public static void LogCreatePlayable<T>(string clipName, int clipInstanceId, object playable) {}
			[AudioLogMethod] // 0x0000000189A59850-0x0000000189A598B0
			// [Conditional] // 0x0000000189A59850-0x0000000189A598B0
			// [XID] // 0x0000000189A59850-0x0000000189A598B0
			public static void LogBehaviourPlay(object playable) {} // 0x00000001867378E0-0x0000000186737BC0
			[AudioLogMethod] // 0x0000000189A67390-0x0000000189A673F0
			// [Conditional] // 0x0000000189A67390-0x0000000189A673F0
			// [XID] // 0x0000000189A67390-0x0000000189A673F0
			public static void LogBehaviourProcessFrame(object playable) {} // 0x0000000186737BC0-0x0000000186737EA0
			[AudioLogMethod] // 0x0000000189A74840-0x0000000189A748A0
			// [Conditional] // 0x0000000189A74840-0x0000000189A748A0
			// [XID] // 0x0000000189A74840-0x0000000189A748A0
			public static void LogBehaviourPause(object playable) {} // 0x0000000186737600-0x00000001867378E0
			[AudioLogMethod] // 0x0000000189A824E0-0x0000000189A82540
			// [Conditional] // 0x0000000189A824E0-0x0000000189A82540
			// [XID] // 0x0000000189A824E0-0x0000000189A82540
			public static void LogBehaviourDestroy(object playable) {} // 0x0000000186737320-0x0000000186737600
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Voice // TypeDefIndex: 11144
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Callback // TypeDefIndex: 11145
			{
				// Methods
				[AudioLogMethod] // 0x0000000189B5D390-0x0000000189B5D3F0
				// [Conditional] // 0x0000000189B5D390-0x0000000189B5D3F0
				// [XID] // 0x0000000189B5D390-0x0000000189B5D3F0
				public static void LogEventStartCallback(VoicePipeline voicePipeline, uint postId, uint playingId) {} // 0x0000000186716EE0-0x0000000186717240
				[AudioLogMethod] // 0x0000000189B6AA90-0x0000000189B6AAF0
				// [Conditional] // 0x0000000189B6AA90-0x0000000189B6AAF0
				// [XID] // 0x0000000189B6AA90-0x0000000189B6AAF0
				public static void LogMissingPlayingNode() {} // 0x00000001867175C0-0x0000000186717860
				[AudioLogMethod] // 0x0000000189B77DC0-0x0000000189B77E20
				// [Conditional] // 0x0000000189B77DC0-0x0000000189B77E20
				// [XID] // 0x0000000189B77DC0-0x0000000189B77E20
				public static void LogPostIdMismatch(uint postIdFromCallback, uint postIdInPlayingNode) {} // 0x0000000186717B40-0x0000000186717E80
				[AudioLogMethod] // 0x0000000189B858E0-0x0000000189B85940
				// [Conditional] // 0x0000000189B858E0-0x0000000189B85940
				// [XID] // 0x0000000189B858E0-0x0000000189B85940
				public static void LogPlayFailed(int stub, uint postId) {} // 0x0000000186717860-0x0000000186717B40
				[AudioLogMethod] // 0x0000000189B926C0-0x0000000189B92720
				// [Conditional] // 0x0000000189B926C0-0x0000000189B92720
				// [XID] // 0x0000000189B926C0-0x0000000189B92720
				public static void LogSetCurrentNodePlayingId(int stub, uint postId, uint playingId) {} // 0x0000000186717E80-0x0000000186718190
				[AudioLogMethod] // 0x0000000189B9FB00-0x0000000189B9FB60
				// [Conditional] // 0x0000000189B9FB00-0x0000000189B9FB60
				// [XID] // 0x0000000189B9FB00-0x0000000189B9FB60
				public static void LogVoicePipelineEventCallback(VoicePipeline voicePipeline, AkCallbackType callbackType, MmoronCallbackInfo info) {} // 0x0000000186718430-0x0000000186718800
				[AudioLogMethod] // 0x0000000189BACEE0-0x0000000189BACF40
				// [Conditional] // 0x0000000189BACEE0-0x0000000189BACF40
				// [XID] // 0x0000000189BACEE0-0x0000000189BACF40
				public static void LogUnproperCallback() {} // 0x0000000186718190-0x0000000186718430
				[AudioLogMethod] // 0x0000000189BBA2A0-0x0000000189BBA300
				// [Conditional] // 0x0000000189BBA2A0-0x0000000189BBA300
				// [XID] // 0x0000000189BBA2A0-0x0000000189BBA300
				public static void LogLackPossessionOfId(VoicePipeline voicePipeline, uint voiceId) {} // 0x0000000186717240-0x00000001867175C0
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Control // TypeDefIndex: 11146
			{
				// Methods
				[AudioLogMethod] // 0x0000000189BCF930-0x0000000189BCF990
				// [Conditional] // 0x0000000189BCF930-0x0000000189BCF990
				// [XID] // 0x0000000189BCF930-0x0000000189BCF990
				public static void LogTryPlayNextIntention(VoicePipeline voicePipeline) {} // 0x000000018671B1B0-0x000000018671B490
				[AudioLogMethod] // 0x0000000189BDD210-0x0000000189BDD270
				// [Conditional] // 0x0000000189BDD210-0x0000000189BDD270
				// [XID] // 0x0000000189BDD210-0x0000000189BDD270
				public static void LogHasNodePlaying(VoicePipeline voicePipeline, int stub) {} // 0x0000000186719500-0x0000000186719880
				[AudioLogMethod] // 0x00000001895EFC60-0x00000001895EFCC0
				// [Conditional] // 0x00000001895EFC60-0x00000001895EFCC0
				// [XID] // 0x00000001895EFC60-0x00000001895EFCC0
				public static void LogNoPendingIntentions(VoicePipeline voicePipeline) {} // 0x0000000186719B50-0x0000000186719E20
				[AudioLogMethod] // 0x00000001895FD250-0x00000001895FD2B0
				// [Conditional] // 0x00000001895FD250-0x00000001895FD2B0
				// [XID] // 0x00000001895FD250-0x00000001895FD2B0
				public static void LogInvalidVoiceId(AvatarVoicePipeline avatarVoicePipeline) {} // 0x0000000186719880-0x0000000186719B50
				[AudioLogMethod] // 0x000000018960AD40-0x000000018960ADA0
				// [Conditional] // 0x000000018960AD40-0x000000018960ADA0
				// [XID] // 0x000000018960AD40-0x000000018960ADA0
				public static void LogStartPlayingIntentionNode(VoicePipeline voicePipeline, int stub) {} // 0x000000018671A370-0x000000018671A670
				[AudioLogMethod] // 0x0000000189617F70-0x0000000189617FD0
				// [Conditional] // 0x0000000189617F70-0x0000000189617FD0
				// [XID] // 0x0000000189617F70-0x0000000189617FD0
				public static void LogPlayIntentionNode() {} // 0x0000000186719E20-0x000000018671A0C0
				[AudioLogMethod] // 0x0000000189625730-0x0000000189625790
				// [Conditional] // 0x0000000189625730-0x0000000189625790
				// [XID] // 0x0000000189625730-0x0000000189625790
				public static void LogSetPlayingNode(uint postId) {} // 0x000000018671A0C0-0x000000018671A370
				[AudioLogMethod] // 0x0000000189633030-0x0000000189633090
				// [Conditional] // 0x0000000189633030-0x0000000189633090
				// [XID] // 0x0000000189633030-0x0000000189633090
				public static void LogCancelVoiceIdRequest(VoicePipeline voicePipeline) {} // 0x0000000186718940-0x0000000186718C10
				[AudioLogMethod] // 0x00000001896407C0-0x0000000189640820
				// [Conditional] // 0x00000001896407C0-0x0000000189640820
				// [XID] // 0x00000001896407C0-0x0000000189640820
				public static void LogVoiceId(uint voiceId) {} // 0x000000018671B9F0-0x000000018671BD20
				[AudioLogMethod] // 0x000000018964E140-0x000000018964E1A0
				// [Conditional] // 0x000000018964E140-0x000000018964E1A0
				// [XID] // 0x000000018964E140-0x000000018964E1A0
				public static void LogStopByStub(VoicePipeline voicePipeline, int stub) {} // 0x000000018671A930-0x000000018671AC30
				[AudioLogMethod] // 0x000000018965B990-0x000000018965B9F0
				// [Conditional] // 0x000000018965B990-0x000000018965B9F0
				// [XID] // 0x000000018965B990-0x000000018965B9F0
				public static void LogStopByStubFailed(bool playingNodeIsNull) {} // 0x000000018671A670-0x000000018671A930
				[AudioLogMethod] // 0x0000000189669170-0x00000001896691D0
				// [Conditional] // 0x0000000189669170-0x00000001896691D0
				// [XID] // 0x0000000189669170-0x00000001896691D0
				public static void LogDropByStub(VoicePipeline voicePipeline, int stub) {} // 0x0000000186719200-0x0000000186719500
				[AudioLogMethod] // 0x0000000189676B50-0x0000000189676BB0
				// [Conditional] // 0x0000000189676B50-0x0000000189676BB0
				// [XID] // 0x0000000189676B50-0x0000000189676BB0
				public static void LogDropAllIntentions(VoicePipeline voicePipeline, int count) {} // 0x0000000186718F00-0x0000000186719200
				[AudioLogMethod] // 0x0000000189684280-0x00000001896842E0
				// [Conditional] // 0x0000000189684280-0x00000001896842E0
				// [XID] // 0x0000000189684280-0x00000001896842E0
				public static void LogStopCurrentInVoicePipeline(VoicePipeline voicePipeline) {} // 0x000000018671AC30-0x000000018671AF10
				[AudioLogMethod] // 0x0000000189692470-0x00000001896924D0
				// [Conditional] // 0x0000000189692470-0x00000001896924D0
				// [XID] // 0x0000000189692470-0x00000001896924D0
				public static void LogStopCurrentMissingPlayingNode() {} // 0x000000018671AF10-0x000000018671B1B0
				[AudioLogMethod] // 0x000000018969F6A0-0x000000018969F700
				// [Conditional] // 0x000000018969F6A0-0x000000018969F700
				// [XID] // 0x000000018969F6A0-0x000000018969F700
				public static void LogTryStopPendingVoiceEvent(uint postId) {} // 0x000000018671B490-0x000000018671B740
				[AudioLogMethod] // 0x00000001896ACAC0-0x00000001896ACB20
				// [Conditional] // 0x00000001896ACAC0-0x00000001896ACB20
				// [XID] // 0x00000001896ACAC0-0x00000001896ACB20
				public static void LogTryStopPlayingVoiceEvent(uint playingId) {} // 0x000000018671B740-0x000000018671B9F0
				[AudioLogMethod] // 0x00000001896B9BC0-0x00000001896B9C20
				// [Conditional] // 0x00000001896B9BC0-0x00000001896B9C20
				// [XID] // 0x00000001896B9BC0-0x00000001896B9C20
				public static void LogClearQueue(VoicePipeline voicePipeline, int count) {} // 0x0000000186718C10-0x0000000186718F00
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Data // TypeDefIndex: 11147
			{
				// Methods
				[AudioLogMethod] // 0x00000001896CE6E0-0x00000001896CE740
				// [Conditional] // 0x00000001896CE6E0-0x00000001896CE740
				// [XID] // 0x00000001896CE6E0-0x00000001896CE740
				public static void LogVoiceItemRoll(ExternalVoiceIdentity id, bool passed) {} // 0x000000018671CE10-0x000000018671D100
				[AudioLogMethod] // 0x00000001896DBA00-0x00000001896DBA60
				// [Conditional] // 0x00000001896DBA00-0x00000001896DBA60
				// [XID] // 0x00000001896DBA00-0x00000001896DBA60
				public static void LogVoicePickerParams(VoicePickerParams @params, ExternalVoiceIdentity id) {} // 0x000000018671D100-0x000000018671D470
				[AudioLogMethod] // 0x00000001896E9030-0x00000001896E9090
				// [Conditional] // 0x00000001896E9030-0x00000001896E9090
				// [XID] // 0x00000001896E9030-0x00000001896E9090
				public static void LogEmptyVoiceItem() {} // 0x000000018671BEC0-0x000000018671C060
				[AudioLogMethod] // 0x00000001896F6640-0x00000001896F66A0
				// [Conditional] // 0x00000001896F6640-0x00000001896F66A0
				// [XID] // 0x00000001896F6640-0x00000001896F66A0
				public static void LogVoicePlaylistStatus(CyclicBlock<int> history, ExternalVoiceSound[] candidates) {} // 0x000000018671D470-0x000000018671D830
				[AudioLogMethod] // 0x0000000189703AA0-0x0000000189703B00
				// [Conditional] // 0x0000000189703AA0-0x0000000189703B00
				// [XID] // 0x0000000189703AA0-0x0000000189703B00
				public static void LogLotterCandidateCount(int count) {} // 0x000000018671C060-0x000000018671C310
				[AudioLogMethod] // 0x00000001897114F0-0x0000000189711550
				// [Conditional] // 0x00000001897114F0-0x0000000189711550
				// [XID] // 0x00000001897114F0-0x0000000189711550
				public static void LogRandomResult(float value) {} // 0x000000018671CB50-0x000000018671CE10
				[AudioLogMethod] // 0x000000018971E840-0x000000018971E8A0
				// [Conditional] // 0x000000018971E840-0x000000018971E8A0
				// [XID] // 0x000000018971E840-0x000000018971E8A0
				public static void LogNumberOfCandidates(int number) {} // 0x000000018671C8A0-0x000000018671CB50
				[AudioLogMethod] // 0x000000018972BCA0-0x000000018972BD00
				// [Conditional] // 0x000000018972BCA0-0x000000018972BD00
				// [XID] // 0x000000018972BCA0-0x000000018972BD00
				public static void LogLotterResult(int index) {} // 0x000000018671C310-0x000000018671C5C0
				[AudioLogMethod] // 0x0000000189739280-0x00000001897392E0
				// [Conditional] // 0x0000000189739280-0x00000001897392E0
				// [XID] // 0x0000000189739280-0x00000001897392E0
				public static void LogNextSound(ExternalVoiceSound sound) {} // 0x000000018671C5C0-0x000000018671C8A0
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Entity // TypeDefIndex: 11148
			{
				// Methods
				[AudioLogMethod] // 0x000000018974E750-0x000000018974E7B0
				// [Conditional] // 0x000000018974E750-0x000000018974E7B0
				// [XID] // 0x000000018974E750-0x000000018974E7B0
				public static void LogPostDialogSpeechEvent(uint dialogId, VCBaseAudio vcAudio) {} // 0x00000001867206F0-0x0000000186720A70
				[AudioLogMethod] // 0x000000018975B970-0x000000018975B9D0
				// [Conditional] // 0x000000018975B970-0x000000018975B9D0
				// [XID] // 0x000000018975B970-0x000000018975B9D0
				public static void LogDialogPosterMissing() {} // 0x000000018671FCA0-0x000000018671FE40
				[AudioLogMethod] // 0x0000000189769190-0x00000001897691F0
				// [Conditional] // 0x0000000189769190-0x00000001897691F0
				// [XID] // 0x0000000189769190-0x00000001897691F0
				public static void LogPickVoiceForVoiceId(ExternalVoiceIdentity id) {} // 0x0000000186720420-0x00000001867206F0
				[AudioLogMethod] // 0x0000000189776A60-0x0000000189776AC0
				// [Conditional] // 0x0000000189776A60-0x0000000189776AC0
				// [XID] // 0x0000000189776A60-0x0000000189776AC0
				public static void LogMissingCorrespondingVoiceItem() {} // 0x0000000186720180-0x0000000186720420
				[AudioLogMethod] // 0x0000000189784140-0x00000001897841A0
				// [Conditional] // 0x0000000189784140-0x00000001897841A0
				// [XID] // 0x0000000189784140-0x00000001897841A0
				public static void LogDialogPluginMissing() {} // 0x000000018671FB00-0x000000018671FCA0
				[AudioLogMethod] // 0x0000000189791550-0x00000001897915B0
				// [Conditional] // 0x0000000189791550-0x00000001897915B0
				// [XID] // 0x0000000189791550-0x00000001897915B0
				public static void LogStopCurrentOnBaseAudio(VCBaseAudio vcAudio) {} // 0x0000000186720C10-0x0000000186720FC0
				[AudioLogMethod] // 0x000000018979F5D0-0x000000018979F630
				// [Conditional] // 0x000000018979F5D0-0x000000018979F630
				// [XID] // 0x000000018979F5D0-0x000000018979F630
				public static void LogStopCurrentAborted() {} // 0x0000000186720A70-0x0000000186720C10
				[AudioLogMethod] // 0x00000001897ACB40-0x00000001897ACBA0
				// [Conditional] // 0x00000001897ACB40-0x00000001897ACBA0
				// [XID] // 0x00000001897ACB40-0x00000001897ACBA0
				public static void LogVoicePluginMissingFromEmployer() {} // 0x0000000186721790-0x0000000186721930
				[AudioLogMethod] // 0x00000001897BA680-0x00000001897BA6E0
				// [Conditional] // 0x00000001897BA680-0x00000001897BA6E0
				// [XID] // 0x00000001897BA680-0x00000001897BA6E0
				public static void LogTryStopCurrentVoiceInTeamPipeline(AudioVoiceStreamPlugin voiceStreamPlugin) {} // 0x00000001867214A0-0x0000000186721790
				[AudioLogMethod] // 0x00000001897C8810-0x00000001897C8870
				// [Conditional] // 0x00000001897C8810-0x00000001897C8870
				// [XID] // 0x00000001897C8810-0x00000001897C8870
				public static void LogFailedFetchingTeamVoicePlugin() {} // 0x000000018671FFE0-0x0000000186720180
				[AudioLogMethod] // 0x00000001897D5D30-0x00000001897D5D90
				// [Conditional] // 0x00000001897D5D30-0x00000001897D5D90
				// [XID] // 0x00000001897D5D30-0x00000001897D5D90
				public static void LogFailedFetchingTeamVoicePipeline() {} // 0x000000018671FE40-0x000000018671FFE0
				[AudioLogMethod] // 0x00000001897E3620-0x00000001897E3680
				// [Conditional] // 0x00000001897E3620-0x00000001897E3680
				// [XID] // 0x00000001897E3620-0x00000001897E3680
				public static void LogTeamVoicePipelineIdle() {} // 0x0000000186721300-0x00000001867214A0
				[AudioLogMethod] // 0x00000001897F1240-0x00000001897F12A0
				// [Conditional] // 0x00000001897F1240-0x00000001897F12A0
				// [XID] // 0x00000001897F1240-0x00000001897F12A0
				public static void LogSubmitterMismatch() {} // 0x0000000186721160-0x0000000186721300
				[AudioLogMethod] // 0x00000001897FE5E0-0x00000001897FE640
				// [Conditional] // 0x00000001897FE5E0-0x00000001897FE640
				// [XID] // 0x00000001897FE5E0-0x00000001897FE640
				public static void LogSubmitterMatch() {} // 0x0000000186720FC0-0x0000000186721160
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class ID // TypeDefIndex: 11149
			{
				// Methods
				[AudioLogMethod] // 0x00000001898133A0-0x0000000189813400
				// [Conditional] // 0x00000001898133A0-0x0000000189813400
				// [XID] // 0x00000001898133A0-0x0000000189813400
				public static void LogRequestId(IVoiceIdPossessor requestor, VoiceIdentity voiceIdentity) {} // 0x0000000186728060-0x0000000186728360
				[AudioLogMethod] // 0x0000000189821200-0x0000000189821260
				// [Conditional] // 0x0000000189821200-0x0000000189821260
				// [XID] // 0x0000000189821200-0x0000000189821260
				public static void LogDirectGrant(Dictionary<VoiceIdentity, RecycledLinkedList<IVoiceIdPossessor>> allRequestors, VoiceIdentity voiceIdentity) {} // 0x00000001867260E0-0x0000000186726420
				[AudioLogMethod] // 0x000000018982E340-0x000000018982E3A0
				// [Conditional] // 0x000000018982E340-0x000000018982E3A0
				// [XID] // 0x000000018982E340-0x000000018982E3A0
				public static void LogReplacePossessor(IVoiceIdPossessor currentPossessor) {} // 0x0000000186727D80-0x0000000186728060
				[AudioLogMethod] // 0x000000018983B790-0x000000018983B7F0
				// [Conditional] // 0x000000018983B790-0x000000018983B7F0
				// [XID] // 0x000000018983B790-0x000000018983B7F0
				public static void LogDropRequest() {} // 0x0000000186726420-0x00000001867266C0
				[AudioLogMethod] // 0x00000001898489A0-0x0000000189848A00
				// [Conditional] // 0x00000001898489A0-0x0000000189848A00
				// [XID] // 0x00000001898489A0-0x0000000189848A00
				public static void LogQueueUp(int ordinal) {} // 0x00000001867274D0-0x0000000186727780
				[AudioLogMethod] // 0x0000000189855D90-0x0000000189855DF0
				// [Conditional] // 0x0000000189855D90-0x0000000189855DF0
				// [XID] // 0x0000000189855D90-0x0000000189855DF0
				public static void LogIllegalPossessorTriesToReleaseId(uint voiceId) {} // 0x00000001867269A0-0x0000000186726C70
				[AudioLogMethod] // 0x0000000189863600-0x0000000189863660
				// [Conditional] // 0x0000000189863600-0x0000000189863660
				// [XID] // 0x0000000189863600-0x0000000189863660
				public static void LogReleaseId(IVoiceIdPossessor possessor, VoiceIdentity voiceIdentity) {} // 0x0000000186727780-0x0000000186727A80
				[AudioLogMethod] // 0x0000000189870510-0x0000000189870570
				// [Conditional] // 0x0000000189870510-0x0000000189870570
				// [XID] // 0x0000000189870510-0x0000000189870570
				public static void LogPossessorMismatch(VoiceIdentity voiceIdentity, Dictionary<VoiceIdentity, IVoiceIdPossessor> possessors) {} // 0x00000001867270E0-0x00000001867274D0
				[AudioLogMethod] // 0x000000018987E1B0-0x000000018987E210
				// [Conditional] // 0x000000018987E1B0-0x000000018987E210
				// [XID] // 0x000000018987E1B0-0x000000018987E210
				public static void LogNoOtherCandidates() {} // 0x0000000186726F40-0x00000001867270E0
				[AudioLogMethod] // 0x000000018988AF70-0x000000018988AFD0
				// [Conditional] // 0x000000018988AF70-0x000000018988AFD0
				// [XID] // 0x000000018988AF70-0x000000018988AFD0
				public static void LogCandidate(IVoiceIdPossessor requestor) {} // 0x0000000186725E10-0x00000001867260E0
				[AudioLogMethod] // 0x0000000189898240-0x00000001898982A0
				// [Conditional] // 0x0000000189898240-0x00000001898982A0
				// [XID] // 0x0000000189898240-0x00000001898982A0
				public static void LogCandidatePlayingOtherIntention(IVoiceIdPossessor requestor) {} // 0x0000000186725870-0x0000000186725B40
				[AudioLogMethod] // 0x00000001898A59F0-0x00000001898A5A50
				// [Conditional] // 0x00000001898A59F0-0x00000001898A5A50
				// [XID] // 0x00000001898A59F0-0x00000001898A5A50
				public static void LogCandidateSpeechless(IVoiceIdPossessor requestor) {} // 0x0000000186725B40-0x0000000186725E10
				[AudioLogMethod] // 0x00000001898B2CE0-0x00000001898B2D40
				// [Conditional] // 0x00000001898B2CE0-0x00000001898B2D40
				// [XID] // 0x00000001898B2CE0-0x00000001898B2D40
				public static void LogCandidateLongsForOtherId(IVoiceIdPossessor requestor, uint voiceId) {} // 0x00000001867254F0-0x0000000186725870
				[AudioLogMethod] // 0x00000001898C0780-0x00000001898C07E0
				// [Conditional] // 0x00000001898C0780-0x00000001898C07E0
				// [XID] // 0x00000001898C0780-0x00000001898C07E0
				public static void LogGrantIdToCandidate(IVoiceIdPossessor requestor) {} // 0x00000001867266C0-0x00000001867269A0
				[AudioLogMethod] // 0x00000001898CDC70-0x00000001898CDCD0
				// [Conditional] // 0x00000001898CDC70-0x00000001898CDCD0
				// [XID] // 0x00000001898CDC70-0x00000001898CDCD0
				public static void LogIllegalPossessorTriesToRelinquishId(uint voiceId) {} // 0x0000000186726C70-0x0000000186726F40
				[AudioLogMethod] // 0x00000001898DB560-0x00000001898DB5C0
				// [Conditional] // 0x00000001898DB560-0x00000001898DB5C0
				// [XID] // 0x00000001898DB560-0x00000001898DB5C0
				public static void LogRelinquishId(IVoiceIdPossessor possessor, VoiceIdentity voiceIdentity) {} // 0x0000000186727A80-0x0000000186727D80
				[AudioLogMethod] // 0x00000001898E9970-0x00000001898E99D0
				// [Conditional] // 0x00000001898E9970-0x00000001898E99D0
				// [XID] // 0x00000001898E9970-0x00000001898E99D0
				public static void LogWeakChallenge() {} // 0x0000000186728360-0x0000000186728500
				// [XID] // 0x00000001898F6F80-0x00000001898F6FA0
				private static void AppendVoiceIdentity(ReusedStringBuilder reused, VoiceIdentity voiceIdentity) {} // 0x0000000186725300-0x00000001867254F0
				// [XID] // 0x00000001897A25A0-0x00000001897A25C0
				private static void AppendVoiceId(ReusedStringBuilder reused, uint voiceId) {} // 0x00000001867251B0-0x0000000186725300
			}
	
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Submission // TypeDefIndex: 11150
			{
				// Methods
				[AudioLogMethod] // 0x000000018990D7A0-0x000000018990D800
				// [Conditional] // 0x000000018990D7A0-0x000000018990D800
				// [XID] // 0x000000018990D7A0-0x000000018990D800
				public static void LogSubmitVoiceIntention(VoicePipeline voicePipeline, IVoiceIntention voiceIntention) {} // 0x0000000186736BC0-0x0000000186736F90
				[AudioLogMethod] // 0x000000018991B280-0x000000018991B2E0
				// [Conditional] // 0x000000018991B280-0x000000018991B2E0
				// [XID] // 0x000000018991B280-0x000000018991B2E0
				public static void LogInvalidIntention() {} // 0x00000001867357B0-0x0000000186735A50
				[AudioLogMethod] // 0x0000000189928950-0x00000001899289B0
				// [Conditional] // 0x0000000189928950-0x00000001899289B0
				// [XID] // 0x0000000189928950-0x00000001899289B0
				public static void LogNaiveVoiceIntention(NaiveVocieIntention naiveIntention) {} // 0x0000000186735E10-0x00000001867361D0
				[AudioLogMethod] // 0x0000000189935BE0-0x0000000189935C40
				// [Conditional] // 0x0000000189935BE0-0x0000000189935C40
				// [XID] // 0x0000000189935BE0-0x0000000189935C40
				public static void LogNaiveFakeAvatarVoiceIntention(NaiveFakeAvatarVoiceIntention naiveIntention) {} // 0x0000000186735A50-0x0000000186735E10
				[AudioLogMethod] // 0x0000000189943490-0x00000001899434F0
				// [Conditional] // 0x0000000189943490-0x00000001899434F0
				// [XID] // 0x0000000189943490-0x00000001899434F0
				public static void LogContextIsInactive() {} // 0x0000000186735270-0x0000000186735510
				[AudioLogMethod] // 0x0000000189950D70-0x0000000189950DD0
				// [Conditional] // 0x0000000189950D70-0x0000000189950DD0
				// [XID] // 0x0000000189950D70-0x0000000189950DD0
				public static void LogPipelineStatusOnSubmission(VoicePipelineWaitingList.Node playingNode, bool queueing) {} // 0x0000000186736480-0x00000001867367C0
				[AudioLogMethod] // 0x000000018995E3B0-0x000000018995E410
				// [Conditional] // 0x000000018995E3B0-0x000000018995E410
				// [XID] // 0x000000018995E3B0-0x000000018995E410
				public static void LogSubmissionDecisions(bool dropIntention, bool cancelPreviousApplication, bool clearWaitingList, bool addAtFront, bool stopCurrentPlayingNode, bool tryPlayAfterSubmission) {} // 0x00000001867367C0-0x0000000186736BC0
				[AudioLogMethod] // 0x000000018996B9D0-0x000000018996BA30
				// [Conditional] // 0x000000018996B9D0-0x000000018996BA30
				// [XID] // 0x000000018996B9D0-0x000000018996BA30
				public static void LogDropIntention() {} // 0x0000000186735510-0x00000001867357B0
				[AudioLogMethod] // 0x0000000189979840-0x00000001899798A0
				// [Conditional] // 0x0000000189979840-0x00000001899798A0
				// [XID] // 0x0000000189979840-0x00000001899798A0
				public static void LogNewIntentionNodeStub(int stub) {} // 0x00000001867361D0-0x0000000186736480
				[AudioLogMethod] // 0x00000001899869B0-0x0000000189986A10
				// [Conditional] // 0x00000001899869B0-0x0000000189986A10
				// [XID] // 0x00000001899869B0-0x0000000189986A10
				public static void LogAddIntentionToQueue(bool atFront) {} // 0x0000000186734FB0-0x0000000186735270
			}
	
			// Methods
			// [IDTag] // 0x0000000189B2E960-0x0000000189B2E9A0
			// [XID] // 0x0000000189B2E960-0x0000000189B2E9A0
			private static void AppendBoolean(ReusedStringBuilder stringBuilder, bool value, string trueValueText) {} // 0x0000000186737FA0-0x00000001867381F0
			// [IDTag] // 0x0000000189B38ED0-0x0000000189B38F10
			// [XID] // 0x0000000189B38ED0-0x0000000189B38F10
			private static void AppendBoolean(ReusedStringBuilder stringBuilder, bool value, string trueValueText, string falseValueText) {} // 0x0000000186737EA0-0x0000000186737FA0
			// [IDTag] // 0x0000000189B43B90-0x0000000189B43BD0
			// [XID] // 0x0000000189B43B90-0x0000000189B43BD0
			private static void AppendBoolean(ReusedStringBuilder stringBuilder, bool value, string trueValueText, string falseValueText, TextColor trueValueColor, TextColor falseValueColor) {} // 0x00000001867381F0-0x0000000186738320
			// [XID] // 0x00000001898A8520-0x00000001898A8540
			private static string FormatVoiceId(ExternalVoiceIdentity id) => default; // 0x0000000186738320-0x00000001867385B0
		}
	
		[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
		public static class Stakeholders // TypeDefIndex: 11151
		{
			// Nested types
			[AudioLogModule] // 0x00000001898F6FA0-0x00000001898F6FB0
			public static class Lua // TypeDefIndex: 11152
			{
				// Methods
				[AudioLogMethod] // 0x00000001899A3AC0-0x00000001899A3B20
				// [Conditional] // 0x00000001899A3AC0-0x00000001899A3B20
				// [XID] // 0x00000001899A3AC0-0x00000001899A3B20
				public static void LogSetState(string stateGroup, string stateValue) {} // 0x00000001867287B0-0x0000000186728A90
			}
		}
	
		// Constructors
		static AudioLog() {} // 0x0000000184E80020-0x0000000184E80130
	
		// Methods
		// [XID] // 0x000000018994DBE0-0x000000018994DC00
		public static void SetInitializationTimestamp() {} // 0x0000000184E7FD80-0x0000000184E7FEE0
		// [XID] // 0x0000000189955260-0x0000000189955280
		public static void PrintStashedLogs() {} // 0x0000000184E7FA50-0x0000000184E7FD80
		// [Conditional] // 0x000000018995C9E0-0x000000018995CA40
		// [IDTag] // 0x000000018995C9E0-0x000000018995CA40
		// [XID] // 0x000000018995C9E0-0x000000018995CA40
		public static void Log(LogType logType, string message) {} // 0x0000000184E7F790-0x0000000184E7FA50
		// [Conditional] // 0x000000018996A190-0x000000018996A1F0
		// [IDTag] // 0x000000018996A190-0x000000018996A1F0
		// [XID] // 0x000000018996A190-0x000000018996A1F0
		public static void Log(LogType logType, MethodBase method, string message) {} // 0x0000000184E7F540-0x0000000184E7F790
		// [Conditional] // 0x0000000189977E40-0x0000000189977EB0
		// [IDTag] // 0x0000000189977E40-0x0000000189977EB0
		// [XID] // 0x0000000189977E40-0x0000000189977EB0
		public static void LogMessage(string message) {} // 0x0000000184E7F1E0-0x0000000184E7F2B0
		// [Conditional] // 0x0000000189985160-0x00000001899851C0
		// [IDTag] // 0x0000000189985160-0x00000001899851C0
		// [XID] // 0x0000000189985160-0x00000001899851C0
		public static void LogMessage(MethodBase method, string message) {} // 0x0000000184E7F2B0-0x0000000184E7F390
		// [Conditional] // 0x00000001899931A0-0x0000000189993200
		// [IDTag] // 0x00000001899931A0-0x0000000189993200
		// [XID] // 0x00000001899931A0-0x0000000189993200
		public static void LogWarning(string message) {} // 0x0000000184E7F470-0x0000000184E7F540
		// [Conditional] // 0x00000001899A0BD0-0x00000001899A0C30
		// [IDTag] // 0x00000001899A0BD0-0x00000001899A0C30
		// [XID] // 0x00000001899A0BD0-0x00000001899A0C30
		public static void LogWarning(MethodBase method, string message) {} // 0x0000000184E7F390-0x0000000184E7F470
		// [Conditional] // 0x00000001899AE470-0x00000001899AE4D0
		// [IDTag] // 0x00000001899AE470-0x00000001899AE4D0
		// [XID] // 0x00000001899AE470-0x00000001899AE4D0
		public static void LogError(string message) {} // 0x0000000184E7F030-0x0000000184E7F100
		// [Conditional] // 0x00000001899BBAF0-0x00000001899BBB60
		// [IDTag] // 0x00000001899BBAF0-0x00000001899BBB60
		// [XID] // 0x00000001899BBAF0-0x00000001899BBB60
		public static void LogError(MethodBase method, string message) {} // 0x0000000184E7F100-0x0000000184E7F1E0
		// [XID] // 0x00000001896212B0-0x00000001896212D0
		private static void CreateTextColorLiteralDictionary(out Dictionary<TextColor, string> dictionary) {
			dictionary = default;
		} // 0x0000000184E7DFF0-0x0000000184E7E110
		// [XID] // 0x0000000189630430-0x0000000189630450
		private static void CreateHexDigitArray(out char[] digits) {
			digits = default;
		} // 0x0000000184E7DD00-0x0000000184E7DDE0
		// [XID] // 0x00000001899D8050-0x00000001899D8070
		private static string Colorize(TextColor color, string text) => default; // 0x0000000184E7DBC0-0x0000000184E7DD00
		// [XID] // 0x00000001896953D0-0x00000001896953F0
		private static void AppendObjectHashCode(ReusedStringBuilder reused, object @object, TextColor color) {} // 0x0000000184E7D870-0x0000000184E7DA10
		// [XID] // 0x00000001896C1140-0x00000001896C1160
		private static void AppendObjectTypeName(ReusedStringBuilder reused, object @object, TextColor color) {} // 0x0000000184E7DA10-0x0000000184E7DBC0
		// [XID] // 0x00000001899EE630-0x00000001899EE650
		private static string FormatHashCodeInHex(object obj) => default; // 0x0000000184E7E110-0x0000000184E7E200
		// [XID] // 0x00000001896AB310-0x00000001896AB330
		private static string FormatNumberInHex(int value) => default; // 0x0000000184E7E360-0x0000000184E7E4C0
		// [XID] // 0x00000001896B2570-0x00000001896B2590
		private static void AppendNumberInHex(ReusedStringBuilder reused, int value) {} // 0x0000000184E7D740-0x0000000184E7D870
		// [XID] // 0x0000000189A04C80-0x0000000189A04CA0
		private static void AppendByteInHex(ReusedStringBuilder reused, byte b) {} // 0x0000000184E7D470-0x0000000184E7D5E0
		// [XID] // 0x0000000189A0C2F0-0x0000000189A0C310
		private static string FormatHashedName(uint hashId) => default; // 0x0000000184E7E200-0x0000000184E7E360
		// [XID] // 0x0000000189A13C90-0x0000000189A13CB0
		private static void AppendHashedName(ReusedStringBuilder reused, uint hashId) {} // 0x0000000184E7D5E0-0x0000000184E7D740
		// [XID] // 0x00000001896EC0D0-0x00000001896EC0F0
		private static string FormatVector3(Vector3 v) => default; // 0x0000000184E7E4C0-0x0000000184E7E6C0
		// [Conditional] // 0x0000000189A227F0-0x0000000189A22840
		// [XID] // 0x0000000189A227F0-0x0000000189A22840
		private static void InflateTextColorLiteralDictionary(Dictionary<TextColor, string> dictionary) {} // 0x0000000184E7EB50-0x0000000184E7ECF0
		// [XID] // 0x0000000189A34080-0x0000000189A340A0
		private static bool IsLogEnabled(MethodBase method) => default; // 0x0000000184E7ECF0-0x0000000184E7EE90
		// [XID] // 0x0000000189A3B750-0x0000000189A3B770
		private static bool ShallPrintStackTrace(MethodBase method) => default; // 0x0000000184E7FEE0-0x0000000184E80020
		// [XID] // 0x0000000189A43320-0x0000000189A43340
		private static void CreateLogStatusStructures(out Dictionary<System.Type, AudioLogModuleControlNode> typeLut, out Dictionary<int, AudioLogMethodControlNode> methodLut, out AudioLogModuleControlNode rootNode) {
			typeLut = default;
			methodLut = default;
			rootNode = default;
		} // 0x0000000184E7DDE0-0x0000000184E7DFF0
		// [Conditional] // 0x0000000189A4A7D0-0x0000000189A4A820
		// [XID] // 0x0000000189A4A7D0-0x0000000189A4A820
		private static void InflateLogStatusLookupTables(System.Type type, AudioLogModuleControlNode node) {} // 0x0000000184E7E6C0-0x0000000184E7EB50
		// [XID] // 0x0000000189A550F0-0x0000000189A55110
		private static bool IsLogModule(System.Type type) => default; // 0x0000000184E7EF60-0x0000000184E7F030
		// [XID] // 0x0000000189A5CA00-0x0000000189A5CA20
		private static bool IsLogMethod(MethodInfo method) => default; // 0x0000000184E7EE90-0x0000000184E7EF60
		private static bool HasCustomAttribute<T>(MemberInfo info)
			where T : Attribute => default;
	}
}
