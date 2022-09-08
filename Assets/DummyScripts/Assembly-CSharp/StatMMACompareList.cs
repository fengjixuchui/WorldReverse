/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StatMMACompareList // TypeDefIndex: 27857
{
	// Fields
	private List<StatCompareMMA> _data; // 0x10
	private string _dirName; // 0x18
	private List<string> _fileNames; // 0x20

	// Properties
	public string dirName { /* [XID] */ /* 0x00000001897FEF90-0x00000001897FEFB0 */ get => default; } // 0x0000000184D3C830-0x0000000184D3C8D0 
	public List<string> fileNames { /* [XID] */ /* 0x00000001898066F0-0x0000000189806710 */ get => default; } // 0x0000000184D3CC00-0x0000000184D3CCA0 
	private int _mergedFileCount { /* [XID] */ /* 0x000000018980DE70-0x000000018980DE90 */ get => default; } // 0x0000000184D3CCA0-0x0000000184D3CD60 

	// Constructors
	public StatMMACompareList() {} // 0x0000000184D3D170-0x0000000184D3D260

	// Methods
	// [XID] // 0x0000000189815590-0x00000001898155B0
	public void Compare(string fileFullPath, List<StatMMA> inMMAFile) {} // 0x0000000184D3CD60-0x0000000184D3D170
	// [XID] // 0x000000018981CF90-0x000000018981CFB0
	public void FillDataList(List<object> inData) {} // 0x0000000184D3C8D0-0x0000000184D3CA70
	// [XID] // 0x0000000189824360-0x0000000189824380
	public void OnFinishCompare() {} // 0x0000000184D3CA70-0x0000000184D3CC00
}

