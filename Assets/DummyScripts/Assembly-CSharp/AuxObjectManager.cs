/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AuxObjectManager : InLevelManager // TypeDefIndex: 20740
{
	// Fields
	private Dictionary<uint, List<MonoAuxObject>> _auxObjectMap; // 0x10
	private Dictionary<string, GameObject> _cacheObjectMap; // 0x18
	private Dictionary<string, uint> _cacheObjectHandleMap; // 0x20

	// Constructors
	public AuxObjectManager() {} // 0x0000000182AF1DF0-0x0000000182AF1E50

	// Methods
	// [XID] // 0x000000018990E2B0-0x000000018990E2D0
	public override void Init() {} // 0x0000000182AF1A50-0x0000000182AF1B60
	// [XID] // 0x0000000189915A20-0x0000000189915A40
	public override void Destroy() {} // 0x0000000182AF1290-0x0000000182AF16E0
	// [XID] // 0x000000018991D3B0-0x000000018991D3D0
	public GameObject LoadAuxObjectProto(string name) => default; // 0x0000000182AF16E0-0x0000000182AF1970
	// [XID] // 0x0000000189924D40-0x0000000189924D60
	public MonoAuxObject CreateSimpleAuxObject(string name, uint ownerID) => default; // 0x0000000182AF1970-0x0000000182AF1A50
	public T CreateAuxObject<T>(string name)
		where T : MonoAuxObject => default;
	public T CreateAuxObject<T>(string name, uint ownerID)
		where T : MonoAuxObject => default;
	private T LoadOrAddAuxObject<T>(string name, uint ownerID, bool addComponent)
		where T : MonoAuxObject => default;
	// [XID] // 0x000000018992C240-0x000000018992C260
	public void RegisterAuxObject(MonoAuxObject auxObj) {} // 0x0000000182AF1B60-0x0000000182AF1D10
	// [XID] // 0x00000001899336A0-0x00000001899336C0
	public MonoAuxObject GetAuxObject(uint ownerID, string entryName) => default; // 0x0000000182AF1D10-0x0000000182AF1DF0
	public T GetAuxObject<T>(uint ownerID, string entryName)
		where T : MonoAuxObject => default;
	public List<T> GetAuxObjects<T>(uint ownerID)
		where T : MonoAuxObject => default;
	public void ClearAuxObjects<T>(uint ownerID)
		where T : MonoAuxObject {}
}

