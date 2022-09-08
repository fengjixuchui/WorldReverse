/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: NativeEdit.dll - Assembly: NativeEdit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6676-6688

public class JsonObject : UnityEngine.Object // TypeDefIndex: 6677
{
	// Fields
	public Dictionary<string, object> objectDict; // 0x18

	// Properties
	public object this[string key] { get => default; set {} } // 0x0000000189507B70-0x0000000189507C00 0x0000000189507C00-0x0000000189507CA0

	// Constructors
	public JsonObject() {} // 0x0000000189507990-0x0000000189507A40
	public JsonObject(string strJson) {} // 0x0000000189507860-0x0000000189507990
	public JsonObject(Dictionary<string, object> dict) {} // 0x0000000189507A40-0x0000000189507AD0

	// Methods
	public string getCmd() => default; // 0x0000000189507AD0-0x0000000189507B70
	public string Serialize() => default; // 0x00000001895077B0-0x0000000189507860
	private object GetDictValue(string key) => default; // 0x0000000189506F40-0x0000000189506FF0
	public bool KeyExist(string key) => default; // 0x0000000189507710-0x00000001895077B0
	public Dictionary<string, object> GetJsonDict(string key) => default; // 0x0000000189507290-0x0000000189507360
	public JsonObject GetJsonObject(string key) => default; // 0x0000000189507360-0x0000000189507400
	public bool GetBool(string key) => default; // 0x0000000189506E60-0x0000000189506F40
	public int GetInt(string key) => default; // 0x00000001895071D0-0x0000000189507290
	public float GetFloat(string key) => default; // 0x0000000189507100-0x00000001895071D0
	public string GetString(string key) => default; // 0x0000000189507670-0x0000000189507710
	public object GetEnum(System.Type type, string key) => default; // 0x0000000189506FF0-0x0000000189507100
	public List<JsonObject> GetListJsonObject(string key) => default; // 0x0000000189507400-0x0000000189507670
}

