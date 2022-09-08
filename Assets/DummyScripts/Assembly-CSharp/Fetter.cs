/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Fetter // TypeDefIndex: 29539
{
	// Nested types
	public enum FetterType // TypeDefIndex: 29540
	{
		Story = 0,
		Voice = 1
	}

	public class Data // TypeDefIndex: 29541
	{
		// Fields
		public uint dataId; // 0x10
		public FetterType type; // 0x14
		public string dataTitle; // 0x18
		public string dataContent; // 0x20
		public List<string> lockConditions; // 0x28
		public RepeatedField<uint> finishedConditionIndexes; // 0x30
		public string voicePath; // 0x38
		private FetterState _fetterState; // 0x40

		// Properties
		public FetterState fetterState { /* [XID] */ /* 0x0000000189602290-0x00000001896022B0 */ get => default; /* [XID] */ /* 0x0000000189609A70-0x0000000189609A90 */ set {} } // 0x0000000184A2BB00-0x0000000184A2BBA0 0x0000000184A2BBA0-0x0000000184A2BC50

		// Constructors
		public Data() {} // Dummy constructor
		public Data(uint id, FetterType t, List<string> conds, RepeatedField<uint> finishedIndexes, string title, string content, string voiceStr = null) {} // 0x0000000184A2BC50-0x0000000184A2BD00
	}

	// Constructors
	public Fetter() {} // 0x0000000184A2CEF0-0x0000000184A2CF50

	// Methods
	// [XID] // 0x00000001895EBCC0-0x00000001895EBCE0
	public static List<Data> Generate(FetterType type, AvatarDataItem avatarDataItem) => default; // 0x0000000184A2BE20-0x0000000184A2CC40
	// [XID] // 0x00000001895F3060-0x00000001895F3080
	private static string GetStoryTitle(FetterData data, FetterStoryExcelConfig config) => default; // 0x0000000184A2CC40-0x0000000184A2CDC0
	// [XID] // 0x00000001895FA8A0-0x00000001895FA8C0
	private static string GetVoiceTitle(FetterData data, FettersExcelConfig config) => default; // 0x0000000184A2CDC0-0x0000000184A2CEF0
}

