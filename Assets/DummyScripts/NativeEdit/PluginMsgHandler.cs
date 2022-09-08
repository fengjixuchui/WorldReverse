/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: NativeEdit.dll - Assembly: NativeEdit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6676-6688

public class PluginMsgHandler : MonoBehaviour // TypeDefIndex: 6687
{
	// Fields
	private static PluginMsgHandler _instance; // 0x00
	private int _curReceiverIndex; // 0x18
	private Dictionary<int, PluginMsgReceiver> _receiverDict; // 0x20
	private const string DEFAULT_NAME = "NativeEditPluginHandler"; // Metadata: 0x00ADDAEF

	// Properties
	private bool isEditor { get => default; } // 0x000000018950BCF0-0x000000018950BD40 
	private bool isStandalone { get => default; } // 0x000000018950BD40-0x000000018950BD90 

	// Constructors
	public PluginMsgHandler() {} // 0x000000018950BC90-0x000000018950BCF0

	// Methods
	public static PluginMsgHandler GetInstanceForReceiver(PluginMsgReceiver receiver) => default; // 0x000000018950B690-0x000000018950B790
	private void Awake() {} // 0x000000018950B580-0x000000018950B640
	private void OnDestroy() {} // 0x000000018950B870-0x000000018950B910
	public int RegisterAndGetReceiverId(PluginMsgReceiver receiver) => default; // 0x000000018950BA20-0x000000018950BB20
	public void RemoveReceiver(int nReceiverId) {} // 0x000000018950BB20-0x000000018950BC20
	public PluginMsgReceiver GetReceiver(int nSenderId) => default; // 0x000000018950B790-0x000000018950B820
	private void OnMsgFromPlugin(string jsonPluginMsg) {} // 0x000000018950B910-0x000000018950BA20
	public void InitializeHandler() {} // 0x000000018950B820-0x000000018950B870
	public void FinalizeHandler() {} // 0x000000018950B640-0x000000018950B690
	public JsonObject SendMsgToPlugin(int nSenderId, JsonObject jsonMsg) => default; // 0x000000018950BC20-0x000000018950BC90
}

