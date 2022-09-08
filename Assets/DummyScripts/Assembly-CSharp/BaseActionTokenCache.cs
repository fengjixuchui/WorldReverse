/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseActionTokenCache : IActionTokenCache // TypeDefIndex: 21018
{
	// Fields
	protected IActionTokenConfig _actionConfig; // 0x10
	protected ConfigAbilityActionToken _actionToken; // 0x18
	protected BaseEntity _targetEntity; // 0x20
	protected uint _targetRuntimeId; // 0x28
	protected ActionTokenSourceType _actionSrcType; // 0x2C

	// Properties
	public virtual bool isCanceled { /* [XID] */ /* 0x00000001899E6430-0x00000001899E6450 */ get; } // 0x00000001851D49B0-0x00000001851D4A70 
	public int priority { /* [XID] */ /* 0x00000001899ED940-0x00000001899ED980 */ get; set; } // 0x00000001851D48B0-0x00000001851D4910 0x00000001851D4500-0x00000001851D4560

	// Constructors
	protected BaseActionTokenCache() {} // 0x00000001851D4DA0-0x00000001851D4E20

	// Methods
	// [XID] // 0x00000001899A2C30-0x00000001899A2C50
	public IActionTokenConfig GetActionTokenConfig() => default; // 0x00000001851D4B10-0x00000001851D4BB0
	// [XID] // 0x00000001899AA680-0x00000001899AA6A0
	public ConfigAbilityActionToken GetActionToken() => default; // 0x00000001851D4910-0x00000001851D49B0
	// [XID] // 0x00000001899B1FE0-0x00000001899B2000
	public BaseEntity GetTargetEntity() => default; // 0x00000001851D4D00-0x00000001851D4DA0
	// [XID] // 0x00000001899B9420-0x00000001899B9440
	public ActionTokenSourceType GetActionSrc() => default; // 0x00000001851D4A70-0x00000001851D4B10
	// [XID] // 0x00000001899C0E10-0x00000001899C0E30
	protected void Init(IActionTokenConfig actionConfig, BaseEntity targetEntity) {} // 0x00000001851D4630-0x00000001851D4710
	// [XID] // 0x00000001899C83F0-0x00000001899C8410
	public virtual bool HandleTokenCache() => default; // 0x00000001851D4560-0x00000001851D4630
	// [XID] // 0x00000001899CFE70-0x00000001899CFE90
	public virtual void Clear() {} // 0x00000001851D4710-0x00000001851D47C0
	// [XID] // 0x00000001899D7330-0x00000001899D7350
	public virtual void Destroy() {} // 0x00000001851D42D0-0x00000001851D43E0
	// [XID] // 0x00000001899DE710-0x00000001899DE730
	public int CompareTo(IActionTokenCache other) => default; // 0x00000001851D43E0-0x00000001851D4500
	// [XID] // 0x00000001899FF780-0x00000001899FF7A0
	public virtual bool NeverEnqueue() => default; // 0x00000001851D47C0-0x00000001851D48B0
	// [XID] // 0x00000001899E5E60-0x00000001899E5E80
	private void InitActionToken() {} // 0x00000001851D4BB0-0x00000001851D4D00
}

