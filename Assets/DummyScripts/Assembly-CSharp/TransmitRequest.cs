/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct TransmitRequest // TypeDefIndex: 19896
{
	// Fields
	public BaseActor actor; // 0x00
	public uint sceneId; // 0x08
	public Vector3 targetPos; // 0x0C
	public Vector3 targetEuler; // 0x18
	public string[] textMapId; // 0x28
	public float textShowTime; // 0x30
	public Action<ILuaActor> transFinishCallback; // 0x38
	public Action<ILuaActor> transPreCallback; // 0x40
	public CurtainTask task; // 0x48
	public uint questId; // 0x50
	public uint pointId; // 0x54
}

