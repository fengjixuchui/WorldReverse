/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Ability // TypeDefIndex: 20569
{
	// Fields
	private static int _nextDataId; // 0x00
	private int _uid; // 0x10
	protected bool _shouldPreActive; // 0x14
	protected ConfigAbilityTask[] _taskConfigs; // 0x18

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189930B20-0x0000000189930B40 */ get => default; } // 0x0000000181868630-0x0000000181868760 
	public int uid { /* [XID] */ /* 0x0000000189B6C090-0x0000000189B6C0B0 */ get => default; } // 0x0000000181868340-0x00000001818683E0 
	public bool shouldPreActive { /* [XID] */ /* 0x000000018993F980-0x000000018993F9A0 */ get => default; } // 0x0000000181868590-0x0000000181868630 

	// Constructors
	public Ability() {} // 0x0000000181868860-0x00000001818688E0
	static Ability() {} // 0x0000000181868800-0x0000000181868860

	// Methods
	// [XID] // 0x0000000189B738D0-0x0000000189B738F0
	public ConfigAbilityTask[] GetTaskConfigs() => default; // 0x0000000181868760-0x0000000181868800
	// [XID] // 0x000000018994E6A0-0x000000018994E6C0
	public void Init(ConfigAbilitySystem abilityConfig) {} // 0x0000000181868490-0x0000000181868590
	// [XID] // 0x0000000189703C20-0x0000000189703C40
	public void Destroy() {} // 0x00000001818683E0-0x0000000181868490
}

