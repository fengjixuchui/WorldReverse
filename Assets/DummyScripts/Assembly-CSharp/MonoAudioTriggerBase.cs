/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class MonoAudioTriggerBase : MonoBehaviour // TypeDefIndex: 31690
{
	// Fields
	[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
	[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
	private MonoAudioTriggerHandler _handler; // 0x18

	// Properties
	public bool isHandlerSet { get; } // 0x0000000181D7F2F0-0x0000000181D7F380 

	// Constructors
	protected MonoAudioTriggerBase() {} // 0x0000000181D7F290-0x0000000181D7F2F0

	// Methods
	public virtual void DoTrigger() {} // 0x0000000181D7F040-0x0000000181D7F100
	// [Conditional] // 0x00000001896BE330-0x00000001896BE360
	public void SetHandler(MonoAudioTriggerHandler handler) {} // 0x0000000181D7F230-0x0000000181D7F290
	// [Conditional] // 0x00000001896BE330-0x00000001896BE360
	public void FindHandler() {} // 0x0000000181D7F100-0x0000000181D7F230
	// [Conditional] // 0x00000001896BE330-0x00000001896BE360
	private void Awake() {} // 0x0000000181D7EFE0-0x0000000181D7F040
}

