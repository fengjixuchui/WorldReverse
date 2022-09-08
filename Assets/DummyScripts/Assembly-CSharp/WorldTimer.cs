/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WorldTimer : ISimplePoolObject, ITickableObject<uint> // TypeDefIndex: 21386
{
	// Fields
	private static SimpleObjectPool<WorldTimer> _pool; // 0x00
	private uint _key; // 0x20
	private float _duration; // 0x24
	private float _timeCnt; // 0x28
	private bool _isFinished; // 0x2C

	// Properties
	public uint key { /* [XID] */ /* 0x00000001897178C0-0x00000001897178E0 */ get => default; } // 0x00000001825716B0-0x0000000182571750 
	public int index { get; set; } // 0x0000000182571AF0-0x0000000182571B50 0x0000000182571B50-0x0000000182571BB0
	public static SimpleObjectPool<WorldTimer> pool { /* [XID] */ /* 0x000000018972DEF0-0x000000018972DF10 */ get => default; } // 0x0000000182571D30-0x0000000182571E70 
	public bool isFinished { /* [XID] */ /* 0x000000018975AAA0-0x000000018975AAC0 */ get => default; } // 0x0000000182571C90-0x0000000182571D30 

	// Events
	private event FinishHandler _finishHandler;

	// Nested types
	public delegate void FinishHandler(); // TypeDefIndex: 21387; 0x0000000182568930-0x0000000182568A90

	// Constructors
	public WorldTimer() {} // 0x00000001825720A0-0x0000000182572110
	static WorldTimer() {} // 0x0000000182572040-0x00000001825720A0

	// Methods
	// [XID] // 0x0000000189AED5D0-0x0000000189AED5F0
	public static WorldTimer Create(uint entityId, float duration, FinishHandler finishHandler) => default; // 0x0000000182571910-0x0000000182571A40
	// [XID] // 0x000000018973D0F0-0x000000018973D110
	public static void Release(WorldTimer timer) {} // 0x0000000182571BB0-0x0000000182571C90
	// [XID] // 0x0000000189753580-0x00000001897535A0
	private void CallFinishHandler() {} // 0x0000000182571A40-0x0000000182571AF0
	// [XID] // 0x0000000189B82840-0x0000000189B82860
	public void Init(uint key, float duration, FinishHandler finishHandler) {} // 0x0000000182571750-0x0000000182571840
	// [XID] // 0x0000000189769C90-0x0000000189769CB0
	public void Tick(float deltaTime) {} // 0x0000000182571840-0x0000000182571910
	// [XID] // 0x0000000189771280-0x00000001897712A0
	public void ResetObject() {} // 0x0000000182571F90-0x0000000182572040
}

