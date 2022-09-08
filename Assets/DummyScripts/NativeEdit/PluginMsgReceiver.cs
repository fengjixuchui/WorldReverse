/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: NativeEdit.dll - Assembly: NativeEdit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6676-6688

public abstract class PluginMsgReceiver : MonoBehaviour // TypeDefIndex: 6688
{
	// Fields
	private int _receiverId; // 0x18

	// Constructors
	protected PluginMsgReceiver() {} // 0x000000018950BF60-0x000000018950BFC0

	// Methods
	protected virtual void Start() {} // 0x000000018950BEE0-0x000000018950BF60
	protected virtual void OnDestroy() {} // 0x000000018950BD90-0x000000018950BE10
	protected JsonObject SendPluginMsg(JsonObject jsonMsg) => default; // 0x000000018950BE10-0x000000018950BEE0
	public abstract void OnPluginMsgDirect(JsonObject jsonMsg);
}

