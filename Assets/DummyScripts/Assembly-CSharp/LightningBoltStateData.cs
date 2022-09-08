/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using DigitalRuby.ThunderAndLightning;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LightningBoltStateData : ITaskData // TypeDefIndex: 26612
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 25; // Metadata: 0x00B0C6C0
	private int _uid; // 0x14
	public bool isInThreadWorking; // 0x18
	public Queue<LightningBolt> prepareToProcess; // 0x20
	public LinkedList<IEnumerator> processingList; // 0x28
	public Queue<IMainThreadActionCache> mainThreadActions; // 0x30

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001897DF3E0-0x00000001897DF400 */ get => default; } // 0x00000001837E3400-0x00000001837E3530 
	public int nodeIndex { /* [XID] */ /* 0x00000001897E6CA0-0x00000001897E6CE0 */ get; /* [XID] */ /* 0x00000001897F1AF0-0x00000001897F1B30 */ set; } // 0x00000001837E3710-0x00000001837E3770 0x00000001837E38B0-0x00000001837E3910
	public int typeId { /* [XID] */ /* 0x00000001897FC3F0-0x00000001897FC410 */ get => default; } // 0x00000001837E3770-0x00000001837E3810 
	public int uid { /* [XID] */ /* 0x000000018981A040-0x000000018981A060 */ get => default; } // 0x00000001837E3810-0x00000001837E38B0 

	// Constructors
	public LightningBoltStateData() {} // 0x00000001837E3630-0x00000001837E3710
	static LightningBoltStateData() {} // 0x00000001837E35D0-0x00000001837E3630

	// Methods
	// [XID] // 0x0000000189803990-0x00000001898039B0
	public void Init() {} // 0x00000001837E3340-0x00000001837E3400
	// [XID] // 0x000000018980AE60-0x000000018980AE80
	public void Write() {} // 0x00000001837E3530-0x00000001837E35D0
	// [XID] // 0x0000000189812440-0x0000000189812460
	public void Free() {} // 0x00000001837E30B0-0x00000001837E3160
	// [XID] // 0x00000001898217E0-0x0000000189821800
	private void Clear() {} // 0x00000001837E3160-0x00000001837E3340
}

