/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Obsolete] // 0x00000001896618D0-0x0000000189661900
public class CriAtomAcfInfo // TypeDefIndex: 6978
{
	// Fields
	public static AcfInfo acfInfo; // 0x00

	// Nested types
	[Serializable]
	[Obsolete] // 0x0000000189673EC0-0x0000000189673EF0
	public class InfoBase // TypeDefIndex: 6979
	{
		// Fields
		public string name; // 0x10
		public int id; // 0x18
		public string comment; // 0x20

		// Constructors
		public InfoBase() {} // 0x00000001877792B0-0x0000000187779330
	}

	[Serializable]
	[Obsolete] // 0x000000018967CEC0-0x000000018967CEF0
	public class AcfInfo : InfoBase // TypeDefIndex: 6980
	{
		// Fields
		public string acfPath; // 0x28
		public string atomGuid; // 0x30
		public string dspBusSetting; // 0x38
		public List<string> aisacControlNameList; // 0x40
		public string acfFilePath; // 0x48

		// Constructors
		public AcfInfo() {} // Dummy constructor
		public AcfInfo(string n, int inId, string com, string inAcfPath, string _guid, string _dspBusSetting) {} // 0x000000018775E0B0-0x000000018775E680
	}

	[Serializable]
	[Obsolete] // 0x0000000189685D30-0x0000000189685D60
	public class AcbInfo : InfoBase // TypeDefIndex: 6981
	{
		// Fields
		public string acbPath; // 0x28
		public string awbPath; // 0x30
		public string atomGuid; // 0x38
		public List<CueInfo> cueInfoList; // 0x40

		// Constructors
		public AcbInfo() {} // Dummy constructor
		public AcbInfo(string n, int inId, string com, string inAcbPath, string inAwbPath, string _guid) {} // 0x000000018775C310-0x000000018775CA50
	}

	[Serializable]
	[Obsolete] // 0x000000018968F3C0-0x000000018968F3F0
	public class CueInfo : InfoBase // TypeDefIndex: 6982
	{
		// Constructors
		public CueInfo() {} // Dummy constructor
		public CueInfo(string n, int inId, string com) {} // 0x0000000187777290-0x00000001877779B0
	}

	// Constructors
	public CriAtomAcfInfo() {} // 0x000000018775FCD0-0x000000018775FD30
	static CriAtomAcfInfo() {} // 0x000000018775FC70-0x000000018775FCD0

	// Methods
	[Obsolete] // 0x000000018966AB30-0x000000018966AB60
	public static bool GetCueInfo(ref AcfInfo acfInfo, bool forceReload, string searchPath) => default; // 0x000000018775F9E0-0x000000018775FC70
}

