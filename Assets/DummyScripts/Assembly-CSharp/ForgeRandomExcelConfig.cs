/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ForgeRandomExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15623
{
	// Fields
	protected SimpleSafeUInt32 forgeRandomIdRawNum; // 0x10
	protected RandomItemConfig[] _mainRandomItems; // 0x18

	// Properties
	public uint forgeRandomId { /* [XID] */ /* 0x00000001896E58F0-0x00000001896E5910 */ get => default; /* [XID] */ /* 0x00000001896ECF00-0x00000001896ECF20 */ protected set {} } // 0x00000001819AFAE0-0x00000001819AFBB0 0x00000001819AFBB0-0x00000001819AFC90
	public RandomItemConfig[] mainRandomItems { /* [XID] */ /* 0x00000001896F47C0-0x00000001896F47E0 */ get => default; /* [XID] */ /* 0x00000001896FBFB0-0x00000001896FBFD0 */ protected set {} } // 0x00000001819AFA40-0x00000001819AFAE0 0x00000001819B0640-0x00000001819B06F0

	// Constructors
	public ForgeRandomExcelConfig() {} // 0x00000001819B08D0-0x00000001819B0930

	// Methods
	// [IDTag] // 0x00000001897035B0-0x00000001897035F0
	// [XID] // 0x00000001897035B0-0x00000001897035F0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819AFF70-0x00000001819B02D0
	// [IDTag] // 0x000000018970DC70-0x000000018970DCB0
	// [XID] // 0x000000018970DC70-0x000000018970DCB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819AFC90-0x00000001819AFF70
	// [XID] // 0x0000000189718230-0x0000000189718250
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20E4 */, bool useObjectPool = false /* Metadata: 0x00AF20E8 */) => default; // 0x00000001819B02D0-0x00000001819B0640
	[BlackList] // 0x000000018971FBF0-0x000000018971FC30
	// [XID] // 0x000000018971FBF0-0x000000018971FC30
	public virtual void AutoAllocTypeFields() {} // 0x00000001819AF8C0-0x00000001819AF960
	[BlackList] // 0x0000000189729FA0-0x0000000189729FE0
	// [XID] // 0x0000000189729FA0-0x0000000189729FE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819AF960-0x00000001819AFA40
	[BlackList] // 0x0000000189734710-0x0000000189734750
	// [XID] // 0x0000000189734710-0x0000000189734750
	public virtual void ReturnToObjectPool() {} // 0x00000001819B0830-0x00000001819B08D0
	[BlackList] // 0x000000018973F580-0x000000018973F5C0
	// [XID] // 0x000000018973F580-0x000000018973F5C0
	public virtual void OnPoolAllocated() {} // 0x00000001819B0790-0x00000001819B0830
	[BlackList] // 0x0000000189749A40-0x0000000189749A80
	// [XID] // 0x0000000189749A40-0x0000000189749A80
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819B06F0-0x00000001819B0790
}

